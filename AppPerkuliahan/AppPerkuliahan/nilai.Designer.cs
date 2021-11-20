namespace AppPerkuliahan
{
    partial class nilai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nilai));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gpdatanilai = new System.Windows.Forms.GroupBox();
            this.cmbkodenim = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbkodemk = new System.Windows.Forms.ComboBox();
            this.txtdosen = new System.Windows.Forms.TextBox();
            this.txtnilai = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btngetdata = new DevComponents.DotNetBar.ButtonX();
            this.btndelete = new DevComponents.DotNetBar.ButtonX();
            this.btnupdate = new DevComponents.DotNetBar.ButtonX();
            this.btnsave = new DevComponents.DotNetBar.ButtonX();
            this.btnnew = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpdatanilai.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(658, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kelola Data Nilai";
            // 
            // gpdatanilai
            // 
            this.gpdatanilai.Controls.Add(this.cmbkodenim);
            this.gpdatanilai.Controls.Add(this.label5);
            this.gpdatanilai.Controls.Add(this.label4);
            this.gpdatanilai.Controls.Add(this.label3);
            this.gpdatanilai.Controls.Add(this.label2);
            this.gpdatanilai.Controls.Add(this.cmbkodemk);
            this.gpdatanilai.Controls.Add(this.txtdosen);
            this.gpdatanilai.Controls.Add(this.txtnilai);
            this.gpdatanilai.Enabled = false;
            this.gpdatanilai.Location = new System.Drawing.Point(9, 43);
            this.gpdatanilai.Name = "gpdatanilai";
            this.gpdatanilai.Size = new System.Drawing.Size(483, 221);
            this.gpdatanilai.TabIndex = 7;
            this.gpdatanilai.TabStop = false;
            // 
            // cmbkodenim
            // 
            this.cmbkodenim.FormattingEnabled = true;
            this.cmbkodenim.Location = new System.Drawing.Point(177, 39);
            this.cmbkodenim.Name = "cmbkodenim";
            this.cmbkodenim.Size = new System.Drawing.Size(237, 21);
            this.cmbkodenim.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kode Dosen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nilai";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kode MK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kode NIM";
            // 
            // cmbkodemk
            // 
            this.cmbkodemk.FormattingEnabled = true;
            this.cmbkodemk.Location = new System.Drawing.Point(177, 83);
            this.cmbkodemk.Name = "cmbkodemk";
            this.cmbkodemk.Size = new System.Drawing.Size(237, 21);
            this.cmbkodemk.TabIndex = 3;
            // 
            // txtdosen
            // 
            this.txtdosen.Location = new System.Drawing.Point(177, 155);
            this.txtdosen.Multiline = true;
            this.txtdosen.Name = "txtdosen";
            this.txtdosen.Size = new System.Drawing.Size(237, 29);
            this.txtdosen.TabIndex = 2;
            // 
            // txtnilai
            // 
            this.txtnilai.Location = new System.Drawing.Point(177, 116);
            this.txtnilai.Multiline = true;
            this.txtnilai.Name = "txtnilai";
            this.txtnilai.Size = new System.Drawing.Size(237, 29);
            this.txtnilai.TabIndex = 1;
            this.txtnilai.TextChanged += new System.EventHandler(this.txtnama_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btngetdata);
            this.groupBox1.Controls.Add(this.btndelete);
            this.groupBox1.Controls.Add(this.btnupdate);
            this.groupBox1.Controls.Add(this.btnsave);
            this.groupBox1.Controls.Add(this.btnnew);
            this.groupBox1.Location = new System.Drawing.Point(498, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 222);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Action";
            // 
            // btngetdata
            // 
            this.btngetdata.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btngetdata.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btngetdata.Location = new System.Drawing.Point(9, 184);
            this.btngetdata.Name = "btngetdata";
            this.btngetdata.Size = new System.Drawing.Size(185, 32);
            this.btngetdata.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btngetdata.TabIndex = 4;
            this.btngetdata.Text = "GET DATA";
            // 
            // btndelete
            // 
            this.btndelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btndelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btndelete.Location = new System.Drawing.Point(9, 148);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(185, 30);
            this.btndelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btndelete.TabIndex = 3;
            this.btndelete.Text = "DELETE";
            // 
            // btnupdate
            // 
            this.btnupdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnupdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnupdate.Location = new System.Drawing.Point(9, 107);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(185, 33);
            this.btnupdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnupdate.TabIndex = 2;
            this.btnupdate.Text = "UPDATE";
            // 
            // btnsave
            // 
            this.btnsave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnsave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnsave.Location = new System.Drawing.Point(9, 65);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(185, 36);
            this.btnsave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnsave.TabIndex = 1;
            this.btnsave.Text = "SAVE";
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnnew
            // 
            this.btnnew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnnew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnnew.Location = new System.Drawing.Point(9, 20);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(185, 38);
            this.btnnew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnnew.TabIndex = 0;
            this.btnnew.Text = "NEW";
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // nilai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 273);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gpdatanilai);
            this.Controls.Add(this.groupBox1);
            this.Name = "nilai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "nilai";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpdatanilai.ResumeLayout(false);
            this.gpdatanilai.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpdatanilai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbkodemk;
        private System.Windows.Forms.TextBox txtdosen;
        private System.Windows.Forms.TextBox txtnilai;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX btngetdata;
        private DevComponents.DotNetBar.ButtonX btndelete;
        private DevComponents.DotNetBar.ButtonX btnupdate;
        private DevComponents.DotNetBar.ButtonX btnsave;
        private DevComponents.DotNetBar.ButtonX btnnew;
        private System.Windows.Forms.ComboBox cmbkodenim;
    }
}