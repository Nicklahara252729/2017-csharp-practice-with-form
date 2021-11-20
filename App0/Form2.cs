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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            string format = "HH:mm:ss";
            lbltime.Text = (time.ToString(format));
        }

        private void lblmarquee_Click(object sender, EventArgs e)
        {

        }

        private int xPos = 0,      yPos = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (xPos <= 0)
            {
                this.lblmarquee.Location = new System.Drawing.Point(this.Width, yPos);
                xPos = this.Width;
            }
            else
            {
                this.lblmarquee.Location = new System.Drawing.Point(xPos, yPos);
                xPos -= 1;
            }
        }

        private void lbltime_Click(object sender, EventArgs e)
        {

        }

        
        private void stop_Click(object sender, EventArgs e)
        {
             
            if (stop.Text == "STOP" )
            {
                timer1.Stop();
                timer2.Stop();
                stop.Text = "START";
            }
            else if (stop.Text == "START")
            {
                timer1.Start();
                timer2.Start();
                stop.Text = "STOP";
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
