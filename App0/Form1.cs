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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Turquoise;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.WhiteSmoke;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (panel1.BackColor == Color.Goldenrod)
                panel1.BackColor = Color.White;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (panel1.BackColor == Color.White)
                panel1.BackColor = Color.Goldenrod;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            label1.Text = textBox1.Text;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu Mm = new MainMenu();
            Mm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
