namespace LatihanGrade
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblnt = new System.Windows.Forms.Label();
            this.txttugas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.none = new System.Windows.Forms.Label();
            this.txtpresensi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtuts = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtuas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.btncount = new System.Windows.Forms.Button();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.grade = new System.Windows.Forms.Label();
            this.ket = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.putar = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblnt
            // 
            this.lblnt.AutoSize = true;
            this.lblnt.Location = new System.Drawing.Point(13, 16);
            this.lblnt.Name = "lblnt";
            this.lblnt.Size = new System.Drawing.Size(60, 13);
            this.lblnt.TabIndex = 0;
            this.lblnt.Text = "Nilai Tugas";
            // 
            // txttugas
            // 
            this.txttugas.Location = new System.Drawing.Point(100, 16);
            this.txttugas.Name = "txttugas";
            this.txttugas.Size = new System.Drawing.Size(109, 20);
            this.txttugas.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "1-100 (20%)";
            // 
            // none
            // 
            this.none.AutoSize = true;
            this.none.Location = new System.Drawing.Point(216, 49);
            this.none.Name = "none";
            this.none.Size = new System.Drawing.Size(63, 13);
            this.none.TabIndex = 5;
            this.none.Text = "1-100 (10%)";
            // 
            // txtpresensi
            // 
            this.txtpresensi.Location = new System.Drawing.Point(100, 42);
            this.txtpresensi.Name = "txtpresensi";
            this.txtpresensi.Size = new System.Drawing.Size(109, 20);
            this.txtpresensi.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nilai Presensi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "1-100 (30%)";
            // 
            // txtuts
            // 
            this.txtuts.Location = new System.Drawing.Point(100, 68);
            this.txtuts.Name = "txtuts";
            this.txtuts.Size = new System.Drawing.Size(109, 20);
            this.txtuts.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nilai UTS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(216, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "1-100 (40%)";
            // 
            // txtuas
            // 
            this.txtuas.Location = new System.Drawing.Point(100, 94);
            this.txtuas.Name = "txtuas";
            this.txtuas.Size = new System.Drawing.Size(109, 20);
            this.txtuas.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Nilai UAS";
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(16, 137);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 12;
            this.btnclear.Text = "CLEAR";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btncount
            // 
            this.btncount.Location = new System.Drawing.Point(206, 138);
            this.btncount.Name = "btncount";
            this.btncount.Size = new System.Drawing.Size(75, 23);
            this.btncount.TabIndex = 13;
            this.btncount.Text = "COUNT";
            this.btncount.UseVisualStyleBackColor = true;
            this.btncount.Click += new System.EventHandler(this.btncount_Click);
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(100, 138);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(100, 20);
            this.txttotal.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(116, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "TOTAL NILAI";
            // 
            // grade
            // 
            this.grade.AutoSize = true;
            this.grade.Location = new System.Drawing.Point(127, 186);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(45, 13);
            this.grade.TabIndex = 16;
            this.grade.Text = "GRADE";
            // 
            // ket
            // 
            this.ket.AutoSize = true;
            this.ket.Location = new System.Drawing.Point(111, 212);
            this.ket.Name = "ket";
            this.ket.Size = new System.Drawing.Size(81, 13);
            this.ket.TabIndex = 17;
            this.ket.Text = "KETERANGAN";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtuts);
            this.panel1.Controls.Add(this.ket);
            this.panel1.Controls.Add(this.lblnt);
            this.panel1.Controls.Add(this.grade);
            this.panel1.Controls.Add(this.txttugas);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txttotal);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btncount);
            this.panel1.Controls.Add(this.txtpresensi);
            this.panel1.Controls.Add(this.btnclear);
            this.panel1.Controls.Add(this.none);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtuas);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 243);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.putar);
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 243);
            this.panel2.TabIndex = 19;
            // 
            // putar
            // 
            // 
            // 
            // 
            this.putar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.putar.Location = new System.Drawing.Point(26, 6);
            this.putar.Name = "putar";
            this.putar.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Donut;
            this.putar.ProgressColor = System.Drawing.Color.Crimson;
            this.putar.ProgressTextVisible = true;
            this.putar.Size = new System.Drawing.Size(255, 230);
            this.putar.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.putar.TabIndex = 19;
            this.putar.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 264);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblnt;
        private System.Windows.Forms.TextBox txttugas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label none;
        private System.Windows.Forms.TextBox txtpresensi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtuts;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtuas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btncount;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label grade;
        private System.Windows.Forms.Label ket;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.Controls.CircularProgress putar;
        private System.Windows.Forms.Timer timer1;
    }
}

