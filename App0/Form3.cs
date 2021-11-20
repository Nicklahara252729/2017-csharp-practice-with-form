using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App0
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private string a;
        private int ha;
        private void cek_Click(object sender, EventArgs e)
        {
            a = txt1.Text;
            ha = Convert.ToInt32(a);
            if (ha %2 != 0)
            {
                txt2.Text = ha +" Ganjil";
            }
            else
            {
                txt2.Text = ha + " Genap";
            }
        }

        private string b;
        private int hb;
        private void txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (txt1.Text != "")
            {
                b = txt1.Text;
                hb = Convert.ToInt32(b);
                if (hb % 2 != 0)
                {
                    txt2.Text = hb + " Ganjil";
                }
                else
                {
                    txt2.Text = hb + " Genap";
                }
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu Mm = new MainMenu();
            Mm.ShowDialog();
        }
    }
}
