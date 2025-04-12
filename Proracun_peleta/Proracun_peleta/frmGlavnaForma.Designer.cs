namespace Proracun_peleta
{
    partial class frmGlavnaForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGlavnaForma));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.meniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.podesavanja = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.izlazIzAplikacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPotrosnjaDan = new System.Windows.Forms.Label();
            this.lblPotrosnjaSat = new System.Windows.Forms.Label();
            this.lblSnaga = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIzracunaj = new System.Windows.Forms.Button();
            this.txtBrojSati = new System.Windows.Forms.TextBox();
            this.cmbIzaberiSnagu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblVrijeme = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meniToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(507, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // meniToolStripMenuItem
            // 
            this.meniToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.meniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.podesavanja,
            this.toolStripSeparator1,
            this.izlazIzAplikacijeToolStripMenuItem});
            this.meniToolStripMenuItem.Name = "meniToolStripMenuItem";
            this.meniToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.meniToolStripMenuItem.Text = "Meni";
            // 
            // podesavanja
            // 
            this.podesavanja.Image = global::Proracun_peleta.Properties.Resources.MeniPodesavanja;
            this.podesavanja.Name = "podesavanja";
            this.podesavanja.Size = new System.Drawing.Size(190, 24);
            this.podesavanja.Text = "Podesavanja";
            this.podesavanja.Click += new System.EventHandler(this.podesavanja_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(187, 6);
            // 
            // izlazIzAplikacijeToolStripMenuItem
            // 
            this.izlazIzAplikacijeToolStripMenuItem.Image = global::Proracun_peleta.Properties.Resources.MeniIzlaz;
            this.izlazIzAplikacijeToolStripMenuItem.Name = "izlazIzAplikacijeToolStripMenuItem";
            this.izlazIzAplikacijeToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.izlazIzAplikacijeToolStripMenuItem.Text = "Izlaz iz aplikacije";
            this.izlazIzAplikacijeToolStripMenuItem.Click += new System.EventHandler(this.izlazIzAplikacijeToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 3);
            this.groupBox1.Controls.Add(this.lblPotrosnjaDan);
            this.groupBox1.Controls.Add(this.lblPotrosnjaSat);
            this.groupBox1.Controls.Add(this.lblSnaga);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(10, 79);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10, 5, 12, 0);
            this.groupBox1.Name = "groupBox1";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox1, 3);
            this.groupBox1.Size = new System.Drawing.Size(485, 169);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci o snazi i potrosnji";
            // 
            // lblPotrosnjaDan
            // 
            this.lblPotrosnjaDan.AutoSize = true;
            this.lblPotrosnjaDan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPotrosnjaDan.ForeColor = System.Drawing.Color.YellowGreen;
            this.lblPotrosnjaDan.Location = new System.Drawing.Point(153, 105);
            this.lblPotrosnjaDan.Name = "lblPotrosnjaDan";
            this.lblPotrosnjaDan.Size = new System.Drawing.Size(94, 20);
            this.lblPotrosnjaDan.TabIndex = 5;
            this.lblPotrosnjaDan.Text = "0.00 kg/dan";
            // 
            // lblPotrosnjaSat
            // 
            this.lblPotrosnjaSat.AutoSize = true;
            this.lblPotrosnjaSat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPotrosnjaSat.ForeColor = System.Drawing.Color.YellowGreen;
            this.lblPotrosnjaSat.Location = new System.Drawing.Point(153, 74);
            this.lblPotrosnjaSat.Name = "lblPotrosnjaSat";
            this.lblPotrosnjaSat.Size = new System.Drawing.Size(76, 20);
            this.lblPotrosnjaSat.TabIndex = 4;
            this.lblPotrosnjaSat.Text = "0.00 kg/h";
            // 
            // lblSnaga
            // 
            this.lblSnaga.AutoSize = true;
            this.lblSnaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSnaga.ForeColor = System.Drawing.Color.YellowGreen;
            this.lblSnaga.Location = new System.Drawing.Point(153, 43);
            this.lblSnaga.Name = "lblSnaga";
            this.lblSnaga.Size = new System.Drawing.Size(78, 20);
            this.lblSnaga.TabIndex = 3;
            this.lblSnaga.Text = "0.00 kWh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Brown;
            this.label5.Location = new System.Drawing.Point(7, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Potrosnja kg/dan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(28, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Potrosnja kg/h";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(47, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Snaga kWh";
            // 
            // btnIzracunaj
            // 
            this.btnIzracunaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIzracunaj.BackColor = System.Drawing.Color.White;
            this.btnIzracunaj.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnIzracunaj.FlatAppearance.BorderSize = 2;
            this.btnIzracunaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzracunaj.Location = new System.Drawing.Point(328, 23);
            this.btnIzracunaj.Margin = new System.Windows.Forms.Padding(25, 18, 12, 3);
            this.btnIzracunaj.Name = "btnIzracunaj";
            this.tableLayoutPanel1.SetRowSpan(this.btnIzracunaj, 2);
            this.btnIzracunaj.Size = new System.Drawing.Size(167, 42);
            this.btnIzracunaj.TabIndex = 2;
            this.btnIzracunaj.Text = "Izracunaj";
            this.btnIzracunaj.UseVisualStyleBackColor = false;
            this.btnIzracunaj.Click += new System.EventHandler(this.btnIzracunaj_Click);
            // 
            // txtBrojSati
            // 
            this.txtBrojSati.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBrojSati.Location = new System.Drawing.Point(151, 40);
            this.txtBrojSati.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.txtBrojSati.Multiline = true;
            this.txtBrojSati.Name = "txtBrojSati";
            this.txtBrojSati.Size = new System.Drawing.Size(137, 24);
            this.txtBrojSati.TabIndex = 1;
            this.txtBrojSati.TextChanged += new System.EventHandler(this.cmbIzaberiSnagu_TextChanged);
            // 
            // cmbIzaberiSnagu
            // 
            this.cmbIzaberiSnagu.BackColor = System.Drawing.Color.White;
            this.cmbIzaberiSnagu.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbIzaberiSnagu.FormattingEnabled = true;
            this.cmbIzaberiSnagu.Items.AddRange(new object[] {
            "P1",
            "P2",
            "P3"});
            this.cmbIzaberiSnagu.Location = new System.Drawing.Point(10, 40);
            this.cmbIzaberiSnagu.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.cmbIzaberiSnagu.Name = "cmbIzaberiSnagu";
            this.cmbIzaberiSnagu.Size = new System.Drawing.Size(103, 24);
            this.cmbIzaberiSnagu.TabIndex = 0;
            this.cmbIzaberiSnagu.TextChanged += new System.EventHandler(this.cmbIzaberiSnagu_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Izaberite snagu";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(151, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(25, 0, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Broj sati rada u danu\r\n";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbIzaberiSnagu, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtBrojSati, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnIzracunaj, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.00335F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.00035F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.33288F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.33288F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.33055F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(507, 248);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblVrijeme});
            this.statusStrip1.Location = new System.Drawing.Point(0, 276);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(507, 25);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblVrijeme
            // 
            this.lblVrijeme.Name = "lblVrijeme";
            this.lblVrijeme.Size = new System.Drawing.Size(128, 20);
            this.lblVrijeme.Text = "ovdje ide vrijeme ";
            // 
            // frmGlavnaForma
            // 
            this.AcceptButton = this.btnIzracunaj;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(507, 301);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(525, 346);
            this.MinimumSize = new System.Drawing.Size(525, 346);
            this.Name = "frmGlavnaForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proracun potrosnje peleta";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem meniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem podesavanja;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem izlazIzAplikacijeToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbIzaberiSnagu;
        private System.Windows.Forms.TextBox txtBrojSati;
        private System.Windows.Forms.Button btnIzracunaj;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblVrijeme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPotrosnjaDan;
        private System.Windows.Forms.Label lblPotrosnjaSat;
        private System.Windows.Forms.Label lblSnaga;
    }
}

