using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void label4_SizeChanged(object sender, EventArgs e)
        {
            this.label4.Left = (this.ClientSize.Width - label4.Size.Width) / 2;
        }
    }
}
