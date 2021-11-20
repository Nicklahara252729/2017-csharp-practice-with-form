using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatihanKalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double nilai1, nilai2, hasil;
        char opr;

        private void button3_Click(object sender, EventArgs e)
        {
             if(txthasil.Text == "+" || txthasil.Text == "-" || txthasil.Text == "*" || txthasil.Text == "/"){
                txthasil.Text = "";
                txthasil.Text = txthasil.Text + btn9.Text;
            }else{
                txthasil.Text = txthasil.Text + btn9.Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            nilai1 = Convert.ToDouble(txthasil.Text);
            txthasil.Text = "";
            opr = '/';
            txthasil.Text += opr;   
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(txthasil.Text == "+" || txthasil.Text == "-" || txthasil.Text == "*" || txthasil.Text == "/"){
                txthasil.Text = "";
                txthasil.Text = txthasil.Text + btn6.Text;
            }else{
                txthasil.Text = txthasil.Text + btn6.Text;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if(txthasil.Text == "+" || txthasil.Text == "-" || txthasil.Text == "*" || txthasil.Text == "/"){
                txthasil.Text = "";
                txthasil.Text = txthasil.Text + btn1.Text;
            }else{
                txthasil.Text = txthasil.Text + btn1.Text;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
             if(txthasil.Text == "+" || txthasil.Text == "-" || txthasil.Text == "*" || txthasil.Text == "/"){
                txthasil.Text = "";
                txthasil.Text = txthasil.Text + btn2.Text;
            }else{
                txthasil.Text = txthasil.Text + btn2.Text;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if(txthasil.Text == "+" || txthasil.Text == "-" || txthasil.Text == "*" || txthasil.Text == "/"){
                txthasil.Text = "";
                txthasil.Text = txthasil.Text + btn3.Text;
            }else{
                txthasil.Text = txthasil.Text + btn3.Text;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
             if(txthasil.Text == "+" || txthasil.Text == "-" || txthasil.Text == "*" || txthasil.Text == "/"){
                txthasil.Text = "";
                txthasil.Text = txthasil.Text + btn8.Text;
            }else{
                txthasil.Text = txthasil.Text + btn8.Text;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
             if(txthasil.Text == "+" || txthasil.Text == "-" || txthasil.Text == "*" || txthasil.Text == "/"){
                txthasil.Text = "";
                txthasil.Text = txthasil.Text + btn7.Text;
            }else{
                txthasil.Text = txthasil.Text + btn7.Text;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
             if(txthasil.Text == "+" || txthasil.Text == "-" || txthasil.Text == "*" || txthasil.Text == "/"){
                txthasil.Text = "";
                txthasil.Text = txthasil.Text + btn4.Text;
            }else{
                txthasil.Text = txthasil.Text + btn4.Text;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
             if(txthasil.Text == "+" || txthasil.Text == "-" || txthasil.Text == "*" || txthasil.Text == "/"){
                txthasil.Text = "";
                txthasil.Text = txthasil.Text + btn5.Text;
            }else{
                txthasil.Text = txthasil.Text + btn5.Text;
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
             if(txthasil.Text == "+" || txthasil.Text == "-" || txthasil.Text == "*" || txthasil.Text == "/"){
                txthasil.Text = "";
                txthasil.Text = txthasil.Text + btn0.Text;
            }else{
                txthasil.Text = txthasil.Text + btn0.Text;
            }
        }

        private void kali_Click(object sender, EventArgs e)
        {
            nilai1 = Convert.ToDouble(txthasil.Text);
            txthasil.Text = "";
            opr = '*';
            txthasil.Text += opr;  
        }

        private void kurang_Click(object sender, EventArgs e)
        {
            nilai1 = Convert.ToDouble(txthasil.Text);
            txthasil.Text = "";
            opr = '-';
            txthasil.Text += opr;  
        }

        private void tambah_Click(object sender, EventArgs e)
        {
            nilai1 = Convert.ToDouble(txthasil.Text);
            txthasil.Text = "";
            opr = '+';
            txthasil.Text += opr;  
        }

        private void samadengan_Click(object sender, EventArgs e)
        {
            nilai2 = Convert.ToDouble(txthasil.Text);
            txthasil.Text = "";
            if (opr == '/')
            {
                hasil = nilai1 / nilai2;
                txthasil.Text += hasil;
                nilai1 = hasil;
            }
            else if (opr == '*')
            {
                hasil = nilai1 * nilai2;
                txthasil.Text += hasil;
                nilai1 = hasil;
            }
            else if (opr == '-')
            {
                hasil = nilai1 - nilai2;
                txthasil.Text += hasil;
                nilai1 = hasil;
            }
            else 
            {
                hasil = nilai1 + nilai2;
                txthasil.Text += hasil;
                nilai1 = hasil;
            }

        }

        private void titik_Click(object sender, EventArgs e)
        {
            if(txthasil.Text == "+" || txthasil.Text == "-" || txthasil.Text == "*" || txthasil.Text == "/"){
                txthasil.Text = "";
                txthasil.Text = txthasil.Text + titik.Text;
            }else{
                txthasil.Text = txthasil.Text + titik.Text;
            }
        
        }

        private void clr_Click(object sender, EventArgs e)
        {
            txthasil.Text = "";
        }
    }
}
