﻿using Logic;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Encantamientos
{
    public partial class MainForm : Form
    {
        private Enchantments enchants = new Enchantments();
        public MainForm()
        {
            InitializeComponent();
            enchants.dBlogic.SearchEnchantment(textBoxSearch, dataGridView1);
            enchants.dBlogic.DisplayProperties(textBoxSearch, dataGridView2);

        }

        private void pictureBoxProperties_Click(object sender, EventArgs e)
        {
            enchants.uploadImage.LoadImage(pictureBoxProperties);
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            enchants.dBlogic.SearchEnchantment(textBoxSearch, dataGridView1);
            enchants.dBlogic.DisplayProperties(textBoxSearch, dataGridView2);
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

        private void labelError_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView1.CurrentCell.RowIndex;
            dataGridView2.CurrentCell = dataGridView2.Rows[row].Cells[2];
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView2.CurrentCell.RowIndex;
            dataGridView1.CurrentCell = dataGridView1.Rows[row].Cells[0];
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            enchants.dBlogic.RemoveEnchantment(dataGridView2, textBoxSearch);
            enchants.dBlogic.SearchEnchantment(textBoxSearch, dataGridView1);
        }
    }
}
