using DevComponents.DotNetBar.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetBarApps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ChangeSlideSide(eSlideSide side)
        {
            spmain.SlideSide = side;
        }
        private void metroTileItem1_Click(object sender, EventArgs e)
        {
            spmain.IsOpen = false;
            ChangeSlideSide(eSlideSide.Bottom);
            spmenu1.Visible = true;
            spmenudua.Visible = false;
        }

        private void metroTileItem3_Click(object sender, EventArgs e)
        {

        }

        private void metroTileItem2_Click(object sender, EventArgs e)
        {
            spmain.IsOpen = false;
            ChangeSlideSide(eSlideSide.Left);
            spmenudua.Visible = true;
            spmenu1.Visible = false;
        }

        private void metroTilePanel1_Click(object sender, EventArgs e)
        {
            
        }

        private void spmenu1_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            spmain.IsOpen = true;
            ChangeSlideSide(eSlideSide.Left);
            spmenudua.Visible = false;
            spmenu1.Visible = false;
        }

        public int detik, menit, jam;
        public bool pause;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if ((menit == 0) && (detik == 0) && (jam == 0))
            {
                timer1.Enabled = false;
                Console.Beep();
                MessageBox.Show(pesan.Text, "PERINGATAN");
                btnpause.Enabled = false;
                btnstop.Enabled = false;
                btnstart.Enabled = true;
                pesan.Clear();
                hour.Text = Convert.ToString(0);
                minute.Text = Convert.ToString(0);
                seconds.Text = Convert.ToString(0);
                hour.Enabled = true;
                minute.Enabled = true;
                seconds.Enabled = true;
                lblhour.Text = "00";
                lblmin.Text = "00";
                lblsec.Text = "00";
            }
            else
            {
                if (detik < 1)
                {
                    detik = 59;
                    if (menit == 0)
                    {
                        menit = 59;
                        if (jam != 0)
                        {
                            jam -= 1;
                        }
                        
                    }else
                        {
                            menit -= 1;
                        }
                }
                else
                {
                    detik -= 1;
                    lblhour.Text = jam.ToString();
                    lblmin.Text = menit.ToString();
                    lblsec.Text = detik.ToString();
                }

                if ((menit == 3) && (jam == 0) && (detik == 0))
                {
                    MessageBox.Show("3 menit tersisa !");
                }
            }
        }

       

        private void btnstart_Click_1(object sender, EventArgs e)
        {
            if (pause != true)
            {
                if ((hour.Text != string.Empty) &&
                    (minute.Text != string.Empty) &&
                    (seconds.Text != string.Empty))
                {
                    timer1.Enabled = true;
                    btnpause.Enabled = true;
                    btnstart.Enabled = true;
                    btnstop.Enabled = true;
                    hour.Enabled = true;
                    minute.Enabled = true;
                    seconds.Enabled = true;
                    pesan.Enabled = true;

                    try
                    {
                        jam = Convert.ToInt32(hour.Text);
                        menit = Convert.ToInt32(minute.Text);
                        detik = Convert.ToInt32(seconds.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("inputan tidak lengkap !");
                }
            }
            else
            {
                timer1.Enabled = true;
                pause = false;
                btnstart.Enabled = false;
                btnpause.Enabled = true;
            }
        }

        private void btnpause_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            pause = true;
            btnpause.Enabled = false;
            btnstart.Enabled = true;
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            pause = false;
            timer1.Enabled = false;
            btnpause.Enabled = false;
            btnstop.Enabled = false;
            btnstart.Enabled = true;
            pesan.Clear();
            hour.Text = Convert.ToString(0);
            minute.Text = Convert.ToString(0);
            seconds.Text = Convert.ToString(0);
            hour.Enabled = true;
            minute.Enabled = true;
            seconds.Enabled = true;
            pesan.Enabled = true;
            lblhour.Text = "00";
            lblmin.Text = "00";
            lblsec.Text = "00";
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            spmain.IsOpen = true;
            ChangeSlideSide(eSlideSide.Left);
            spmenudua.Visible = false;
            spmenu1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int panjangplain, j, i, k, indexplain, indexkunci = 0, panjangkunci;
            int convascii1, convascii2, hasil;
            string kar, karkunci;

            char kar1, kar2;
            char[] tmp1 = new char[100];
            string tmp2 = "";

            txtplain.Text = txtplain.Text.ToUpper();
            txtkey.Text = txtkey.Text.ToUpper();
            panjangplain = txtplain.TextLength;
            j = 1;
            for (i = 1; i < panjangplain + 1; i++)
            {
                kar = txtplain.Text.Substring(i - 1, 1);
                kar1 = Convert.ToChar(kar);
                convascii1 = Convert.ToInt16(kar1);
                indexplain = convascii1 - 65;
                panjangkunci = txtkey.TextLength;

                if (indexplain < 0)
                {
                    hasil = convascii1;
                    goto lanjutenkripsi;
                }

                if (kar == "")
                {
                    j = j - 1;
                }
                else
                {
                    karkunci = txtkey.Text.Substring(j - 1, 1);
                    kar2 = Convert.ToChar(karkunci);
                    convascii2 = Convert.ToInt16(kar2);
                    indexkunci = convascii2 - 65;
                }

                if (j == panjangkunci)
                {
                    j = 1;
                }
                else
                {
                    j = j + 1;
                }
                    hasil = (indexplain + indexkunci) % 26;
                    lanjutenkripsi:
                    if (hasil < 0)
                    {
                        hasil = -33;
                        tmp1[i] = Convert.ToChar(hasil + 65);
                    }
                    else if (hasil > 25)
                    {
                        tmp1[i] = Convert.ToChar(hasil);
                    }
                    else
                    {
                        tmp1[i] = Convert.ToChar(hasil + 65);
                    }
                }
                for (k = 1; k < panjangplain + 1; k++)
                {
                    tmp2 = tmp2 + tmp1[k];
                }
                txtchiper.Text = tmp2;
            }
        }
}
