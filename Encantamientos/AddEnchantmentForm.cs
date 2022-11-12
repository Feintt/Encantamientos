using Data;
using Logic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LinqToDB;

namespace Encantamientos
{
    public partial class AddEnchantmentForm : Form
    {
        private Enchantments enchantments = new Enchantments();
        public AddEnchantmentForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (textBoxEnchantmentName.Text.Equals(""))
            {
                enchantments.enchantmentProperties.has_name = false;
            }
            else
            {
                enchantments.enchantmentProperties.has_name = true;
            }
            // We call the method that checks if the enchantment has all the properties
            enchantments.buttonUnlocks.buttonUnlocks(enchantments.enchantmentProperties, buttonAdd);
        }

        private void textBoxEnchantmentDescription_TextChanged(object sender, EventArgs e)
        {
            if (textBoxEnchantmentDescription.Text.Equals(""))
            {
                enchantments.enchantmentProperties.has_description = false;
            }
            else
            {
                enchantments.enchantmentProperties.has_description = true;
            }
            // We call the method that checks if the enchantment has all the properties
            enchantments.buttonUnlocks.buttonUnlocks(enchantments.enchantmentProperties, buttonAdd);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (textBoxTreasure.Text.Equals(""))
            {
                enchantments.enchantmentProperties.has_treasure = false;
            }
            else
            {
                enchantments.enchantmentProperties.has_treasure = true;
            }
            // We call the method that checks if the enchantment has all the properties
            enchantments.buttonUnlocks.buttonUnlocks(enchantments.enchantmentProperties, buttonAdd);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // We create a list of the properties of the enchantment
            List<TextBox> ListOfProperties = new List<TextBox>();
            ListOfProperties.Add(textBoxEnchantmentName);
            ListOfProperties.Add(textBoxEnchantmentDescription);
            ListOfProperties.Add(textBoxPower);
            ListOfProperties.Add(textBoxTreasure);

            Connection db = new Connection();
            db.Insert(new EnchantmentsDB()
            {
                eName = ListOfProperties[0].Text,
                eDescription = ListOfProperties[1].Text,
                ePower = ListOfProperties[2].Text,
                eTreasure = ListOfProperties[3].Text
            });
            this.Close();
        }
        private void textBoxPower_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPower.Text.Equals(""))
            {
                enchantments.enchantmentProperties.has_power = false;
            }
            else
            {
                enchantments.enchantmentProperties.has_power = true;
            }
            // We call the method that checks if the enchantment has all the properties
            enchantments.buttonUnlocks.buttonUnlocks(enchantments.enchantmentProperties, buttonAdd);
        }

        private void textBoxPower_KeyPress(object sender, KeyPressEventArgs e)
        {
            // We validate if the user is typing a number
            enchantments.validateNumber.KeyPressedIsNumber(e);
        }

        private void textBoxTreasure_KeyPress(object sender, KeyPressEventArgs e)
        {
            enchantments.validateLetter.KeyPressedIsLetter(e);
        }
    }
}
