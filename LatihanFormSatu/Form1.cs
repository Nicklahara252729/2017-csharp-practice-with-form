﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // full screen
            System.Drawing.Rectangle rect = Screen.GetWorkingArea(this);
            this.MaximizedBounds = Screen.GetWorkingArea(this);
            this.Location = new Point(0, 0);
            this.WindowState = FormWindowState.Maximized;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lbl1.Text = "Anda Menekan Tombol 1";
        }

        private void lbl1_Click(object sender, EventArgs e)
        {
            lbl1.Text = "";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lbl1.Text = "Anda Menekan Tombol 2";
        }
    }
}
