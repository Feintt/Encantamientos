using Logic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Encantamientos
{
	public partial class MainForm : Form
	{
		private Enchantments enchants = new Enchantments();
		public MainForm()
		{
			InitializeComponent();
            // When this form is loaded, we want to populate the listbox with the enchantments, also filtrate by the selected item in the Search Bar
            enchants.dBlogic.DisplayPropertiesLeft(textBoxSearch, dataGridView1);
			enchants.dBlogic.DisplayPropertiesRight(textBoxSearch, dataGridView2);

            // We print the current directory
            Console.WriteLine(Environment.CurrentDirectory);

            List<TextBox> textBoxes = new List<TextBox>();
            TextBox textBox1 = new TextBox();
			textBox1.Text = "a";

            TextBox textBox2 = new TextBox();
            textBox2.Text = "b";

            TextBox textBox3 = new TextBox();
            textBox3.Text = "c";

            TextBox textBox4 = new TextBox();
            textBox4.Text = "d";

            textBoxes.Add(textBox1);
            textBoxes.Add(textBox2);
            textBoxes.Add(textBox3);
            textBoxes.Add(textBox4);

            enchants.dBlogic.AddEnchantment(textBoxes, textBoxSearch, dataGridView1, dataGridView2);
            //dataGridView2.Columns[0].Visible = false;
            //dataGridView2.Columns[1].Visible = false;
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
		{
            // When the text in the Search Bar changes, we want to populate the listbox with the enchantments, also filtrate by the selected item in the Search Bar
            enchants.dBlogic.DisplayPropertiesLeft(textBoxSearch, dataGridView1);
            enchants.dBlogic.DisplayPropertiesLeft(textBoxSearch, dataGridView1);
			enchants.dBlogic.DisplayPropertiesRight(textBoxSearch, dataGridView2);
		}

		private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
		{
            // When the user presses a key in the Search Bar, we want to populate the listbox with the enchantments, also filtrate by the selected item in the Search Bar
            // We will call the method KeyPressedIsLetter
            // It will return true if the key pressed is not a letter
            // It will return false if the key pressed is a letter
            // So if the KeyPressedIsLetter returns true, we will notify the user that he can only search by letters
            if (enchants.validateLetter.KeyPressedIsLetter(e))
			{
				labelNotifications.Text = "No se permiten numeros o caracteres especiales";
			}
			else
			{
				labelNotifications.Text = "";
			}
		}

		private void buttonAddEnchantment_Click(object sender, EventArgs e)
		{
            // When the user clicks the Add Enchantment button, we want to open the AddEnchantment form
            // Where the user can add a new enchantment
            // By typing the name of the enchantment and the properties

            // We create a new instance of the AddEnchantment form
            AddEnchantmentForm addEnchantmentForm = new AddEnchantmentForm(dataGridView1, dataGridView2, textBoxSearch);

            // Then we show the AddEnchantment form
            addEnchantmentForm.Show();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{

            // When the user clicks a cell in the dataGridView1 (the one on the left) we want to focus the same row in the dataGridView2 (the one on the right)
            // So we will get the row index of the selected cell in the dataGridView1 and dataGridView2
            int row = dataGridView1.CurrentCell.RowIndex;
			dataGridView2.CurrentCell = dataGridView2.Rows[row].Cells[2];
		}

		private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
		{
            // When the user clicks a cell in the dataGridView2 (the one on the right) we want to focus the same row in the dataGridView1 (the one on the left)
            // So we will get the row index of the selected cell in the dataGridView1 and dataGridView2
			int row = dataGridView2.CurrentCell.RowIndex;
			dataGridView1.CurrentCell = dataGridView1.Rows[row].Cells[0];
		}

		private void buttonRemove_Click(object sender, EventArgs e)
		{
            // When the user clicks the Remove button, we want to remove the selected enchantment
            // We will call the method RemoveEnchantment
            // Then we will call the method SearchEnchantment to update the dataGridView1
            // So we can instantly see the enchantment removed
            enchants.dBlogic.RemoveEnchantment(dataGridView2, textBoxSearch, dataGridView1, dataGridView2);
			enchants.dBlogic.DisplayPropertiesLeft(textBoxSearch, dataGridView1);
		}

		private void buttonEdit_Click(object sender, EventArgs e)
		{
            // When the user clicks the Edit button, we want to open the EditEnchantment form

            // Before opening the EditEnchantment form, we will get all the properties of the selected enchantment
            // We will do this by creating a new list of strings
            // We will Add the values as shown below
            List<string> properties = new List<string>
			{
				dataGridView2.CurrentRow.Cells[1].Value.ToString(),
				dataGridView2.CurrentRow.Cells[2].Value.ToString(),
				dataGridView2.CurrentRow.Cells[3].Value.ToString(),
				dataGridView2.CurrentRow.Cells[4].Value.ToString(),
				dataGridView2.CurrentRow.Cells[0].Value.ToString()
			};

            // The we will create a new instance of the EditEnchantmentForm, also we will pass the properties list as a parameter
            EditEnchantmentForm editEnchantmentForm = new EditEnchantmentForm(properties, dataGridView1, dataGridView2, textBoxSearch);

            // Then we will show the EditEnchantment form
            editEnchantmentForm.Show();
		}
	}
}
