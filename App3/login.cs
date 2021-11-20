using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App3
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

            int failed = 0;
            if (username.Text == "kenpachi" && password.Text == "098")
            {
                MessageBox.Show("Login Berhasil", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 logged = new Form1();
                logged.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Gagal", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                failed += 1;
                if (failed == 3)
                {
                    Process.Start("shutdown.exe", "/s /f /t 00");
                }
            }
        }
    }
}
