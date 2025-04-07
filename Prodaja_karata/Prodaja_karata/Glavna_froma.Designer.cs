namespace Prodaja_karata
{
    partial class Glavna_froma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Glavna_froma));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.glavniMeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnKupi = new System.Windows.Forms.Button();
            this.txtBrojKarata = new System.Windows.Forms.TextBox();
            this.lbKlasa = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCijenaKarte = new System.Windows.Forms.Label();
            this.lblBrojKarata = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUkupnaCijena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblVrijeme = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rtbUkupnoProdatihKarata = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.podesavanjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazIzAplikacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.glavniMeniToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(606, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // glavniMeniToolStripMenuItem
            // 
            this.glavniMeniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.podesavanjaToolStripMenuItem,
            this.toolStripSeparator1,
            this.izlazIzAplikacijeToolStripMenuItem});
            this.glavniMeniToolStripMenuItem.Name = "glavniMeniToolStripMenuItem";
            this.glavniMeniToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.glavniMeniToolStripMenuItem.Text = "Glavni meni";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(187, 6);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnKupi);
            this.groupBox1.Controls.Add(this.txtBrojKarata);
            this.groupBox1.Controls.Add(this.lbKlasa);
            this.groupBox1.Location = new System.Drawing.Point(12, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 158);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Izbor vrste sjedista i broja karata ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(224, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Broj karata ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Izbor lokacije";
            // 
            // btnKupi
            // 
            this.btnKupi.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnKupi.FlatAppearance.BorderSize = 2;
            this.btnKupi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKupi.Location = new System.Drawing.Point(226, 88);
            this.btnKupi.Name = "btnKupi";
            this.btnKupi.Size = new System.Drawing.Size(106, 41);
            this.btnKupi.TabIndex = 2;
            this.btnKupi.Text = "Kupi";
            this.btnKupi.UseVisualStyleBackColor = true;
            this.btnKupi.Click += new System.EventHandler(this.btnKupi_Click);
            // 
            // txtBrojKarata
            // 
            this.txtBrojKarata.Location = new System.Drawing.Point(226, 45);
            this.txtBrojKarata.Name = "txtBrojKarata";
            this.txtBrojKarata.Size = new System.Drawing.Size(105, 22);
            this.txtBrojKarata.TabIndex = 1;
            this.txtBrojKarata.TextChanged += new System.EventHandler(this.txtBrojKarata_TextChanged);
            // 
            // lbKlasa
            // 
            this.lbKlasa.FormattingEnabled = true;
            this.lbKlasa.ItemHeight = 16;
            this.lbKlasa.Location = new System.Drawing.Point(17, 45);
            this.lbKlasa.Name = "lbKlasa";
            this.lbKlasa.Size = new System.Drawing.Size(186, 84);
            this.lbKlasa.TabIndex = 0;
            this.lbKlasa.SelectedValueChanged += new System.EventHandler(this.lbKlasa_SelectedValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCijenaKarte);
            this.groupBox2.Controls.Add(this.lblBrojKarata);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtUkupnaCijena);
            this.groupBox2.Location = new System.Drawing.Point(383, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 158);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Podaci o kupovini ";
            // 
            // lblCijenaKarte
            // 
            this.lblCijenaKarte.AutoSize = true;
            this.lblCijenaKarte.ForeColor = System.Drawing.Color.Red;
            this.lblCijenaKarte.Location = new System.Drawing.Point(125, 52);
            this.lblCijenaKarte.Name = "lblCijenaKarte";
            this.lblCijenaKarte.Size = new System.Drawing.Size(46, 17);
            this.lblCijenaKarte.TabIndex = 8;
            this.lblCijenaKarte.Text = "label8";
            // 
            // lblBrojKarata
            // 
            this.lblBrojKarata.AutoSize = true;
            this.lblBrojKarata.ForeColor = System.Drawing.Color.Red;
            this.lblBrojKarata.Location = new System.Drawing.Point(125, 24);
            this.lblBrojKarata.Name = "lblBrojKarata";
            this.lblBrojKarata.Size = new System.Drawing.Size(46, 17);
            this.lblBrojKarata.TabIndex = 7;
            this.lblBrojKarata.Text = "label7";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ukupno za uplatu ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cijena po karti:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kupljeno karata:";
            // 
            // txtUkupnaCijena
            // 
            this.txtUkupnaCijena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUkupnaCijena.Location = new System.Drawing.Point(20, 106);
            this.txtUkupnaCijena.Multiline = true;
            this.txtUkupnaCijena.Name = "txtUkupnaCijena";
            this.txtUkupnaCijena.Size = new System.Drawing.Size(157, 32);
            this.txtUkupnaCijena.TabIndex = 0;
            this.txtUkupnaCijena.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sistem za prodaju karata";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblVrijeme});
            this.statusStrip1.Location = new System.Drawing.Point(0, 375);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(606, 25);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblVrijeme
            // 
            this.lblVrijeme.Name = "lblVrijeme";
            this.lblVrijeme.Size = new System.Drawing.Size(60, 20);
            this.lblVrijeme.Text = "Vrijeme";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rtbUkupnoProdatihKarata
            // 
            this.rtbUkupnoProdatihKarata.Location = new System.Drawing.Point(12, 272);
            this.rtbUkupnoProdatihKarata.Name = "rtbUkupnoProdatihKarata";
            this.rtbUkupnoProdatihKarata.Size = new System.Drawing.Size(571, 106);
            this.rtbUkupnoProdatihKarata.TabIndex = 5;
            this.rtbUkupnoProdatihKarata.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(231, 24);
            this.label9.TabIndex = 6;
            this.label9.Text = "Ukupno prodatih karata ";
            // 
            // podesavanjaToolStripMenuItem
            // 
            this.podesavanjaToolStripMenuItem.Image = global::Prodaja_karata.Properties.Resources.MeniPodesavanja;
            this.podesavanjaToolStripMenuItem.Name = "podesavanjaToolStripMenuItem";
            this.podesavanjaToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.podesavanjaToolStripMenuItem.Text = "Podesavanja";
            this.podesavanjaToolStripMenuItem.Click += new System.EventHandler(this.podesavanjaToolStripMenuItem_Click);
            // 
            // izlazIzAplikacijeToolStripMenuItem
            // 
            this.izlazIzAplikacijeToolStripMenuItem.Image = global::Prodaja_karata.Properties.Resources.MeniIzlaz;
            this.izlazIzAplikacijeToolStripMenuItem.Name = "izlazIzAplikacijeToolStripMenuItem";
            this.izlazIzAplikacijeToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.izlazIzAplikacijeToolStripMenuItem.Text = "Izlaz iz aplikacije";
            this.izlazIzAplikacijeToolStripMenuItem.Click += new System.EventHandler(this.izlazIzAplikacijeToolStripMenuItem_Click);
            // 
            // Glavna_froma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(606, 400);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rtbUkupnoProdatihKarata);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Glavna_froma";
            this.Text = "Prodaja karata";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem glavniMeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem podesavanjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem izlazIzAplikacijeToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnKupi;
        private System.Windows.Forms.TextBox txtBrojKarata;
        private System.Windows.Forms.ListBox lbKlasa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUkupnaCijena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblVrijeme;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCijenaKarte;
        private System.Windows.Forms.Label lblBrojKarata;
        private System.Windows.Forms.RichTextBox rtbUkupnoProdatihKarata;
        private System.Windows.Forms.Label label9;
    }
}

