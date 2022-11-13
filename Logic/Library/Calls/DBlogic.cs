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
        
		public void DisplayProperties(TextBox searchBar, DataGridView dataGridView)
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
                    c.eName,
                    c.eDescription,
                    c.ePower,
                    c.eTreasure
                }).Skip(head).Take(_reg_by_page).ToList();
            }
        }
	}
}
