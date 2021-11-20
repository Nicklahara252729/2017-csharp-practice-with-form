namespace LatihanFormSatu
{
    partial class convert
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
            this.txtwarna = new System.Windows.Forms.TextBox();
            this.btnconvert = new System.Windows.Forms.Button();
            this.btnhasil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtwarna
            // 
            this.txtwarna.Location = new System.Drawing.Point(58, 36);
            this.txtwarna.Name = "txtwarna";
            this.txtwarna.Size = new System.Drawing.Size(100, 20);
            this.txtwarna.TabIndex = 0;
            // 
            // btnconvert
            // 
            this.btnconvert.Location = new System.Drawing.Point(71, 87);
            this.btnconvert.Name = "btnconvert";
            this.btnconvert.Size = new System.Drawing.Size(75, 23);
            this.btnconvert.TabIndex = 1;
            this.btnconvert.Text = "Convert";
            this.btnconvert.UseVisualStyleBackColor = true;
            this.btnconvert.Click += new System.EventHandler(this.btnconvert_Click);
            // 
            // btnhasil
            // 
            this.btnhasil.Location = new System.Drawing.Point(43, 135);
            this.btnhasil.Name = "btnhasil";
            this.btnhasil.Size = new System.Drawing.Size(134, 83);
            this.btnhasil.TabIndex = 2;
            this.btnhasil.UseVisualStyleBackColor = true;
            // 
            // convert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 287);
            this.Controls.Add(this.btnhasil);
            this.Controls.Add(this.btnconvert);
            this.Controls.Add(this.txtwarna);
            this.Name = "convert";
            this.Text = "convert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtwarna;
        private System.Windows.Forms.Button btnconvert;
        private System.Windows.Forms.Button btnhasil;
    }
}