using Logic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Encantamientos
{
    public partial class EditEnchantmentForm : Form
    {
        // We create a string variable to store the id of the enchantment
        // So we can use it later to update the enchantment
        private readonly string ID;

        // We create a new instance of the Enchantments class
        private Enchantments enchants = new Enchantments();
        DataGridView dataGridView1 = new DataGridView();
        DataGridView dataGridView2 = new DataGridView();
        TextBox searchBar = new TextBox();
        public EditEnchantmentForm(List<string> e, DataGridView dataGridViewL, DataGridView dataGridViewR, TextBox searchBar)
        {
            InitializeComponent();
            // As we are going to pass the enchantment data to this form, we will show all the data selected in the form
            // So the user can just edit it instead of writting it again
            textBoxEnchantmentName.Text = e[0];
            textBoxEnchantmentDescription.Text = e[1];
            textBoxPower.Text = e[2];
            textBoxTreasure.Text = e[3];

            // We store the id of the enchantment in the ID variable
            // So we can update the enchantment  by filtering the unique id from the database
            ID = e[4];

            dataGridView1 = dataGridViewL;
            dataGridView2 = dataGridViewR;
            this.searchBar = searchBar;
        }
        private void buttoEdit_Click(object sender, EventArgs e)
        {
            // When the user clicks the Edit button, we want to update the enchantment with the properties the user has typed
            // We will create a new List of TextBoxes to store the properties in order
            List<TextBox> ListOfProperties = new List<TextBox>
            {
                textBoxEnchantmentName,
                textBoxEnchantmentDescription,
                textBoxPower,
                textBoxTreasure
            };

            // Then we will call the UpdateEnchantment method from the Enchantments class
            // We will pass the ListOfProperties and the ID variable
            enchants.dBlogic.UpdateEnchantment(ListOfProperties, ID, searchBar, dataGridView1, dataGridView2);

            // After the enchantment has been updated, we will close the form
            this.Close();
        }
    }
}
