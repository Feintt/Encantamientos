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
    public partial class Form1 : Form
    {
        private Enchantments enchants = new Enchantments();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBoxProperties_Click(object sender, EventArgs e)
        {
            enchants.uploadImage.LoadImage(pictureBoxProperties);
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearch.Text.Equals(""))
            {
                buttonSearch.ForeColor = Color.Black;
                buttonSearch.FlatStyle = FlatStyle.Flat;
                labelNotifications.Text = "No se ha ingresado ningun texto";
            }
            else
            {
                buttonSearch.ForeColor = Color.Green;
                buttonSearch.FlatStyle = FlatStyle.Popup;
                labelNotifications.Text = "";
            }
        }

        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (enchants.textBoxEvents.KeyPressed(e))
            {
                labelNotifications.Text = "No se permiten numeros o caracteres especiales";
            }
            else
            {
                labelNotifications.Text = "";
            }
        }
    }
}
