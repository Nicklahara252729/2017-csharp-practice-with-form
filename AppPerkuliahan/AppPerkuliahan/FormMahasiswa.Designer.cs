namespace AppPerkuliahan
{
    partial class FormMahasiswa
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
            this.grbdatamahasiswa = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnim = new System.Windows.Forms.TextBox();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.txtkdmatkul = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnnew = new DevComponents.DotNetBar.ButtonX();
            this.btnsave = new DevComponents.DotNetBar.ButtonX();
            this.btnupdate = new DevComponents.DotNetBar.ButtonX();
            this.btndel = new DevComponents.DotNetBar.ButtonX();
            this.btngetdata = new DevComponents.DotNetBar.ButtonX();
            this.cmbjurusan = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbdatamahasiswa.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbdatamahasiswa
            // 
            this.grbdatamahasiswa.Controls.Add(this.cmbjurusan);
            this.grbdatamahasiswa.Controls.Add(this.txtkdmatkul);
            this.grbdatamahasiswa.Controls.Add(this.txtnama);
            this.grbdatamahasiswa.Controls.Add(this.txtnim);
            this.grbdatamahasiswa.Controls.Add(this.label5);
            this.grbdatamahasiswa.Controls.Add(this.label4);
            this.grbdatamahasiswa.Controls.Add(this.label3);
            this.grbdatamahasiswa.Controls.Add(this.label2);
            this.grbdatamahasiswa.Enabled = false;
            this.grbdatamahasiswa.Location = new System.Drawing.Point(17, 89);
            this.grbdatamahasiswa.Name = "grbdatamahasiswa";
            this.grbdatamahasiswa.Size = new System.Drawing.Size(428, 189);
            this.grbdatamahasiswa.TabIndex = 0;
            this.grbdatamahasiswa.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kelola Data Mahasiswa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "NIM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "NAMA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "JURUSAN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "KODE MATKUL";
            // 
            // txtnim
            // 
            this.txtnim.Location = new System.Drawing.Point(201, 50);
            this.txtnim.Name = "txtnim";
            this.txtnim.Size = new System.Drawing.Size(123, 20);
            this.txtnim.TabIndex = 6;
            // 
            // txtnama
            // 
            this.txtnama.Location = new System.Drawing.Point(201, 80);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(213, 20);
            this.txtnama.TabIndex = 7;
            // 
            // txtkdmatkul
            // 
            this.txtkdmatkul.Location = new System.Drawing.Point(201, 143);
            this.txtkdmatkul.Name = "txtkdmatkul";
            this.txtkdmatkul.Size = new System.Drawing.Size(213, 20);
            this.txtkdmatkul.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btngetdata);
            this.groupBox1.Controls.Add(this.btndel);
            this.groupBox1.Controls.Add(this.btnupdate);
            this.groupBox1.Controls.Add(this.btnsave);
            this.groupBox1.Controls.Add(this.btnnew);
            this.groupBox1.Location = new System.Drawing.Point(452, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 189);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Action";
            // 
            // btnnew
            // 
            this.btnnew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnnew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.Location = new System.Drawing.Point(7, 20);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(117, 23);
            this.btnnew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnnew.TabIndex = 0;
            this.btnnew.Text = "NEW";
            // 
            // btnsave
            // 
            this.btnsave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnsave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(7, 51);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(117, 23);
            this.btnsave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnsave.TabIndex = 3;
            this.btnsave.Text = "SAVE";
            // 
            // btnupdate
            // 
            this.btnupdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnupdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(7, 82);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(117, 23);
            this.btnupdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnupdate.TabIndex = 4;
            this.btnupdate.Text = "UPDATE";
            // 
            // btndel
            // 
            this.btndel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btndel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btndel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.Location = new System.Drawing.Point(7, 113);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(117, 23);
            this.btndel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btndel.TabIndex = 5;
            this.btndel.Text = "DELETE";
            // 
            // btngetdata
            // 
            this.btngetdata.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btngetdata.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btngetdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngetdata.Location = new System.Drawing.Point(6, 145);
            this.btngetdata.Name = "btngetdata";
            this.btngetdata.Size = new System.Drawing.Size(117, 23);
            this.btngetdata.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btngetdata.TabIndex = 6;
            this.btngetdata.Text = "GET DATA";
            // 
            // cmbjurusan
            // 
            this.cmbjurusan.FormattingEnabled = true;
            this.cmbjurusan.Items.AddRange(new object[] {
            "Teknik Informatika",
            "Teknik Elektro",
            "Teknik Menis",
            "Akuntansi",
            "Hubungan Internasional"});
            this.cmbjurusan.Location = new System.Drawing.Point(201, 114);
            this.cmbjurusan.Name = "cmbjurusan";
            this.cmbjurusan.Size = new System.Drawing.Size(213, 21);
            this.cmbjurusan.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppPerkuliahan.Properties.Resources._006767_3d_transparent_glass_icon_arrows_arrows_rotated;
            this.pictureBox1.Location = new System.Drawing.Point(512, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FormMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 288);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbdatamahasiswa);
            this.Name = "FormMahasiswa";
            this.Text = "FormMahasiswa";
            this.grbdatamahasiswa.ResumeLayout(false);
            this.grbdatamahasiswa.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbdatamahasiswa;
        private System.Windows.Forms.TextBox txtkdmatkul;
        private System.Windows.Forms.TextBox txtnama;
        private System.Windows.Forms.TextBox txtnim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX btngetdata;
        private DevComponents.DotNetBar.ButtonX btndel;
        private DevComponents.DotNetBar.ButtonX btnupdate;
        private DevComponents.DotNetBar.ButtonX btnsave;
        private DevComponents.DotNetBar.ButtonX btnnew;
        private System.Windows.Forms.ComboBox cmbjurusan;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}