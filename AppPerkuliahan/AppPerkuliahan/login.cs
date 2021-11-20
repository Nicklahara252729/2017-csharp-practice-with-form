using DevComponents.DotNetBar.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPerkuliahan
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void picadmin_Click(object sender, EventArgs e)
        {
            sputama.IsOpen = false;
            ChangeSlideSide (eSlideSide.Left);
            spadmin.IsOpen = true;
            spadmin.Visible = true;
            spclient.Visible = false;
        }

        private void slidePanel1_Load(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {
            sputama.BackColor = Color.White;
            spadmin.BackColor = Color.Firebrick;
            spclient.BackColor = Color.Khaki;

            sputama.IsOpen = true;
            spclient.IsOpen = false;
            spadmin.IsOpen = false;
        }
        public void ChangeSlideSide(eSlideSide side)
        {
            sputama.SlideSide = side;
        }

        private void sputama_Load(object sender, EventArgs e)
        {

        }

        private void picclient_Click(object sender, EventArgs e)
        {
            sputama.IsOpen = false;
            ChangeSlideSide  (eSlideSide.Left);
            spclient.IsOpen = true;
            spclient.Visible = true;
            spadmin.Visible = false;
        }

        private void pctbck_Click(object sender, EventArgs e)
        {
            sputama.IsOpen = true;
            spadmin.IsOpen = false;
            ChangeSlideSide(eSlideSide.Right);
            spclient.Visible = false;
            spadmin.Visible = false;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtid.Text != "" && txtpass.Text != "")
            {
                try
                {
                    string hasil = "";
                    using (OracleConnection conn = new OracleConnection("User ID=dbkampus" + ";Pasword=123" + ";Data Source = 'XE'" + "';"))
                    using (OracleCommand cmd = new OracleCommand("SELECT * from TBLUSER where ID='" + txtid.Text + "'", conn))
                    {
                        conn.Open();
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                hasil = reader["PASSWORD"].ToString();
                                if (txtpass.Text == hasil)
                                {
                                    Form1 admin = new Form1();
                                    admin.Show();
                                    this.Hide();
                                }
                            }

                            if (hasil == "")
                            {
                                MessageBox.Show("ID/Pasword Salah !!, Periksa Kembali");
                                txtid.Clear();
                                txtpass.Clear();
                                this.ActiveControl = txtid;

                            }
                        }
                    }


                }
                catch
                {

                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            sputama.IsOpen = true;
            spadmin.IsOpen = false;
            ChangeSlideSide(eSlideSide.Right);
            spclient.Visible = false;
            spadmin.Visible = false;
        }
    }
}
