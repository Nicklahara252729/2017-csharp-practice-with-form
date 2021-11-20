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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ProgBar.Value != 100)
            {
                ProgBar.Value++;
                if(ProgBar.Value == 10){
                    lblnotif.Text = " Memeriksa Koneksi..";
                }else if(ProgBar.Value == 20){
                    lblnotif.Text = " Sabar broo.. ";
                }else if(ProgBar.Value == 40){
                    lblnotif.Text = " Sikit lagi nih.. ";
                }else if(ProgBar.Value == 60){
                    lblnotif.Text = " Udah mau nyampe.. ";
                }else if(ProgBar.Value == 100){
                    
                    this.Hide();
                    MainMenu Mm = new MainMenu();
                    Mm.ShowDialog();
                }
            }
            else
            {
                timer1.Stop();
            }
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            timer1.Tick += new EventHandler(timer1_Tick);
        }
    }
}
