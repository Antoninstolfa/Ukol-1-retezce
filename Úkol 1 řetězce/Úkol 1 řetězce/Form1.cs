using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Úkol_1_řetězce
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        string samohlasky = "aeiouyáéěíóúůý";
        string souhlasky = "bcčdďfghjklmnpqrřsštťvwxzž";
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int pocitadloSamohlasky = 0, pocitadloSouhlasky = 0, pocitadloNepismen = 0;
                string retezec = textBox1.Text;
                textBox1.Text.ToLower();
                foreach (char znak in retezec)
                {
                    if (samohlasky.Contains(znak))
                    {
                        pocitadloSamohlasky++;
                    }
                    if (souhlasky.Contains(znak))
                    {
                        pocitadloSouhlasky++;
                    }
                    else
                    {
                        pocitadloNepismen++;
                    }
                }
                VysledekSamohlasek.Text = Convert.ToString(pocitadloSamohlasky);
                VysledekSouhlasek.Text = Convert.ToString(pocitadloSouhlasky);
                VysledekNepismen.Text = Convert.ToString(pocitadloNepismen);
            }
            catch
            {
                MessageBox.Show("Zadejte nejaký text.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.LawnGreen;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Black;
        }
    }
}
