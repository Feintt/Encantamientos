using Data;
using LinqToDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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
		public void SearchEnchantment(TextBox searchBar, DataGridView dataGridView)
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
					c.id,
					c.eName,
					c.eDescription,
					c.ePower,
					c.eTreasure
				}).Skip(head).Take(_reg_by_page).ToList();
			}
			dataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
			dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			dataGridView.Columns[0].Visible = false;
			dataGridView.Columns[1].Visible = false;
			dataGridView.Columns[2].Width = 215;
		}

		public void RemoveEnchantment(DataGridView dataGridView, TextBox searchBar)
		{
			int ID = Convert.ToInt16(dataGridView.CurrentRow.Cells[0].Value);
			enchantmentsSB.Where(c => c.id == ID).Delete();
			DisplayProperties(searchBar, dataGridView);
		}

		public void UpdateEnchantment(List<TextBox> ListOfProperties, string id)
		{
            int ID = Convert.ToInt16(id);
            enchantmentsSB.Where(c => c.id == ID)
						  .Set(c => c.eName, ListOfProperties[0].Text)
						  .Set(c => c.eDescription, ListOfProperties[1].Text)
						  .Set(c => c.ePower, ListOfProperties[2].Text)
						  .Set(c => c.eTreasure, ListOfProperties[3].Text)
						  .Update();
		}
	}
}
