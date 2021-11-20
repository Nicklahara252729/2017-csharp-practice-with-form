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
    public partial class nilai : Form
    {
        public nilai()
        {
            InitializeComponent();
            tampilkdmk();
            tampilnim();
        }

        private void txtnama_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            gpdatanilai.Enabled = true;
            btnsave.Enabled = true;
            btnupdate.Enabled = true;
            btndelete.Enabled = true;
            btngetdata.Enabled = true;
        }

        public void EnableFalse()
        {
            btnsave.Enabled = false;
            btnupdate.Enabled = false;
            btndelete.Enabled = false; ;
            btngetdata.Enabled = false;

        }

        public void tampilkdmk()
        {
            try
            {
                using (OracleConnection conn = new OracleConnection("User ID=dbperkuliahan" + ";Password=123" + ";Data Source ='XE" + "';"))
                using (OracleCommand cmd = new OracleCommand("select kdmk from tblkuliah",conn))
                {
                    conn.Open();
                    using (OracleDataReader Reader = cmd.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            cmbkodemk.Items.Add(Reader["KDMK"].ToString());
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void tampilnim()
        {
            try
            {
                using (OracleConnection conn = new OracleConnection("User ID=dbperkuliahan" + ";Password=123" + ";Data Source ='XE" + "';"))
                using (OracleCommand cmd = new OracleCommand("select nim from tblmahasiswa", conn))
                {
                    conn.Open();
                    using (OracleDataReader Reader = cmd.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            cmbkodenim.Items.Add(Reader["NIM"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string nim, nama, jurusan, kdmk;

        public void insert()
        {
            string query = string.Format("insert into tblmahasiswa values('" + nim + "','" + nama + "','" + jurusan + "' ,'" + kdmk + "')");
            var database = koneksi.GetOracleConnection();
            var command = database.CreateCommand();
            command.CommandText = query;
            database.Open();
            command.ExecuteNonQuery();
            database.Close();
            database.Dispose();
            command.Dispose();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            
        }
    }
}
