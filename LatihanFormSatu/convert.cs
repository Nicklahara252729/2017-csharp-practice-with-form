using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatihanFormSatu
{
    public partial class convert : Form
    {
        public convert()
        {
            InitializeComponent();
        }

        private void btnconvert_Click(object sender, EventArgs e)
        {
            if (txtwarna.Text == "merah")
            {
                btnhasil.BackColor = Color.Red;
            }
            else if (txtwarna.Text == "biru")
            {
                btnhasil.BackColor = Color.Blue;
            }
            else if (txtwarna.Text == "hijau")
            {
                btnhasil.BackColor = Color.Green;
            }
            else
            {
                MessageBox.Show("Warna Tidak Tersedia", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
