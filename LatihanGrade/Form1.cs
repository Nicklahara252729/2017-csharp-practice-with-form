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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncount_Click(object sender, EventArgs e)
        {
            /*this.Hide();
            proses Mm = new proses();
            Mm.ShowDialog();*/

           
             double total, htugas, hpresensi, huts, huas;
            if (txttugas.Text == "" || txtpresensi.Text == ""  || txtuts.Text == "" || txtuas.Text == "" )
            {
                MessageBox.Show("Inputan Kurang Lengkap", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Convert.ToInt16(txttugas.Text) > 100 || Convert.ToInt16(txtpresensi.Text) > 100 || Convert.ToInt16(txtuts.Text) > 100 || Convert.ToInt16(txtuas.Text) > 100)
            {
                MessageBox.Show("Inputan Maximal 100", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                panel2.Visible = true;
                htugas = Convert.ToInt16(txttugas.Text) * 0.2;
                hpresensi = Convert.ToInt16(txtpresensi.Text) * 0.1;
                huts = Convert.ToInt16(txtuts.Text) * 0.3;
                huas = Convert.ToInt16(txtuas.Text) * 0.4;
                total = htugas + hpresensi + huts + huas;
                if (total >= 81 && total <= 100)
                {
                    txttotal.Text = Convert.ToString(total);
                    grade.Text = "A";
                    ket.Text = " Anda Lulus";
                }
                else if (total >= 71 && total <= 80)
                {
                    txttotal.Text = Convert.ToString(total);
                    grade.Text = "B";
                    ket.Text = "  Anda Lulus";
                }
                else if (total >= 61 && total <= 70)
                {
                    txttotal.Text = Convert.ToString(total);
                    grade.Text = "C";
                    ket.Text = " Anda Lulus";
                }
                else if (total >= 51 && total <= 60)
                {
                    txttotal.Text = Convert.ToString(total);
                    grade.Text = "D";
                    ket.Text = " Anda Tidak Lulus";
                }
                else if (total <= 50)
                {
                    txttotal.Text = Convert.ToString(total);
                    grade.Text = "E";
                    ket.Text = " Anda Tidak Lulus";
                }
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txttotal.Text = "";
            txtpresensi.Text = "";
            txttugas.Text = "";
            txtuas.Text = "";
            txtuts.Text = "";
            grade.Text = "GRADE";
            ket.Text = "KETERANGAN";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (putar.Value != 100)
            {
                putar.Value++;
                panel2.Visible = false;
            }
            else
            {
                //panel2.Visible = true;
                timer1.Stop();
            }
        }
    }
}
