using Data;
using LinqToDB;
using System.Collections.Generic;
using System.Windows.Forms;
using System;
using System.Linq;
using LinqToDB.Linq;
using System.Collections;

namespace Logic.Library.Calls
{
	public class DBlogic : Connection
	{
		public void AddEnchantment(List<TextBox> ListOfProperties)
		{
			//Connection db = new Connection();
			//db.Insert(new EnchantmentsDB()
			//{
			//    eName = ListOfProperties[0].Text,
			//    eDescription = ListOfProperties[1].Text,
			//    ePower = ListOfProperties[2].Text,
			//    eTreasure = ListOfProperties[3].Text
			//});
			BeginTransactionAsync();
			try
			{
				enchantmentsSB.Value(e => e.eName, ListOfProperties[0].Text)
							  .Value(e => e.eDescription, ListOfProperties[1].Text)
							  .Value(e => e.ePower, ListOfProperties[2].Text)
							  .Value(e => e.eTreasure, ListOfProperties[3].Text)
							  .Insert();
				CommitTransaction();
			}
			catch (Exception)
			{
				RollbackTransaction();
			}
		}
		public bool EnchantmentExists(List<TextBox> listOfProperties)
		{
			var name = enchantmentsSB.Where(u => u.eName.Equals(listOfProperties[0].Text)).ToList();
			if (name.Count.Equals(0))
			{
				return false;
			}
			else
			{
				return true;
			}
		}

		private int _reg_by_page = 1000, _num_of_pages = 1;
		public void SearchStudent(TextBox searchBar, DataGridView dataGridView)
		{
			int head = (_num_of_pages - 1) * _reg_by_page;
			List<EnchantmentsDB> query = new List<EnchantmentsDB>();
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
					c.eName
				}).Skip(head).Take(_reg_by_page).ToList();
			}
		}
		public void DisplayProperties(List<TextBox> listOfProperties, DataGridView dataGridView, Label label)
		{
			List<string> values = new List<string>();
            
            for (int i = 0; i < listOfProperties.Count; i++)
            {
				values[i] = listOfProperties[i].Text;
            }
            List<EnchantmentsDB> names = new List<EnchantmentsDB>();
            List<EnchantmentsDB> descriptions = new List<EnchantmentsDB>();
            List<EnchantmentsDB> powers = new List<EnchantmentsDB>();
            List<EnchantmentsDB> treasures = new List<EnchantmentsDB>();
            names = enchantmentsSB.Where(c => c.eName.Equals(listOfProperties[0].Text)).ToList();
            descriptions = enchantmentsSB.Where(c => c.eDescription.Equals(listOfProperties[1].Text)).ToList();
            powers = enchantmentsSB.Where(c => c.ePower.Equals(listOfProperties[2].Text)).ToList();
            treasures = enchantmentsSB.Where(c => c.eTreasure.Equals(listOfProperties[3].Text)).ToList();
            
            int rowindex = dataGridView.CurrentCell.RowIndex;
            int columnindex = dataGridView.CurrentCell.ColumnIndex;
            string name = dataGridView.Rows[rowindex].Cells[columnindex].Value.ToString();

            int ID = values.IndexOf(name);
            label.Text = ID.ToString();
        }
	}
}
