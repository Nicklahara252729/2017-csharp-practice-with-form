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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tampilan();
        }

       

        private void ChangeSlideSide(eSlideSide side)
        {
            SpConfig.SlideSide = side;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SpConfig.IsOpen = false;
        }

        private void btnmahasiswa_Click(object sender, EventArgs e)
        {
            lblinfo.Text = "Data Mahasiswa";
            btnconfig.Text = "Kelola Data Mahasiswa";
            lbldata.Text = "Data Mahasiswa";
            
            SpConfig.Visible = true;
            SpConfig.IsOpen = true;
            ChangeSlideSide(eSlideSide.Left);
            tampilan();
        }

        private void btnmatakuliah_Click(object sender, EventArgs e)
        {
            lblinfo.Text = "Data Matakuliah";
            btnconfig.Text = "Kelola Data Matakuliah";
            lbldata.Text = "Data Matakuliah";

            SpConfig.Visible = true;
            SpConfig.IsOpen = true;
            ChangeSlideSide(eSlideSide.Left);
            tampilkuliah();
        }

        private void btnnilai_Click(object sender, EventArgs e)
        {
            lblinfo.Text = "Data Nilai";
            btnconfig.Text = "Kelola Data Nilai";
            lbldata.Text = "Data Nilai";

            SpConfig.Visible = true;
            SpConfig.IsOpen = true;
            ChangeSlideSide(eSlideSide.Left);
            tampilnilai();
        }

        public void tampilnilai()
        {
            try
            {
                using (OracleConnection Conn = new OracleConnection
                    ("User ID=dbperkuliahan" + ";Password=123" + ";Data Source=XE" + ";"))
                {
                    using(OracleCommand cmd = new OracleCommand
                    ("select * from tblnilai", Conn))
                    {
                        Conn.Open();
                        using(OracleDataReader reader = cmd.ExecuteReader()){
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);
                            viewmahasiswa.DataSource = dataTable;
                            viewmahasiswa.Columns[0].HeaderText = "KODE NILAI";
                            viewmahasiswa.Columns[1].HeaderText = "KODE MATKUL";
                            viewmahasiswa.Columns[2].HeaderText = "NILAI";
                            viewmahasiswa.Columns[3].HeaderText = "KODE DOSEN";
                            viewmahasiswa.Columns[4].HeaderText = "NIM";
                            viewmahasiswa.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                            viewmahasiswa.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                            viewmahasiswa.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                            viewmahasiswa.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                            viewmahasiswa.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btncloseconfig_Click(object sender, EventArgs e)
        {
            SpConfig.Visible = false;
            SpConfig.IsOpen = false;
            ChangeSlideSide(eSlideSide.Left);
        }

        public void tampilan()
        {
            try
            {
                using (OracleConnection Conn = new OracleConnection
                    ("User ID=dbperkuliahan" + ";Password=123" + ";Data Source=XE" + ";"))
                {
                    using(OracleCommand cmd = new OracleCommand
                    ("select * from tblmahasiswa", Conn))
                    {
                        Conn.Open();
                        using(OracleDataReader reader = cmd.ExecuteReader()){
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);
                            viewmahasiswa.DataSource = dataTable;
                            viewmahasiswa.Columns[0].HeaderText = "NIM";
                            viewmahasiswa.Columns[1].HeaderText = "NAMA";
                            viewmahasiswa.Columns[2].HeaderText = "JURUSAN";
                            viewmahasiswa.Columns[3].HeaderText = "KODE MATAKULIAH";
                            viewmahasiswa.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                            viewmahasiswa.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                            viewmahasiswa.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                            viewmahasiswa.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        }
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void tampilkuliah()
        {
            try
            {
                using (OracleConnection Conn = new OracleConnection
                    ("User ID=dbperkuliahan" + ";Password=123" + ";Data Source=XE" + ";"))
                {
                    using (OracleCommand cmd = new OracleCommand
                    ("select * from tblkuliah", Conn))
                    {
                        Conn.Open();
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);
                            viewmahasiswa.DataSource = dataTable;
                            viewmahasiswa.Columns[0].HeaderText = "KDMK";
                            viewmahasiswa.Columns[1].HeaderText = "NAMAMK";
                            viewmahasiswa.Columns[2].HeaderText = "KDNIAI";
                            viewmahasiswa.Columns[3].HeaderText = "SKS";
                            viewmahasiswa.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                            viewmahasiswa.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                            viewmahasiswa.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                            viewmahasiswa.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnconfig_Click(object sender, EventArgs e)
        {
            if (btnconfig.Text == "Kelola Data Mahasiswa")
            {
                FrmMahasiswa fmhs = new FrmMahasiswa();
                fmhs.Show();

            }
            else if(btnconfig.Text == "Kelola Data Matakuliah")
            {
                frmmatakuliah fmatkul = new frmmatakuliah();
                fmatkul.Show();
            }
            else if (btnconfig.Text == "Kelola Data Nilai")
            {
                nilai fmatkul = new nilai();
                fmatkul.Show();
            }
        }

        private void btnrefconfig_Click(object sender, EventArgs e)
        {
            if (btnconfig.Text == "Kelola Data Mahasiswa")
            {
                tampilan();
            }
            else if (btnconfig.Text == "Kelola Data Matakuliah")
            {
                tampilkuliah();
            }
            else if (btnconfig.Text == "Kelola Data Nilai")
            {
                tampilnilai();
            }
        }

        private void logout_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show
                ("aplikasi akan ditutup ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogresult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //count jumlah mahasiswa
            try
            {
                using (OracleConnection conn = new OracleConnection("User ID=dbperkuliahan" + ";Password=123" + ";Data Source='XE" + "';")) 
                using (OracleCommand cmd = new OracleCommand("select count(*) from tblmahasiswa", conn))
                {
                    conn.Open(); 
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string mahasiswa;
                            mahasiswa = reader["COUNT(*)"].ToString();
                            cpmhs.Value = Convert.ToInt16(mahasiswa);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //count jumlah matakuliah
            try
            {
                using (OracleConnection conn = new OracleConnection("User ID=dbperkuliahan" + ";Password=123" + ";Data Source='XE" + "';"))
                using (OracleCommand cmd = new OracleCommand("select count(*) from tblkuliah", conn))
                {
                    conn.Open();
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string matkul;
                            matkul = reader["COUNT(*)"].ToString();
                            cpmatkul.Value = Convert.ToInt16(matkul);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
