using Logic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Encantamientos
{
    public partial class EditEnchantmentForm : Form
    {
        string ID;
        private Enchantments enchants = new Enchantments();

        public EditEnchantmentForm(List<string> e)
        {
            InitializeComponent();
            this.ControlBox = false;
            textBoxEnchantmentName.Text = e[0];
            textBoxEnchantmentDescription.Text = e[1];
            textBoxPower.Text = e[2];
            textBoxTreasure.Text = e[3];
            ID = e[4];
        }

        private void buttoEdit_Click(object sender, EventArgs e)
        {
            List<TextBox> ListOfProperties = new List<TextBox>
            {
                textBoxEnchantmentName,
                textBoxEnchantmentDescription,
                textBoxPower,
                textBoxTreasure
            };
            enchants.dBlogic.UpdateEnchantment(ListOfProperties, ID);
            this.Close();
        }
    }
}
