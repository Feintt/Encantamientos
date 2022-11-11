using Logic;
using Logic.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encantamientos
{
    public partial class MainForm : Form
    {
        private Enchantments enchants = new Enchantments();
        public MainForm()
        {
            InitializeComponent();
        }
        
        private void pictureBoxProperties_Click(object sender, EventArgs e)
        {
            enchants.uploadImage.LoadImage(pictureBoxProperties);
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearch.Text.Equals(""))
            {
                buttonSearch.Enabled = false;
            }
            else
            {
                buttonSearch.Enabled = true;
            }
        }

        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (enchants.validateLetter.KeyPressedIsLetter(e))
            {
                labelNotifications.Text = "No se permiten numeros o caracteres especiales";
            }
            else
            {
                labelNotifications.Text = "";
            }
        }

        private void textBoxLevel_TextChanged(object sender, EventArgs e)
        {
            if (textBoxLevel.Text.Equals(""))
            {
                labelLevel.ForeColor = Color.Black;
            }
            else
            {
                labelLevel.ForeColor = Color.Green;
            }
        }

        private void textBoxLevel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (enchants.validateNumber.KeyPressedIsNumber(e))
            {
                labelNotifications.Text = "No se permiten letras o simbolos en este espacio";
            }
            else
            {
                labelNotifications.Text = "";
            }
        }

        private void buttonAddEnchantment_Click(object sender, EventArgs e)
        {
            AddEnchantmentForm addEnchantmentForm = new AddEnchantmentForm();
            addEnchantmentForm.Show();

        }

        private void pictureBoxEnchantment_Click(object sender, EventArgs e)
        {

        }
    }
}
