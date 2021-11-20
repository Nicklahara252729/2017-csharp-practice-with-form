namespace LatihanGrade
{
    partial class proses
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
            this.pros = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblproses = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pros
            // 
            this.pros.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            // 
            // 
            // 
            this.pros.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pros.Location = new System.Drawing.Point(25, 8);
            this.pros.Name = "pros";
            this.pros.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Donut;
            this.pros.ProgressColor = System.Drawing.Color.Crimson;
            this.pros.ProgressTextVisible = true;
            this.pros.Size = new System.Drawing.Size(232, 220);
            this.pros.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.pros.TabIndex = 0;
            this.pros.TabStop = false;
            this.pros.ValueChanged += new System.EventHandler(this.pros_ValueChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblproses
            // 
            this.lblproses.AutoSize = true;
            this.lblproses.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproses.Location = new System.Drawing.Point(97, 243);
            this.lblproses.Name = "lblproses";
            this.lblproses.Size = new System.Drawing.Size(94, 22);
            this.lblproses.TabIndex = 1;
            this.lblproses.Text = "Loading....";
            // 
            // proses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 271);
            this.Controls.Add(this.lblproses);
            this.Controls.Add(this.pros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "proses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "proses";
            this.Load += new System.EventHandler(this.proses_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.CircularProgress pros;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblproses;
    }
}