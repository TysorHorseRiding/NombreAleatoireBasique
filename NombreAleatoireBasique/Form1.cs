using System;
using System.Windows.Forms;

namespace NombreAleatoireBasique
{
    public partial class Form1 : Form
    {
        Random nombrealeatoire = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private bool checkifempty()
        {
            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrWhiteSpace(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrWhiteSpace(textBox2.Text))
                return true;
            else
                return false;
        }

        private void result()
        {
            if (int.TryParse(textBox1.Text, out int result))
            {
                if (int.TryParse(textBox2.Text, out int result2))
                {
                    if (result2 <= result)
                    {
                        label4.Visible = true;
                        return;
                    }
                    else
                    {
                        label4.Visible = false;
                    }
                    label3.Text = nombrealeatoire.Next(result, result2).ToString();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            result();
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            result();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (checkifempty() == true)
                MessageBox.Show("Veuilez remplir correctement tous les champs");
            else
                result();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
