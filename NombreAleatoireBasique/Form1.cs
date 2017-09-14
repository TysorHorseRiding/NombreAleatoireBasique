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

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int result))
            {
                if (int.TryParse(textBox2.Text, out int result2))
                {
                    if(result2 <= result)
                    {                    
                        MessageBox.Show("Le nombre minimum doit être inférieur au nombre maximum.");
                        return;
                    }
                    label3.Text = nombrealeatoire.Next(result, result2).ToString();
                }
            }
        }
    }
}
