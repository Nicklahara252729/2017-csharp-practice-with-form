using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatihanGrade
{
    public partial class proses : Form
    {
        public proses()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pros.Value != 100)
            {
                pros.Value++;
                if (pros.Value == 60)
                {
                    lblproses.Text = " Please Wait..";
                }
             
                else if (pros.Value == 100)
                {
                    this.Hide();
                    Form1 Mm = new Form1();
                    Mm.ShowDialog();
                }
            }
            else
            {
                timer1.Stop();
            }
        }

        private void proses_Load(object sender, EventArgs e)
        {
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        private void pros_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
