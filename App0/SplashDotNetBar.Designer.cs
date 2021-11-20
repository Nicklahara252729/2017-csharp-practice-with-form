namespace App0
{
    partial class SplashDotNetBar
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
            this.cirPog = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblnotif = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cirPog
            // 
            // 
            // 
            // 
            this.cirPog.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cirPog.Location = new System.Drawing.Point(30, 3);
            this.cirPog.Name = "cirPog";
            this.cirPog.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Donut;
            this.cirPog.ProgressColor = System.Drawing.Color.Crimson;
            this.cirPog.ProgressTextVisible = true;
            this.cirPog.Size = new System.Drawing.Size(201, 218);
            this.cirPog.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.cirPog.TabIndex = 0;
            this.cirPog.TabStop = false;
            this.cirPog.ValueChanged += new System.EventHandler(this.cirPog_ValueChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblnotif
            // 
            this.lblnotif.AutoSize = true;
            this.lblnotif.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnotif.Location = new System.Drawing.Point(55, 224);
            this.lblnotif.Name = "lblnotif";
            this.lblnotif.Size = new System.Drawing.Size(127, 25);
            this.lblnotif.TabIndex = 1;
            this.lblnotif.Text = "Connecting...";
            this.lblnotif.Click += new System.EventHandler(this.lblnotif_Click);
            // 
            // SplashDotNetBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblnotif);
            this.Controls.Add(this.cirPog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashDotNetBar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashDotNetBar";
            this.Load += new System.EventHandler(this.SplashDotNetBar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.CircularProgress cirPog;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblnotif;
    }
}