// This class will be used to perform all the database related operations
// like insert, update, delete, select etc.
// We eill be using the LinqToDB library to perform the database operations


using Data;
using LinqToDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Logic.Library.Calls
{

    // This class will contain all the methods that will be used to perform the database operations
    // Also this class will inherit from the Connection class

    public class DBlogic : Connection
    {
        public void AddEnchantment(List<TextBox> ListOfProperties, TextBox searchBar, DataGridView dataGridViewL, DataGridView dataGridViewR)
        {
            //Connection db = new Connection();
            //db.Insert(new EnchantmentsDB()
            //{
            //    eName = ListOfProperties[0].Text,
            //    eDescription = ListOfProperties[1].Text,
            //    ePower = ListOfProperties[2].Text,
            //    eTreasure = ListOfProperties[3].Text
            //});


            // In order to insert the data into the database we will bew using a transaction
            // We will be using the transaction to make sure that all the data is inserted into the database
            // If one of the data is not inserted into the database then the transaction will be rolled back
            // and the data will not be inserted into the database
            // We will be using the using keyword to make sure that the transaction is closed after the data is inserted into the database
            BeginTransactionAsync();
            try
            {

                // We will call the enchantmentsSB interface from the Connection class
                // We will use the Insert method to insert the data into the database
                // We will pass a new record to the Insert method, we can do this by using the .Value() method
                // Each .Value() method will contain a lambda expression that will contain all the indexers of the ListOfProperties
                // The insert method will insert the data stright
                enchantmentsSB.Value(e => e.eName, ListOfProperties[0].Text)
                              .Value(e => e.eDescription, ListOfProperties[1].Text)
                              .Value(e => e.ePower, ListOfProperties[2].Text)
                              .Value(e => e.eTreasure, ListOfProperties[3].Text)
                              .Insert();

                // If the data is inserted into the database then we will commit the transaction
                CommitTransaction();
            }
            catch (Exception)
            {

                // If the data is not inserted into the database then we will rollback the transaction
                RollbackTransaction();
            }
            DisplayPropertiesRight(searchBar, dataGridViewR);
            DisplayPropertiesLeft(searchBar, dataGridViewL);

        }
        public bool EnchantmentExists(List<TextBox> listOfProperties)
        {

            // We will create a variable that will contain a list of names of the enchantments
            // We will acomplish this by using the .Where() method
            // The .Where() method will contain a lambda expression that will contain the indexer of the listOfProperties
            // And the .Equals() method will be used to compare the value of the indexer with the value of the eName column
            var name = enchantmentsSB.Where(u => u.eName.Equals(listOfProperties[0].Text)).ToList();

            // We will check if the name variable is empty, if it empty it means that the enchantment does not exist
            if (name.Count.Equals(0))
            {
                return false;
            }

            // If the name variable is not empty it means that the enchantment exists
            else
            {
                return true;
            }
        }
        // This two variables will bw used to define the number of rows that will be displayed in the DataGridView
        private int _reg_by_page = 1000; // , _num_of_pages = 1;
        public void DisplayPropertiesLeft(TextBox searchBar, DataGridView dataGridView)
        {
            // This varible is used to manage the pager of the DataGridView
            // But as we want just one page, the value of this variable will be 0
            //int head = (_num_of_pages - 1) * _reg_by_page;

            // We will create a variable that will contain a list of enchantments properties
            List<EnchantmentsDB> query = new List<EnchantmentsDB>();

            // We will check if the search bar is empty
            if (searchBar.Text.Equals(""))
            {
                // If it is empty, we will display all the enchantments, as the user did not search for anything
                query = enchantmentsSB.ToList();
            }
            else
            {
                // Instead if the search bar is not empty, we will display the enchantments that match the search
                query = enchantmentsSB.Where(c => c.eName.StartsWith(searchBar.Text)).ToList();
            }

            // If the query contains any data, we will display it in the DataGridView
            if (0 < query.Count)
            {
                // We will use the .DataSource property to display the data in the DataGridView
                // .DataSource will the query variable
                // But we will just display the eName Column
                dataGridView.DataSource = query.Select(c => new
                {
                    c.eName
                }).Take(_reg_by_page).ToList();
                // }).Skip(head).Take(_reg_by_page).ToList();
            }
        }
        public void DisplayPropertiesRight(TextBox searchBar, DataGridView dataGridView)
        {
            //int head = (_num_of_pages - 1) * _reg_by_page;

            // This List will contain the properties of the enchantments
            List<EnchantmentsDB> query = new List<EnchantmentsDB>();

            // We will check if the search bar is empty
            if (searchBar.Text.Equals(""))
            {
                query = enchantmentsSB.ToList();
            }
            else
            {
                query = enchantmentsSB.Where(c => c.eName.StartsWith(searchBar.Text)).ToList();
            }
            if (0 < query.Count)
            {
                dataGridView.DataSource = query.Select(c => new
                {
                    c.id,
                    c.eName,
                    c.eDescription,
                    c.ePower,
                    c.eTreasure
                    
                // In this case, as we want to display all the properties of the enchantments, we will not use the .Take() method
                }).ToList();
                // }).Skip(head).Take(_reg_by_page).ToList();
            }

            // This will allow the cells to be auto adjusted by typing an enter key in the cell each time the text dont fit
            dataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            // This will allow the cells to be auto adjusted to the size of the content, in the vertical direction
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            // Also, as we are displaying all the properties of the enchantments, we will hide the id and eName columns
            //dataGridView.Columns[0].Visible = false;
            //dataGridView.Columns[1].Visible = false;
            //// This will make the DataGridView to fit the content of the cells
            //dataGridView.Columns[2].Width = 215;
        }
        public void RemoveEnchantment(DataGridView dataGridView, TextBox searchBar, DataGridView dataGridViewL, DataGridView dataGridViewR)
        {
            // We will create a variable that will contain the id of the enchantment that we want to remove
            int ID = Convert.ToInt16(dataGridView.CurrentRow.Cells[0].Value);
            // We will use the enchantmentsSB interface from the Connection class
            // We will use the .Where() method to select the enchantment that we want to remove
            // The .Where() method will contain a lambda expression that will contain the indexer of the id column
            enchantmentsSB.Where(c => c.id == ID).Delete();
            // After the enchantment is removed, we will refresh the DataGridView
            DisplayPropertiesRight(searchBar, dataGridViewR);
            DisplayPropertiesLeft(searchBar, dataGridViewL);
        }
        public void UpdateEnchantment(List<TextBox> ListOfProperties, string id, TextBox searchBar, DataGridView dataGridViewL, DataGridView dataGridViewR)
        {
            // We will use id variable to select the enchantment that we want to update
            int ID = Convert.ToInt16(id);
            // We will use the enchantmentsSB interface from the Connection class
            enchantmentsSB.Where(c => c.id == ID)
                          .Set(c => c.eName, ListOfProperties[0].Text)
                          .Set(c => c.eDescription, ListOfProperties[1].Text)
                          .Set(c => c.ePower, ListOfProperties[2].Text)
                          .Set(c => c.eTreasure, ListOfProperties[3].Text)
                          .Update();
            DisplayPropertiesRight(searchBar, dataGridViewR);
            DisplayPropertiesLeft(searchBar, dataGridViewL);
        }
    }
}
