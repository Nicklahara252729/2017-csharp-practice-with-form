using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbdokter.Items.Add("ID " + "       NAMA" + "           JENIS KELAMIN" + "         SPESIALIS" + "         STATUS");
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        private void lbldatadokter_Click(object sender, EventArgs e)
        {

        }

        private void btndokter_Click(object sender, EventArgs e)
        {
            pnldokter.Visible = true;
            pnlobt.Visible = false;
            home.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void btnobat_Click(object sender, EventArgs e)
        {
            pnlobt.Visible = true;
            pnldokter.Visible = false;
            
            home.Visible = false;
        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            pnldokter.Visible = false;
            pnlobt.Visible = false;
            home.Visible = true;
        }

        private void pnlobt_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private string gender,spesialis;
        private void add_Click(object sender, EventArgs e)
        {

           
            if(man.Checked == true)
                gender = " Laki - laki";
            else if(woman.Checked == true)
                gender = " Wanita";
            

            if (bedah.Checked == true)
                spesialis = " Bedah";
            else if(anak.Checked == true)
                spesialis = " Anak";
            else if(other.Checked == true)
                spesialis = " Lainnya";

            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (progbar.Value != 100)
            {
                progbar.Value++;
                if (progbar.Value == 100)
                {
                    MessageBox.Show("Data berhasil di tambah", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    progbar.Value = 0;
                }
            }
            else
            {
                lbdokter.Items.Add(txtid.Text + "        " + txtnama.Text + "     " + gender + "                  " + spesialis + "       " + status.SelectedItem);
                txtid.Clear();
                txtnama.Clear();
                status.Text = "";
                man.Checked = false;
                woman.Checked = false;
                bedah.Checked = false;
                anak.Checked = false;
                other.Checked = false;
                progbar.Value = 0;
                timer1.Stop();
            }
           
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        int selectedRow;
        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow newDataRow = Grid.Rows[selectedRow];
            newDataRow.Cells[0].Value = kodeobat.Text;
            newDataRow.Cells[1].Value = namaobat.Text;
            newDataRow.Cells[2].Value = jenis.Text;
            newDataRow.Cells[3].Value = jumlah.Text;
        }

        private void insert_Click(object sender, EventArgs e)
        {
            if (kodeobat.Text != "" && namaobat.Text != "" && jenis.Text != "" && jumlah.Text != "") {
                int row = 0;
                Grid.Rows.Add();
                row = Grid.Rows.Count - 2;

                Grid["ClmKdObat", row].Value = kodeobat.Text;
                Grid["ClmNmObat", row].Value = namaobat.Text;
                Grid["ClmJenis", row].Value = jenis.Text;
                Grid["CLmJumlah", row].Value = jumlah.Text;
                kodeobat.Clear();
                namaobat.Clear();
                jenis.Text = "";
                jumlah.Clear();
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Grid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            kodeobat.Text = Grid.Rows[e.RowIndex].Cells[0].Value.ToString();
            namaobat.Text = Grid.Rows[e.RowIndex].Cells[1].Value.ToString();
            jenis.Text = Grid.Rows[e.RowIndex].Cells[2].Value.ToString();
            jumlah.Text = Grid.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = Grid.Rows[selectedRow];

            kodeobat.Text = row.Cells[0].Value.ToString();
            namaobat.Text = row.Cells[1].Value.ToString();
            jenis.Text = row.Cells[2].Value.ToString();
            jumlah.Text = row.Cells[3].Value.ToString();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            int rowIndex = Grid.CurrentCell.RowIndex;
            Grid.Rows.RemoveAt(rowIndex);
            kodeobat.Clear();
            namaobat.Clear();
            jenis.Text = "";
            jumlah.Clear();
          
        }
    }
}
