namespace DotNetBarApps
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
            DevComponents.DotNetBar.Metro.MetroTileFrame metroTileFrame1;
            this.metroTilePanel1 = new DevComponents.DotNetBar.Metro.MetroTilePanel();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.metroTileItem1 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem2 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem3 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem4 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.spmain = new DevComponents.DotNetBar.Controls.SlidePanel();
            this.spmenu1 = new DevComponents.DotNetBar.Controls.SlidePanel();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.spmenudua = new DevComponents.DotNetBar.Controls.SlidePanel();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.hour = new System.Windows.Forms.TextBox();
            this.minute = new System.Windows.Forms.TextBox();
            this.seconds = new System.Windows.Forms.TextBox();
            this.pesan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnpause = new System.Windows.Forms.Button();
            this.btnstop = new System.Windows.Forms.Button();
            this.paneltime = new System.Windows.Forms.Panel();
            this.lblhour = new System.Windows.Forms.Label();
            this.lblmin = new System.Windows.Forms.Label();
            this.lblsec = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnstart = new System.Windows.Forms.Button();
            this.txtplain = new System.Windows.Forms.TextBox();
            this.txtkey = new System.Windows.Forms.TextBox();
            this.txtchiper = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.reflectionLabel2 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            metroTileFrame1 = new DevComponents.DotNetBar.Metro.MetroTileFrame();
            this.spmain.SuspendLayout();
            this.spmenu1.SuspendLayout();
            this.spmenudua.SuspendLayout();
            this.paneltime.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTilePanel1
            // 
            this.metroTilePanel1.BackColor = System.Drawing.Color.DarkSlateGray;
            // 
            // 
            // 
            this.metroTilePanel1.BackgroundStyle.Class = "MetroTilePanel";
            this.metroTilePanel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTilePanel1.ContainerControlProcessDialogKey = true;
            this.metroTilePanel1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer1});
            this.metroTilePanel1.Location = new System.Drawing.Point(3, 3);
            this.metroTilePanel1.Name = "metroTilePanel1";
            this.metroTilePanel1.Size = new System.Drawing.Size(780, 421);
            this.metroTilePanel1.TabIndex = 0;
            this.metroTilePanel1.Text = "metroTilePanel1";
            this.metroTilePanel1.Click += new System.EventHandler(this.metroTilePanel1_Click);
            // 
            // itemContainer1
            // 
            // 
            // 
            // 
            this.itemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer1.MultiLine = true;
            this.itemContainer1.Name = "itemContainer1";
            this.itemContainer1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.metroTileItem1,
            this.metroTileItem2,
            this.metroTileItem3,
            this.metroTileItem4});
            // 
            // 
            // 
            this.itemContainer1.TitleStyle.Class = "MetroTileGroupTitle";
            this.itemContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer1.TitleText = "Main Menu";
            // 
            // metroTileItem1
            // 
            this.metroTileItem1.AutoRotateFramesInterval = 3000;
            this.metroTileItem1.Frames.Add(metroTileFrame1);
            this.metroTileItem1.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileItem1.Name = "metroTileItem1";
            this.metroTileItem1.Symbol = "";
            this.metroTileItem1.SymbolColor = System.Drawing.Color.White;
            this.metroTileItem1.SymbolSize = 50F;
            this.metroTileItem1.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Teal;
            this.metroTileItem1.TileSize = new System.Drawing.Size(150, 150);
            // 
            // 
            // 
            this.metroTileItem1.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTileItem1.TitleText = "GitHub";
            this.metroTileItem1.TitleTextColor = System.Drawing.Color.White;
            this.metroTileItem1.TitleTextFont = new System.Drawing.Font("Microsoft MHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTileItem1.Click += new System.EventHandler(this.metroTileItem1_Click);
            // 
            // metroTileItem2
            // 
            this.metroTileItem2.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileItem2.Name = "metroTileItem2";
            this.metroTileItem2.Symbol = "";
            this.metroTileItem2.SymbolColor = System.Drawing.Color.White;
            this.metroTileItem2.SymbolSize = 50F;
            this.metroTileItem2.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Yellow;
            this.metroTileItem2.TileSize = new System.Drawing.Size(150, 150);
            // 
            // 
            // 
            this.metroTileItem2.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTileItem2.TitleText = "Notification";
            this.metroTileItem2.TitleTextColor = System.Drawing.Color.White;
            this.metroTileItem2.TitleTextFont = new System.Drawing.Font("Microsoft MHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTileItem2.Click += new System.EventHandler(this.metroTileItem2_Click);
            // 
            // metroTileItem3
            // 
            this.metroTileItem3.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileItem3.Name = "metroTileItem3";
            this.metroTileItem3.Symbol = "";
            this.metroTileItem3.SymbolColor = System.Drawing.Color.White;
            this.metroTileItem3.SymbolSize = 50F;
            this.metroTileItem3.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Orange;
            this.metroTileItem3.TileSize = new System.Drawing.Size(150, 150);
            // 
            // 
            // 
            this.metroTileItem3.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTileItem3.TitleText = "Email";
            this.metroTileItem3.TitleTextFont = new System.Drawing.Font("Microsoft MHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTileItem3.Click += new System.EventHandler(this.metroTileItem3_Click);
            // 
            // metroTileItem4
            // 
            this.metroTileItem4.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileItem4.Name = "metroTileItem4";
            this.metroTileItem4.Symbol = "";
            this.metroTileItem4.SymbolColor = System.Drawing.Color.White;
            this.metroTileItem4.SymbolSize = 50F;
            this.metroTileItem4.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.RedOrange;
            this.metroTileItem4.TileSize = new System.Drawing.Size(150, 150);
            // 
            // 
            // 
            this.metroTileItem4.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTileItem4.TitleText = "Atom";
            this.metroTileItem4.TitleTextFont = new System.Drawing.Font("Microsoft MHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroTileFrame1
            // 
            metroTileFrame1.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            metroTileFrame1.Symbol = "";
            metroTileFrame1.SymbolSize = 50F;
            metroTileFrame1.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Blueish;
            // 
            // 
            // 
            metroTileFrame1.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            metroTileFrame1.TitleText = "Pinterest";
            metroTileFrame1.TitleTextFont = new System.Drawing.Font("Microsoft MHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // spmain
            // 
            this.spmain.Controls.Add(this.metroTilePanel1);
            this.spmain.Location = new System.Drawing.Point(0, 0);
            this.spmain.Name = "spmain";
            this.spmain.Size = new System.Drawing.Size(780, 421);
            this.spmain.TabIndex = 0;
            this.spmain.Text = "slidePanel1";
            this.spmain.UsesBlockingAnimation = false;
            // 
            // spmenu1
            // 
            this.spmenu1.BackColor = System.Drawing.Color.Moccasin;
            this.spmenu1.Controls.Add(this.btnstart);
            this.spmenu1.Controls.Add(this.paneltime);
            this.spmenu1.Controls.Add(this.btnstop);
            this.spmenu1.Controls.Add(this.btnpause);
            this.spmenu1.Controls.Add(this.label5);
            this.spmenu1.Controls.Add(this.label4);
            this.spmenu1.Controls.Add(this.label3);
            this.spmenu1.Controls.Add(this.label2);
            this.spmenu1.Controls.Add(this.label1);
            this.spmenu1.Controls.Add(this.pesan);
            this.spmenu1.Controls.Add(this.seconds);
            this.spmenu1.Controls.Add(this.minute);
            this.spmenu1.Controls.Add(this.hour);
            this.spmenu1.Controls.Add(this.buttonX1);
            this.spmenu1.Controls.Add(this.reflectionLabel1);
            this.spmenu1.Location = new System.Drawing.Point(0, 0);
            this.spmenu1.Name = "spmenu1";
            this.spmenu1.Size = new System.Drawing.Size(780, 421);
            this.spmenu1.SlideOutButtonVisible = false;
            this.spmenu1.TabIndex = 1;
            this.spmenu1.Text = " ";
            this.spmenu1.UsesBlockingAnimation = false;
            this.spmenu1.Visible = false;
            this.spmenu1.Click += new System.EventHandler(this.spmenu1_Click);
            // 
            // reflectionLabel1
            // 
            // 
            // 
            // 
            this.reflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabel1.Location = new System.Drawing.Point(6, -2);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(175, 70);
            this.reflectionLabel1.TabIndex = 0;
            this.reflectionLabel1.Text = "<b><font size=\"+6\" color=\"white\"><i>UI UX</i><font color=\"#f8f8f8f8\">Designer</fo" +
    "nt></font></b>";
            // 
            // spmenudua
            // 
            this.spmenudua.BackColor = System.Drawing.Color.Teal;
            this.spmenudua.Controls.Add(this.buttonX2);
            this.spmenudua.Controls.Add(this.reflectionLabel2);
            this.spmenudua.Controls.Add(this.button1);
            this.spmenudua.Controls.Add(this.label10);
            this.spmenudua.Controls.Add(this.label9);
            this.spmenudua.Controls.Add(this.label8);
            this.spmenudua.Controls.Add(this.txtchiper);
            this.spmenudua.Controls.Add(this.txtkey);
            this.spmenudua.Controls.Add(this.txtplain);
            this.spmenudua.Location = new System.Drawing.Point(0, 0);
            this.spmenudua.Name = "spmenudua";
            this.spmenudua.Size = new System.Drawing.Size(780, 421);
            this.spmenudua.TabIndex = 2;
            this.spmenudua.Text = "slidePanel1";
            this.spmenudua.UsesBlockingAnimation = false;
            this.spmenudua.Visible = false;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.BackColor = System.Drawing.Color.Transparent;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.buttonX1.Location = new System.Drawing.Point(722, 376);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.buttonX1.Size = new System.Drawing.Size(30, 30);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.Symbol = "";
            this.buttonX1.TabIndex = 1;
            this.buttonX1.TextColor = System.Drawing.Color.White;
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // hour
            // 
            this.hour.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hour.Location = new System.Drawing.Point(98, 105);
            this.hour.Multiline = true;
            this.hour.Name = "hour";
            this.hour.Size = new System.Drawing.Size(44, 41);
            this.hour.TabIndex = 2;
            this.hour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // minute
            // 
            this.minute.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.minute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minute.Location = new System.Drawing.Point(182, 105);
            this.minute.Multiline = true;
            this.minute.Name = "minute";
            this.minute.Size = new System.Drawing.Size(44, 41);
            this.minute.TabIndex = 3;
            this.minute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // seconds
            // 
            this.seconds.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.seconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seconds.Location = new System.Drawing.Point(266, 105);
            this.seconds.Multiline = true;
            this.seconds.Name = "seconds";
            this.seconds.Size = new System.Drawing.Size(44, 41);
            this.seconds.TabIndex = 4;
            this.seconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pesan
            // 
            this.pesan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pesan.Location = new System.Drawing.Point(98, 152);
            this.pesan.Multiline = true;
            this.pesan.Name = "pesan";
            this.pesan.Size = new System.Drawing.Size(214, 41);
            this.pesan.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Set Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Message";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "HH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(187, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "mm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(276, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "ss";
            // 
            // btnpause
            // 
            this.btnpause.BackColor = System.Drawing.Color.Orange;
            this.btnpause.FlatAppearance.BorderSize = 0;
            this.btnpause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpause.Location = new System.Drawing.Point(524, 101);
            this.btnpause.Name = "btnpause";
            this.btnpause.Size = new System.Drawing.Size(79, 59);
            this.btnpause.TabIndex = 12;
            this.btnpause.Text = "PAUSE";
            this.btnpause.UseVisualStyleBackColor = false;
            this.btnpause.Click += new System.EventHandler(this.btnpause_Click);
            // 
            // btnstop
            // 
            this.btnstop.BackColor = System.Drawing.Color.DarkOrange;
            this.btnstop.FlatAppearance.BorderSize = 0;
            this.btnstop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstop.Location = new System.Drawing.Point(623, 101);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(79, 59);
            this.btnstop.TabIndex = 13;
            this.btnstop.Text = "STOP";
            this.btnstop.UseVisualStyleBackColor = false;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // paneltime
            // 
            this.paneltime.BackColor = System.Drawing.Color.Transparent;
            this.paneltime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneltime.Controls.Add(this.label7);
            this.paneltime.Controls.Add(this.label6);
            this.paneltime.Controls.Add(this.lblsec);
            this.paneltime.Controls.Add(this.lblmin);
            this.paneltime.Controls.Add(this.lblhour);
            this.paneltime.Location = new System.Drawing.Point(98, 215);
            this.paneltime.Name = "paneltime";
            this.paneltime.Size = new System.Drawing.Size(604, 145);
            this.paneltime.TabIndex = 14;
            // 
            // lblhour
            // 
            this.lblhour.AutoSize = true;
            this.lblhour.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhour.Location = new System.Drawing.Point(50, 17);
            this.lblhour.Name = "lblhour";
            this.lblhour.Size = new System.Drawing.Size(149, 107);
            this.lblhour.TabIndex = 0;
            this.lblhour.Text = "00";
            // 
            // lblmin
            // 
            this.lblmin.AutoSize = true;
            this.lblmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmin.Location = new System.Drawing.Point(227, 19);
            this.lblmin.Name = "lblmin";
            this.lblmin.Size = new System.Drawing.Size(149, 107);
            this.lblmin.TabIndex = 1;
            this.lblmin.Text = "00";
            // 
            // lblsec
            // 
            this.lblsec.AutoSize = true;
            this.lblsec.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsec.Location = new System.Drawing.Point(408, 19);
            this.lblsec.Name = "lblsec";
            this.lblsec.Size = new System.Drawing.Size(149, 107);
            this.lblsec.TabIndex = 2;
            this.lblsec.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(174, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 107);
            this.label6.TabIndex = 3;
            this.label6.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(357, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 107);
            this.label7.TabIndex = 4;
            this.label7.Text = ":";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnstart
            // 
            this.btnstart.Location = new System.Drawing.Point(426, 101);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(80, 59);
            this.btnstart.TabIndex = 15;
            this.btnstart.Text = "START";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click_1);
            // 
            // txtplain
            // 
            this.txtplain.Location = new System.Drawing.Point(149, 113);
            this.txtplain.Multiline = true;
            this.txtplain.Name = "txtplain";
            this.txtplain.Size = new System.Drawing.Size(258, 36);
            this.txtplain.TabIndex = 0;
            // 
            // txtkey
            // 
            this.txtkey.Location = new System.Drawing.Point(149, 154);
            this.txtkey.Multiline = true;
            this.txtkey.Name = "txtkey";
            this.txtkey.Size = new System.Drawing.Size(178, 36);
            this.txtkey.TabIndex = 1;
            // 
            // txtchiper
            // 
            this.txtchiper.Location = new System.Drawing.Point(149, 195);
            this.txtchiper.Multiline = true;
            this.txtchiper.Name = "txtchiper";
            this.txtchiper.Size = new System.Drawing.Size(258, 36);
            this.txtchiper.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(52, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Plain Text";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(52, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Key";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(52, 201);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Chiper Text";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(410, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "Enkripsi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reflectionLabel2
            // 
            // 
            // 
            // 
            this.reflectionLabel2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabel2.Location = new System.Drawing.Point(3, 3);
            this.reflectionLabel2.Name = "reflectionLabel2";
            this.reflectionLabel2.Size = new System.Drawing.Size(175, 70);
            this.reflectionLabel2.TabIndex = 7;
            this.reflectionLabel2.Text = "<b><font size=\"+6\" color=\"white\"><i>UI UX</i><font color=\"#f8f8f8f8\">Designer</fo" +
    "nt></font></b>";
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.BackColor = System.Drawing.Color.Transparent;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.buttonX2.Location = new System.Drawing.Point(725, 376);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.buttonX2.Size = new System.Drawing.Size(30, 30);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.Symbol = "";
            this.buttonX2.TabIndex = 8;
            this.buttonX2.TextColor = System.Drawing.Color.White;
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 418);
            this.Controls.Add(this.spmain);
            this.Controls.Add(this.spmenudua);
            this.Controls.Add(this.spmenu1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.spmain.ResumeLayout(false);
            this.spmenu1.ResumeLayout(false);
            this.spmenu1.PerformLayout();
            this.spmenudua.ResumeLayout(false);
            this.spmenudua.PerformLayout();
            this.paneltime.ResumeLayout(false);
            this.paneltime.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Metro.MetroTilePanel metroTilePanel1;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem1;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem2;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem3;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem4;
        private DevComponents.DotNetBar.Controls.SlidePanel spmain;
        private DevComponents.DotNetBar.Controls.SlidePanel spmenu1;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        private DevComponents.DotNetBar.Controls.SlidePanel spmenudua;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.Button btnpause;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pesan;
        private System.Windows.Forms.TextBox seconds;
        private System.Windows.Forms.TextBox minute;
        private System.Windows.Forms.TextBox hour;
        private System.Windows.Forms.Panel paneltime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblsec;
        private System.Windows.Forms.Label lblmin;
        private System.Windows.Forms.Label lblhour;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnstart;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtchiper;
        private System.Windows.Forms.TextBox txtkey;
        private System.Windows.Forms.TextBox txtplain;
    }
}

