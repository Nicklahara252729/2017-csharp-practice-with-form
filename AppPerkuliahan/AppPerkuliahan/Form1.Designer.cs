namespace AppPerkuliahan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnnilai = new DevComponents.DotNetBar.ButtonX();
            this.logout = new DevComponents.DotNetBar.ButtonX();
            this.SpConfig = new DevComponents.DotNetBar.Controls.SlidePanel();
            this.btncloseconfig = new DevComponents.DotNetBar.ButtonX();
            this.btnrefconfig = new DevComponents.DotNetBar.ButtonX();
            this.btnconfig = new DevComponents.DotNetBar.ButtonX();
            this.btnmatakuliah = new DevComponents.DotNetBar.ButtonX();
            this.btnmahasiswa = new DevComponents.DotNetBar.ButtonX();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblinfo = new System.Windows.Forms.Label();
            this.viewmahasiswa = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbldata = new System.Windows.Forms.Label();
            this.cpmhs = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.cpmatkul = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SpConfig.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewmahasiswa)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.btnnilai);
            this.panel1.Controls.Add(this.logout);
            this.panel1.Controls.Add(this.SpConfig);
            this.panel1.Controls.Add(this.btnmatakuliah);
            this.panel1.Controls.Add(this.btnmahasiswa);
            this.panel1.Location = new System.Drawing.Point(-2, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 70);
            this.panel1.TabIndex = 0;
            // 
            // btnnilai
            // 
            this.btnnilai.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnnilai.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnnilai.Location = new System.Drawing.Point(267, 0);
            this.btnnilai.Name = "btnnilai";
            this.btnnilai.Size = new System.Drawing.Size(99, 70);
            this.btnnilai.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnnilai.Symbol = "";
            this.btnnilai.TabIndex = 4;
            this.btnnilai.Text = "Nilai";
            this.btnnilai.Click += new System.EventHandler(this.btnnilai_Click);
            // 
            // logout
            // 
            this.logout.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.logout.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.logout.Location = new System.Drawing.Point(697, 0);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(89, 70);
            this.logout.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.logout.Symbol = "";
            this.logout.SymbolSize = 50F;
            this.logout.TabIndex = 3;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // SpConfig
            // 
            this.SpConfig.BackColor = System.Drawing.Color.OliveDrab;
            this.SpConfig.Controls.Add(this.btncloseconfig);
            this.SpConfig.Controls.Add(this.btnrefconfig);
            this.SpConfig.Controls.Add(this.btnconfig);
            this.SpConfig.ForeColor = System.Drawing.Color.Black;
            this.SpConfig.Location = new System.Drawing.Point(414, 0);
            this.SpConfig.Name = "SpConfig";
            this.SpConfig.Size = new System.Drawing.Size(194, 70);
            this.SpConfig.TabIndex = 2;
            this.SpConfig.Text = "slidePanel1";
            this.SpConfig.UsesBlockingAnimation = false;
            this.SpConfig.Visible = false;
            // 
            // btncloseconfig
            // 
            this.btncloseconfig.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btncloseconfig.BackColor = System.Drawing.Color.YellowGreen;
            this.btncloseconfig.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btncloseconfig.Location = new System.Drawing.Point(153, 5);
            this.btncloseconfig.Name = "btncloseconfig";
            this.btncloseconfig.Size = new System.Drawing.Size(37, 22);
            this.btncloseconfig.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btncloseconfig.Symbol = "";
            this.btncloseconfig.SymbolSize = 10F;
            this.btncloseconfig.TabIndex = 3;
            this.btncloseconfig.Click += new System.EventHandler(this.btncloseconfig_Click);
            // 
            // btnrefconfig
            // 
            this.btnrefconfig.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnrefconfig.BackColor = System.Drawing.Color.YellowGreen;
            this.btnrefconfig.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnrefconfig.Location = new System.Drawing.Point(110, 5);
            this.btnrefconfig.Name = "btnrefconfig";
            this.btnrefconfig.Size = new System.Drawing.Size(37, 22);
            this.btnrefconfig.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnrefconfig.Symbol = "";
            this.btnrefconfig.SymbolSize = 10F;
            this.btnrefconfig.TabIndex = 1;
            this.btnrefconfig.Click += new System.EventHandler(this.btnrefconfig_Click);
            // 
            // btnconfig
            // 
            this.btnconfig.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnconfig.BackColor = System.Drawing.Color.YellowGreen;
            this.btnconfig.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnconfig.Location = new System.Drawing.Point(3, 38);
            this.btnconfig.Name = "btnconfig";
            this.btnconfig.Size = new System.Drawing.Size(188, 23);
            this.btnconfig.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnconfig.TabIndex = 0;
            this.btnconfig.Text = "Kelola Data Matakuliah";
            this.btnconfig.Click += new System.EventHandler(this.btnconfig_Click);
            // 
            // btnmatakuliah
            // 
            this.btnmatakuliah.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnmatakuliah.BackColor = System.Drawing.Color.Transparent;
            this.btnmatakuliah.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnmatakuliah.Location = new System.Drawing.Point(161, 3);
            this.btnmatakuliah.Name = "btnmatakuliah";
            this.btnmatakuliah.Size = new System.Drawing.Size(100, 67);
            this.btnmatakuliah.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnmatakuliah.Symbol = "";
            this.btnmatakuliah.TabIndex = 1;
            this.btnmatakuliah.Text = "Matakuliah";
            this.btnmatakuliah.Click += new System.EventHandler(this.btnmatakuliah_Click);
            // 
            // btnmahasiswa
            // 
            this.btnmahasiswa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnmahasiswa.BackColor = System.Drawing.Color.Transparent;
            this.btnmahasiswa.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnmahasiswa.Location = new System.Drawing.Point(52, 3);
            this.btnmahasiswa.Name = "btnmahasiswa";
            this.btnmahasiswa.Size = new System.Drawing.Size(91, 65);
            this.btnmahasiswa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnmahasiswa.Symbol = "";
            this.btnmahasiswa.TabIndex = 0;
            this.btnmahasiswa.Text = "Mahasiswa";
            this.btnmahasiswa.Click += new System.EventHandler(this.btnmahasiswa_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OliveDrab;
            this.panel2.Controls.Add(this.lblinfo);
            this.panel2.Location = new System.Drawing.Point(-2, 432);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(789, 33);
            this.panel2.TabIndex = 1;
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfo.Location = new System.Drawing.Point(9, 7);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(127, 20);
            this.lblinfo.TabIndex = 5;
            this.lblinfo.Text = "Data Mahasiswa";
            // 
            // viewmahasiswa
            // 
            this.viewmahasiswa.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.viewmahasiswa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.viewmahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewmahasiswa.Location = new System.Drawing.Point(11, 131);
            this.viewmahasiswa.Name = "viewmahasiswa";
            this.viewmahasiswa.Size = new System.Drawing.Size(590, 289);
            this.viewmahasiswa.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "IT SOFTWARE SOLUTION ( Campus Management System )";
            // 
            // lbldata
            // 
            this.lbldata.AutoSize = true;
            this.lbldata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldata.Location = new System.Drawing.Point(5, 110);
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(127, 20);
            this.lbldata.TabIndex = 4;
            this.lbldata.Text = "Data Mahasiswa";
            // 
            // cpmhs
            // 
            // 
            // 
            // 
            this.cpmhs.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cpmhs.Location = new System.Drawing.Point(625, 133);
            this.cpmhs.Name = "cpmhs";
            this.cpmhs.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Donut;
            this.cpmhs.ProgressTextFormat = "{0}";
            this.cpmhs.ProgressTextVisible = true;
            this.cpmhs.Size = new System.Drawing.Size(140, 114);
            this.cpmhs.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.cpmhs.TabIndex = 5;
            // 
            // cpmatkul
            // 
            // 
            // 
            // 
            this.cpmatkul.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cpmatkul.Location = new System.Drawing.Point(630, 285);
            this.cpmatkul.Name = "cpmatkul";
            this.cpmatkul.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Donut;
            this.cpmatkul.ProgressColor = System.Drawing.Color.DarkOliveGreen;
            this.cpmatkul.ProgressTextFormat = "{0}";
            this.cpmatkul.ProgressTextVisible = true;
            this.cpmatkul.Size = new System.Drawing.Size(140, 108);
            this.cpmatkul.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.cpmatkul.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(635, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Jumlah Mahasiswa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(637, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Jumlah Matakuliah";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cpmatkul);
            this.Controls.Add(this.cpmhs);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbldata);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewmahasiswa);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.SpConfig.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewmahasiswa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.ButtonX logout;
        private DevComponents.DotNetBar.Controls.SlidePanel SpConfig;
        private DevComponents.DotNetBar.ButtonX btncloseconfig;
        private DevComponents.DotNetBar.ButtonX btnrefconfig;
        private DevComponents.DotNetBar.ButtonX btnconfig;
        private DevComponents.DotNetBar.ButtonX btnmatakuliah;
        private DevComponents.DotNetBar.ButtonX btnmahasiswa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.DataGridView viewmahasiswa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbldata;
        private DevComponents.DotNetBar.ButtonX btnnilai;
        private DevComponents.DotNetBar.Controls.CircularProgress cpmhs;
        private DevComponents.DotNetBar.Controls.CircularProgress cpmatkul;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}

