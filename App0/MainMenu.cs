using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace App0
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictform1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void pictform2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void pictform3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void pictform4_Click(object sender, EventArgs e)
        {

            DialogResult dialoresult = MessageBox.Show(" Apakah Anda Ingin Keluar ", " APP 0", MessageBoxButtons.YesNo);
            if (dialoresult == DialogResult.Yes) Application.Exit();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            string apppath = Application.StartupPath;
            string imagepath = @"\Sounds\";
            string _soundname = "welcome";
            SoundPlayer simpleSound = new SoundPlayer(apppath + imagepath + _soundname + ".wav");
            simpleSound.Play();
        }
    }
}
