namespace App3
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btndashboard = new DevComponents.DotNetBar.ButtonX();
            this.btndokter = new DevComponents.DotNetBar.ButtonX();
            this.btnobat = new DevComponents.DotNetBar.ButtonX();
            this.pnlobt = new DevComponents.DotNetBar.PanelEx();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.ClmKdObat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmNmObat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmJenis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmJumlah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.jenis = new System.Windows.Forms.ComboBox();
            this.jumlah = new System.Windows.Forms.TextBox();
            this.kodeobat = new System.Windows.Forms.TextBox();
            this.namaobat = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.pnldokter = new DevComponents.DotNetBar.PanelEx();
            this.progbar = new System.Windows.Forms.ProgressBar();
            this.lbdokter = new System.Windows.Forms.ListBox();
            this.add = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.ComboBox();
            this.other = new System.Windows.Forms.CheckBox();
            this.anak = new System.Windows.Forms.CheckBox();
            this.bedah = new System.Windows.Forms.CheckBox();
            this.woman = new System.Windows.Forms.RadioButton();
            this.man = new System.Windows.Forms.RadioButton();
            this.txtnama = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtid = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.timer1 = new System.Windows.Forms.Timer();
            this.home = new System.Windows.Forms.Panel();
            this.pnlobt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.pnldokter.SuspendLayout();
            this.SuspendLayout();
            // 
            // btndashboard
            // 
            this.btndashboard.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btndashboard.BackColor = System.Drawing.Color.Crimson;
            this.btndashboard.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btndashboard.Cursor = System.Windows.Forms.Cursors.Default;
            this.btndashboard.Font = new System.Drawing.Font("Microsoft MHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndashboard.Location = new System.Drawing.Point(29, 15);
            this.btndashboard.Name = "btndashboard";
            this.btndashboard.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btndashboard.Size = new System.Drawing.Size(126, 51);
            this.btndashboard.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btndashboard.Symbol = "";
            this.btndashboard.TabIndex = 0;
            this.btndashboard.Text = "Dashboard";
            this.btndashboard.TextColor = System.Drawing.Color.White;
            this.btndashboard.Click += new System.EventHandler(this.btndashboard_Click);
            // 
            // btndokter
            // 
            this.btndokter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btndokter.BackColor = System.Drawing.Color.Crimson;
            this.btndokter.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btndokter.Font = new System.Drawing.Font("Microsoft MHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndokter.Location = new System.Drawing.Point(161, 15);
            this.btndokter.Name = "btndokter";
            this.btndokter.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btndokter.Size = new System.Drawing.Size(128, 51);
            this.btndokter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btndokter.Symbol = "";
            this.btndokter.TabIndex = 1;
            this.btndokter.Text = "Data Dokter";
            this.btndokter.TextColor = System.Drawing.Color.White;
            this.btndokter.Click += new System.EventHandler(this.btndokter_Click);
            // 
            // btnobat
            // 
            this.btnobat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnobat.BackColor = System.Drawing.Color.Crimson;
            this.btnobat.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnobat.Font = new System.Drawing.Font("Microsoft MHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnobat.Location = new System.Drawing.Point(296, 15);
            this.btnobat.Name = "btnobat";
            this.btnobat.Size = new System.Drawing.Size(139, 51);
            this.btnobat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnobat.Symbol = "";
            this.btnobat.TabIndex = 2;
            this.btnobat.Text = "Data Obat";
            this.btnobat.TextColor = System.Drawing.Color.White;
            this.btnobat.Click += new System.EventHandler(this.btnobat_Click);
            // 
            // pnlobt
            // 
            this.pnlobt.CanvasColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlobt.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.pnlobt.Controls.Add(this.Grid);
            this.pnlobt.Controls.Add(this.delete);
            this.pnlobt.Controls.Add(this.update);
            this.pnlobt.Controls.Add(this.insert);
            this.pnlobt.Controls.Add(this.jenis);
            this.pnlobt.Controls.Add(this.jumlah);
            this.pnlobt.Controls.Add(this.kodeobat);
            this.pnlobt.Controls.Add(this.namaobat);
            this.pnlobt.Controls.Add(this.label12);
            this.pnlobt.Controls.Add(this.label11);
            this.pnlobt.Controls.Add(this.label10);
            this.pnlobt.Controls.Add(this.label9);
            this.pnlobt.Controls.Add(this.label8);
            this.pnlobt.Location = new System.Drawing.Point(0, 72);
            this.pnlobt.Name = "pnlobt";
            this.pnlobt.Size = new System.Drawing.Size(473, 475);
            this.pnlobt.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlobt.Style.BackColor1.Color = System.Drawing.Color.Gainsboro;
            this.pnlobt.Style.BackColor2.Color = System.Drawing.Color.Gainsboro;
            this.pnlobt.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlobt.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlobt.Style.GradientAngle = 90;
            this.pnlobt.TabIndex = 6;
            this.pnlobt.Visible = false;
            // 
            // Grid
            // 
            this.Grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft MHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmKdObat,
            this.ClmNmObat,
            this.ClmJenis,
            this.ClmJumlah});
            this.Grid.Location = new System.Drawing.Point(17, 234);
            this.Grid.Name = "Grid";
            this.Grid.Size = new System.Drawing.Size(436, 176);
            this.Grid.TabIndex = 12;
            this.Grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellClick);
            this.Grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellContentClick);
            this.Grid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Grid_RowHeaderMouseClick);
            // 
            // ClmKdObat
            // 
            this.ClmKdObat.HeaderText = "Kode Obat";
            this.ClmKdObat.Name = "ClmKdObat";
            // 
            // ClmNmObat
            // 
            this.ClmNmObat.HeaderText = "Nama Obat";
            this.ClmNmObat.Name = "ClmNmObat";
            // 
            // ClmJenis
            // 
            this.ClmJenis.HeaderText = "Jenis";
            this.ClmJenis.Name = "ClmJenis";
            // 
            // ClmJumlah
            // 
            this.ClmJumlah.HeaderText = "Jumlah";
            this.ClmJumlah.Name = "ClmJumlah";
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Orange;
            this.delete.FlatAppearance.BorderSize = 0;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Location = new System.Drawing.Point(229, 195);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(88, 33);
            this.delete.TabIndex = 11;
            this.delete.Text = "DELETE";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.White;
            this.update.FlatAppearance.BorderSize = 0;
            this.update.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Location = new System.Drawing.Point(136, 195);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(88, 33);
            this.update.TabIndex = 10;
            this.update.Text = "UPDATE";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.button2_Click);
            // 
            // insert
            // 
            this.insert.BackColor = System.Drawing.Color.Crimson;
            this.insert.FlatAppearance.BorderSize = 0;
            this.insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insert.ForeColor = System.Drawing.Color.White;
            this.insert.Location = new System.Drawing.Point(44, 195);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(88, 33);
            this.insert.TabIndex = 9;
            this.insert.Text = "INSERT";
            this.insert.UseVisualStyleBackColor = false;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // jenis
            // 
            this.jenis.FormattingEnabled = true;
            this.jenis.Items.AddRange(new object[] {
            "Tablet",
            "Cair",
            "Gel",
            "Krim"});
            this.jenis.Location = new System.Drawing.Point(152, 115);
            this.jenis.Name = "jenis";
            this.jenis.Size = new System.Drawing.Size(159, 21);
            this.jenis.TabIndex = 8;
            // 
            // jumlah
            // 
            this.jumlah.Location = new System.Drawing.Point(152, 148);
            this.jumlah.Name = "jumlah";
            this.jumlah.Size = new System.Drawing.Size(159, 20);
            this.jumlah.TabIndex = 7;
            // 
            // kodeobat
            // 
            this.kodeobat.Location = new System.Drawing.Point(152, 53);
            this.kodeobat.Name = "kodeobat";
            this.kodeobat.Size = new System.Drawing.Size(159, 20);
            this.kodeobat.TabIndex = 6;
            // 
            // namaobat
            // 
            this.namaobat.Location = new System.Drawing.Point(152, 84);
            this.namaobat.Name = "namaobat";
            this.namaobat.Size = new System.Drawing.Size(159, 20);
            this.namaobat.TabIndex = 5;
            this.namaobat.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(48, 148);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 17);
            this.label12.TabIndex = 4;
            this.label12.Text = "Jumlah";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(48, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 17);
            this.label11.TabIndex = 3;
            this.label11.Text = "Jenis";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(48, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Nama Obat";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(48, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Kode Obat";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "DATA OBAT";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(20, 15);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(107, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Data Dokter";
            // 
            // pnldokter
            // 
            this.pnldokter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnldokter.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnldokter.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnldokter.Controls.Add(this.progbar);
            this.pnldokter.Controls.Add(this.lbdokter);
            this.pnldokter.Controls.Add(this.add);
            this.pnldokter.Controls.Add(this.label7);
            this.pnldokter.Controls.Add(this.label6);
            this.pnldokter.Controls.Add(this.label5);
            this.pnldokter.Controls.Add(this.label4);
            this.pnldokter.Controls.Add(this.label3);
            this.pnldokter.Controls.Add(this.status);
            this.pnldokter.Controls.Add(this.other);
            this.pnldokter.Controls.Add(this.anak);
            this.pnldokter.Controls.Add(this.bedah);
            this.pnldokter.Controls.Add(this.woman);
            this.pnldokter.Controls.Add(this.man);
            this.pnldokter.Controls.Add(this.txtnama);
            this.pnldokter.Controls.Add(this.txtid);
            this.pnldokter.Controls.Add(this.labelX1);
            this.pnldokter.Location = new System.Drawing.Point(0, 72);
            this.pnldokter.Name = "pnldokter";
            this.pnldokter.Size = new System.Drawing.Size(473, 475);
            this.pnldokter.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnldokter.Style.BackColor1.Color = System.Drawing.Color.Gainsboro;
            this.pnldokter.Style.BackColor2.Color = System.Drawing.Color.Gainsboro;
            this.pnldokter.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnldokter.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnldokter.Style.GradientAngle = 90;
            this.pnldokter.TabIndex = 3;
            this.pnldokter.Text = " ";
            this.pnldokter.Visible = false;
            // 
            // progbar
            // 
            this.progbar.BackColor = System.Drawing.Color.White;
            this.progbar.ForeColor = System.Drawing.Color.Crimson;
            this.progbar.Location = new System.Drawing.Point(66, 417);
            this.progbar.Name = "progbar";
            this.progbar.Size = new System.Drawing.Size(337, 25);
            this.progbar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progbar.TabIndex = 17;
            // 
            // lbdokter
            // 
            this.lbdokter.FormattingEnabled = true;
            this.lbdokter.Location = new System.Drawing.Point(65, 287);
            this.lbdokter.Name = "lbdokter";
            this.lbdokter.Size = new System.Drawing.Size(338, 121);
            this.lbdokter.TabIndex = 16;
            this.lbdokter.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.Crimson;
            this.add.FlatAppearance.BorderSize = 0;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.ForeColor = System.Drawing.Color.White;
            this.add.Location = new System.Drawing.Point(178, 246);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 15;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(78, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "KOMBO BOX";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(93, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "SPESIALIS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(69, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "JENIS KELAMIN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(116, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "NAMA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(134, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "ID";
            // 
            // status
            // 
            this.status.FormattingEnabled = true;
            this.status.Items.AddRange(new object[] {
            "Menikah",
            "Belum Menikah",
            "Single",
            "Jomblo",
            "Single Parent"});
            this.status.Location = new System.Drawing.Point(178, 208);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(204, 21);
            this.status.TabIndex = 9;
            // 
            // other
            // 
            this.other.AutoSize = true;
            this.other.Location = new System.Drawing.Point(178, 172);
            this.other.Name = "other";
            this.other.Size = new System.Drawing.Size(71, 17);
            this.other.TabIndex = 8;
            this.other.Text = "Lain - lain";
            this.other.UseVisualStyleBackColor = true;
            // 
            // anak
            // 
            this.anak.AutoSize = true;
            this.anak.Location = new System.Drawing.Point(282, 149);
            this.anak.Name = "anak";
            this.anak.Size = new System.Drawing.Size(51, 17);
            this.anak.TabIndex = 7;
            this.anak.Text = "Anak";
            this.anak.UseVisualStyleBackColor = true;
            // 
            // bedah
            // 
            this.bedah.AutoSize = true;
            this.bedah.Location = new System.Drawing.Point(178, 149);
            this.bedah.Name = "bedah";
            this.bedah.Size = new System.Drawing.Size(57, 17);
            this.bedah.TabIndex = 6;
            this.bedah.Text = "Bedah";
            this.bedah.UseVisualStyleBackColor = true;
            // 
            // woman
            // 
            this.woman.AutoSize = true;
            this.woman.Location = new System.Drawing.Point(282, 113);
            this.woman.Name = "woman";
            this.woman.Size = new System.Drawing.Size(59, 17);
            this.woman.TabIndex = 5;
            this.woman.TabStop = true;
            this.woman.Text = "Wanita";
            this.woman.UseVisualStyleBackColor = true;
            // 
            // man
            // 
            this.man.AutoSize = true;
            this.man.Location = new System.Drawing.Point(178, 113);
            this.man.Name = "man";
            this.man.Size = new System.Drawing.Size(70, 17);
            this.man.TabIndex = 4;
            this.man.TabStop = true;
            this.man.Text = "Laki - laki";
            this.man.UseVisualStyleBackColor = true;
            // 
            // txtnama
            // 
            // 
            // 
            // 
            this.txtnama.Border.Class = "TextBoxBorder";
            this.txtnama.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtnama.Location = new System.Drawing.Point(178, 70);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(204, 20);
            this.txtnama.TabIndex = 3;
            // 
            // txtid
            // 
            // 
            // 
            // 
            this.txtid.Border.Class = "TextBoxBorder";
            this.txtid.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtid.Location = new System.Drawing.Point(178, 44);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(148, 20);
            this.txtid.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.Transparent;
            this.home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("home.BackgroundImage")));
            this.home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.home.Location = new System.Drawing.Point(0, 72);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(473, 475);
            this.home.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(470, 542);
            this.Controls.Add(this.pnlobt);
            this.Controls.Add(this.home);
            this.Controls.Add(this.pnldokter);
            this.Controls.Add(this.btnobat);
            this.Controls.Add(this.btndokter);
            this.Controls.Add(this.btndashboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlobt.ResumeLayout(false);
            this.pnlobt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.pnldokter.ResumeLayout(false);
            this.pnldokter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btndashboard;
        private DevComponents.DotNetBar.ButtonX btndokter;
        private DevComponents.DotNetBar.ButtonX btnobat;
        private DevComponents.DotNetBar.PanelEx pnlobt;
        private DevComponents.DotNetBar.PanelEx pnldokter;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox status;
        private System.Windows.Forms.CheckBox other;
        private System.Windows.Forms.CheckBox anak;
        private System.Windows.Forms.CheckBox bedah;
        private System.Windows.Forms.RadioButton woman;
        private System.Windows.Forms.RadioButton man;
        private DevComponents.DotNetBar.Controls.TextBoxX txtnama;
        private DevComponents.DotNetBar.Controls.TextBoxX txtid;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.ListBox lbdokter;
        private System.Windows.Forms.ProgressBar progbar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox namaobat;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.ComboBox jenis;
        private System.Windows.Forms.TextBox jumlah;
        private System.Windows.Forms.TextBox kodeobat;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmKdObat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmNmObat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmJenis;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmJumlah;
        private System.Windows.Forms.Panel home;
    }
}

