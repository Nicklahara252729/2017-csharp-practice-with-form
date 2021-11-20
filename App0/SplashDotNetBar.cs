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
    public partial class SplashDotNetBar : Form
    {
        public SplashDotNetBar()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cirPog.Value != 100)
            {
                cirPog.Value++;
                if (cirPog.Value == 10)
                {
                    lblnotif.Text = " Checking Components..";
                }
                else if (cirPog.Value == 20)
                {
                    lblnotif.Text = " Please Wait.. ";
                }
                else if (cirPog.Value == 40)
                {
                    lblnotif.Text = " Almost Done.. ";
                }
                else if (cirPog.Value == 60)
                {
                    lblnotif.Text = " Finally..";
                }
                else if (cirPog.Value == 80)
                {
                    lblnotif.Text = " Oh Yeah... :v";
                    if (lblnotif.Text==" Oh Yeah... :v")
                    {
                        cirPog.ProgressColor = Color.Black;
                    }
                }
                else if (cirPog.Value == 100)
                {

                    this.Hide();
                    SplashScreen Mm = new SplashScreen();
                    Mm.ShowDialog();
                }
            }
            else
            {
                timer1.Stop();
            }
        }

        private void SplashDotNetBar_Load(object sender, EventArgs e)
        {
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        private void cirPog_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblnotif_Click(object sender, EventArgs e)
        {

        }
    }
}
