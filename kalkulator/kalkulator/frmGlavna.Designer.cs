namespace kalkulator
{
    partial class frmGlavna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGlavna));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbLosKlijent = new System.Windows.Forms.RadioButton();
            this.rdbDobarKlijent = new System.Windows.Forms.RadioButton();
            this.rdbOdlicanKlijent = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.meniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lblVrijeme = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbIznosKredita = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.tbBrojMjeseci = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMjesecnaRata = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUkupnoZaduzenje = new System.Windows.Forms.Label();
            this.txtIznosKredita = new System.Windows.Forms.TextBox();
            this.txtUkupnaKamata = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtBrojMjeseci = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.podesavanjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazIzAplikacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbIznosKredita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBrojMjeseci)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rdbLosKlijent);
            this.groupBox1.Controls.Add(this.rdbDobarKlijent);
            this.groupBox1.Controls.Add(this.rdbOdlicanKlijent);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vrsta klijenta(Kamatna stopa)";
            // 
            // rdbLosKlijent
            // 
            this.rdbLosKlijent.AutoSize = true;
            this.rdbLosKlijent.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbLosKlijent.Location = new System.Drawing.Point(6, 71);
            this.rdbLosKlijent.Name = "rdbLosKlijent";
            this.rdbLosKlijent.Size = new System.Drawing.Size(221, 21);
            this.rdbLosKlijent.TabIndex = 2;
            this.rdbLosKlijent.TabStop = true;
            this.rdbLosKlijent.Text = "Los klijent(Kamatna stopa 6%)";
            this.rdbLosKlijent.UseVisualStyleBackColor = true;
            this.rdbLosKlijent.CheckedChanged += new System.EventHandler(this.rdbLosKlijent_CheckedChanged);
            // 
            // rdbDobarKlijent
            // 
            this.rdbDobarKlijent.AutoSize = true;
            this.rdbDobarKlijent.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDobarKlijent.Location = new System.Drawing.Point(6, 46);
            this.rdbDobarKlijent.Name = "rdbDobarKlijent";
            this.rdbDobarKlijent.Size = new System.Drawing.Size(235, 21);
            this.rdbDobarKlijent.TabIndex = 1;
            this.rdbDobarKlijent.TabStop = true;
            this.rdbDobarKlijent.Text = "Dobar klijent(kamatna stopa 5%)";
            this.rdbDobarKlijent.UseVisualStyleBackColor = true;
            this.rdbDobarKlijent.CheckedChanged += new System.EventHandler(this.rdbDobarKlijent_CheckedChanged);
            // 
            // rdbOdlicanKlijent
            // 
            this.rdbOdlicanKlijent.AutoSize = true;
            this.rdbOdlicanKlijent.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbOdlicanKlijent.Location = new System.Drawing.Point(6, 21);
            this.rdbOdlicanKlijent.Name = "rdbOdlicanKlijent";
            this.rdbOdlicanKlijent.Size = new System.Drawing.Size(246, 21);
            this.rdbOdlicanKlijent.TabIndex = 0;
            this.rdbOdlicanKlijent.TabStop = true;
            this.rdbOdlicanKlijent.Text = "Odlican klijent(Kamatna stopa 3%)";
            this.rdbOdlicanKlijent.UseVisualStyleBackColor = true;
            this.rdbOdlicanKlijent.CheckedChanged += new System.EventHandler(this.rdbOdlicanKlijent_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meniToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(778, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // meniToolStripMenuItem
            // 
            this.meniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.podesavanjaToolStripMenuItem,
            this.toolStripSeparator1,
            this.izlazIzAplikacijeToolStripMenuItem});
            this.meniToolStripMenuItem.Name = "meniToolStripMenuItem";
            this.meniToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.meniToolStripMenuItem.Text = "Meni";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(187, 6);
            // 
            // lblVrijeme
            // 
            this.lblVrijeme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVrijeme.AutoSize = true;
            this.lblVrijeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVrijeme.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblVrijeme.Location = new System.Drawing.Point(579, 52);
            this.lblVrijeme.Margin = new System.Windows.Forms.Padding(15, 0, 3, 0);
            this.lblVrijeme.Name = "lblVrijeme";
            this.lblVrijeme.Size = new System.Drawing.Size(98, 29);
            this.lblVrijeme.TabIndex = 2;
            this.lblVrijeme.Text = "vrijeme ";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbIznosKredita, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbBrojMjeseci, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtMjesecnaRata, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtUkupnoZaduzenje, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtUkupnaKamata, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtIznosKredita, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtBrojMjeseci, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 167);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(766, 203);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(109, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ukupan iznos kredita";
            // 
            // tbIznosKredita
            // 
            this.tbIznosKredita.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbIznosKredita.LargeChange = 1000;
            this.tbIznosKredita.Location = new System.Drawing.Point(3, 43);
            this.tbIznosKredita.Name = "tbIznosKredita";
            this.tbIznosKredita.Size = new System.Drawing.Size(377, 54);
            this.tbIznosKredita.SmallChange = 100;
            this.tbIznosKredita.TabIndex = 4;
            this.tbIznosKredita.TickFrequency = 1000;
            this.tbIznosKredita.Scroll += new System.EventHandler(this.tbIznosKredita_Scroll);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label6.Location = new System.Drawing.Point(702, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 30);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ukupno\r\nkamate";
            // 
            // tbBrojMjeseci
            // 
            this.tbBrojMjeseci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbBrojMjeseci.LargeChange = 12;
            this.tbBrojMjeseci.Location = new System.Drawing.Point(3, 143);
            this.tbBrojMjeseci.Name = "tbBrojMjeseci";
            this.tbBrojMjeseci.Size = new System.Drawing.Size(377, 57);
            this.tbBrojMjeseci.SmallChange = 6;
            this.tbBrojMjeseci.TabIndex = 1;
            this.tbBrojMjeseci.Scroll += new System.EventHandler(this.tbBrojMjeseci_Scroll);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(137, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Broj mjeseci \r\n";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label3, 3);
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label3.Location = new System.Drawing.Point(557, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Iznos mjesecne rate ";
            // 
            // txtMjesecnaRata
            // 
            this.txtMjesecnaRata.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMjesecnaRata.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.txtMjesecnaRata, 3);
            this.txtMjesecnaRata.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMjesecnaRata.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.txtMjesecnaRata.Location = new System.Drawing.Point(598, 60);
            this.txtMjesecnaRata.Margin = new System.Windows.Forms.Padding(12, 0, 10, 0);
            this.txtMjesecnaRata.Name = "txtMjesecnaRata";
            this.txtMjesecnaRata.Size = new System.Drawing.Size(85, 20);
            this.txtMjesecnaRata.TabIndex = 6;
            this.txtMjesecnaRata.Text = "304,22 km";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label5.Location = new System.Drawing.Point(526, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ukupno zaduzenje";
            // 
            // txtUkupnoZaduzenje
            // 
            this.txtUkupnoZaduzenje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUkupnoZaduzenje.AutoSize = true;
            this.txtUkupnoZaduzenje.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUkupnoZaduzenje.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.txtUkupnoZaduzenje.Location = new System.Drawing.Point(541, 164);
            this.txtUkupnoZaduzenje.Name = "txtUkupnoZaduzenje";
            this.txtUkupnoZaduzenje.Size = new System.Drawing.Size(81, 15);
            this.txtUkupnoZaduzenje.TabIndex = 15;
            this.txtUkupnoZaduzenje.Text = "10951,90 KM\r\n";
            // 
            // txtIznosKredita
            // 
            this.txtIznosKredita.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtIznosKredita.Location = new System.Drawing.Point(391, 45);
            this.txtIznosKredita.Margin = new System.Windows.Forms.Padding(0, 5, 7, 22);
            this.txtIznosKredita.Multiline = true;
            this.txtIznosKredita.Name = "txtIznosKredita";
            this.txtIznosKredita.ReadOnly = true;
            this.txtIznosKredita.Size = new System.Drawing.Size(106, 33);
            this.txtIznosKredita.TabIndex = 2;
            // 
            // txtUkupnaKamata
            // 
            this.txtUkupnaKamata.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUkupnaKamata.AutoSize = true;
            this.txtUkupnaKamata.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUkupnaKamata.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.txtUkupnaKamata.Location = new System.Drawing.Point(700, 164);
            this.txtUkupnaKamata.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtUkupnaKamata.Name = "txtUkupnaKamata";
            this.txtUkupnaKamata.Size = new System.Drawing.Size(53, 15);
            this.txtUkupnaKamata.TabIndex = 16;
            this.txtUkupnaKamata.Text = "0,00 KM\r\n";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtBrojMjeseci
            // 
            this.txtBrojMjeseci.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBrojMjeseci.Location = new System.Drawing.Point(391, 145);
            this.txtBrojMjeseci.Margin = new System.Windows.Forms.Padding(0, 5, 7, 22);
            this.txtBrojMjeseci.Multiline = true;
            this.txtBrojMjeseci.Name = "txtBrojMjeseci";
            this.txtBrojMjeseci.ReadOnly = true;
            this.txtBrojMjeseci.Size = new System.Drawing.Size(106, 33);
            this.txtBrojMjeseci.TabIndex = 17;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblVrijeme, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 24);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(754, 134);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // podesavanjaToolStripMenuItem
            // 
            this.podesavanjaToolStripMenuItem.Image = global::kalkulator.Properties.Resources.MeniPodesavanja;
            this.podesavanjaToolStripMenuItem.Name = "podesavanjaToolStripMenuItem";
            this.podesavanjaToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.podesavanjaToolStripMenuItem.Text = "Podesavanja";
            this.podesavanjaToolStripMenuItem.Click += new System.EventHandler(this.podesavanjaToolStripMenuItem_Click);
            // 
            // izlazIzAplikacijeToolStripMenuItem
            // 
            this.izlazIzAplikacijeToolStripMenuItem.Image = global::kalkulator.Properties.Resources.MeniIzlaz;
            this.izlazIzAplikacijeToolStripMenuItem.Name = "izlazIzAplikacijeToolStripMenuItem";
            this.izlazIzAplikacijeToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.izlazIzAplikacijeToolStripMenuItem.Text = "Izlaz iz aplikacije";
            this.izlazIzAplikacijeToolStripMenuItem.Click += new System.EventHandler(this.izlazIzAplikacijeToolStripMenuItem_Click);
            // 
            // frmGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 382);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(996, 550);
            this.MinimumSize = new System.Drawing.Size(696, 395);
            this.Name = "frmGlavna";
            this.Text = "Kreditni kalkulator by Petar Petrovic";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbIznosKredita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBrojMjeseci)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbLosKlijent;
        private System.Windows.Forms.RadioButton rdbDobarKlijent;
        private System.Windows.Forms.RadioButton rdbOdlicanKlijent;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem meniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem podesavanjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem izlazIzAplikacijeToolStripMenuItem;
        private System.Windows.Forms.Label lblVrijeme;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar tbBrojMjeseci;
        private System.Windows.Forms.TextBox txtIznosKredita;
        private System.Windows.Forms.TrackBar tbIznosKredita;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtMjesecnaRata;
        private System.Windows.Forms.Label txtUkupnoZaduzenje;
        private System.Windows.Forms.Label txtUkupnaKamata;
        private System.Windows.Forms.TextBox txtBrojMjeseci;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}

