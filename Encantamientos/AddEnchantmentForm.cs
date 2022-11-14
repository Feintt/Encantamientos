using Logic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Encantamientos
{
    public partial class AddEnchantmentForm : Form
    {
        // We create a new instance of the Enchantments class
        private Enchantments enchantments = new Enchantments();
        DataGridView dataGridView1 = new DataGridView();
        DataGridView dataGridView2 = new DataGridView();
        TextBox searchBar = new TextBox();
        public AddEnchantmentForm(DataGridView dataGridViewL, DataGridView dataGridViewR, TextBox searchBar)
        {
            InitializeComponent();
            dataGridView1 = dataGridViewL;
            dataGridView2 = dataGridViewR;
            this.searchBar = searchBar;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Every time the user types something in the textBox1, we want to check if the text is a letter
            // If it is a letter, we will set the has_name variable to true
            if (textBoxEnchantmentName.Text.Equals(""))
            {
                enchantments.enchantmentProperties.has_name = false;
            }
            else
            {
                enchantments.enchantmentProperties.has_name = true;
            }
            // We call the method that checks if the enchantment has all the properties
            // In order to use the button to add the enchantment, the enchantment must have all the properties
            enchantments.buttonUnlocks.buttonUnlocks(enchantments.enchantmentProperties, buttonAdd);
        }

        private void textBoxEnchantmentDescription_TextChanged(object sender, EventArgs e)
        {
            // Every time the user types something in the textBox1, we want to check if the text is a letter
            // If it is a letter, we will set the has_name variable to true
            if (textBoxEnchantmentDescription.Text.Equals(""))
            {
                enchantments.enchantmentProperties.has_description = false;
            }
            else
            {
                enchantments.enchantmentProperties.has_description = true;
            }
            // We call the method that checks if the enchantment has all the properties
            // In order to use the button to add the enchantment, the enchantment must have all the properties
            enchantments.buttonUnlocks.buttonUnlocks(enchantments.enchantmentProperties, buttonAdd);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            // Every time the user types something in the textBox1, we want to check if the text is a letter
            // If it is a letter, we will set the has_name variable to true
            if (textBoxTreasure.Text.Equals(""))
            {
                enchantments.enchantmentProperties.has_treasure = false;
            }
            else
            {
                enchantments.enchantmentProperties.has_treasure = true;
            }
            // We call the method that checks if the enchantment has all the properties
            // In order to use the button to add the enchantment, the enchantment must have all the properties
            enchantments.buttonUnlocks.buttonUnlocks(enchantments.enchantmentProperties, buttonAdd);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // When the user clicks the Add button, we want to add the enchantment with the properties the user has typed

            // We create a list of the properties of the enchantment
            List<TextBox> ListOfProperties = new List<TextBox>();
            ListOfProperties.Add(textBoxEnchantmentName);
            ListOfProperties.Add(textBoxEnchantmentDescription);
            ListOfProperties.Add(textBoxEnchantmentPower);
            ListOfProperties.Add(textBoxTreasure);

            // Before adding the enchantment, we want to check if the enchantment already exists in the database
            // If it does, we will show a message to the user
            if (enchantments.dBlogic.EnchantmentExists(ListOfProperties))
            {
                labelError.Text = "This enchantment already exists";
            }
            
            // If the enchantment does not exists
            // We will add the enchantment to the database
            else
            {
                // We call the AddEnchantment method from the Enchantments class
                enchantments.dBlogic.AddEnchantment(ListOfProperties, searchBar, dataGridView1, dataGridView2);

                // Then we close the form
                this.Close();
            }

        }
        private void textBoxPower_TextChanged(object sender, EventArgs e)
        {
            // We call the method that checks if the enchantment has all the properties
            // In order to use the button to add the enchantment, the enchantment must have all the properties
            if (textBoxEnchantmentPower.Text.Equals(""))
            {
                enchantments.enchantmentProperties.has_power = false;
            }
            else
            {
                enchantments.enchantmentProperties.has_power = true;
            }
            // We call the method that checks if the enchantment has all the properties
            // In order to use the button to add the enchantment, the enchantment must have all the properties
            enchantments.buttonUnlocks.buttonUnlocks(enchantments.enchantmentProperties, buttonAdd);
        }

        private void textBoxPower_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Every time the user types something in the textBoxower, we want to check if the text is a number
            // If it is a letter, we will handle the event

            // We validate if the user is typing a number
            enchantments.validateNumber.KeyPressedIsNumber(e);
        }

        private void textBoxTreasure_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Every time the user types something in the textBoxower, we want to check if the text is a letter
            // If it is a number, we will handle the event

            // We validate if the user is typing a letter
            enchantments.validateLetter.KeyPressedIsLetter(e);
        }

        private void textBoxEnchantmentName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Id the KeyPressed is not handled, we clean the labelError
            labelError.Text = "";
        }

        private void textBoxEnchantmentDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            // If the user press the space bar, we append 2 more sapce bars, so it will look better
            if (e.KeyChar == Convert.ToChar(Keys.Space))
            {
                textBoxEnchantmentDescription.AppendText("  ");
            }
        }
    }
}
