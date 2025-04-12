namespace parking
{
    partial class Parking_rezervacija
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parking_rezervacija));
            this.txtRegistarskeOznake = new System.Windows.Forms.TextBox();
            this.txtBrojDokumenta = new System.Windows.Forms.TextBox();
            this.txtVrijemeRezervacije = new System.Windows.Forms.TextBox();
            this.cmbTipVozila = new System.Windows.Forms.ComboBox();
            this.btnRezervisi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTrenutnoVrijeme = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtRegistarskeOznake
            // 
            this.txtRegistarskeOznake.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRegistarskeOznake.Location = new System.Drawing.Point(186, 51);
            this.txtRegistarskeOznake.Name = "txtRegistarskeOznake";
            this.txtRegistarskeOznake.Size = new System.Drawing.Size(188, 22);
            this.txtRegistarskeOznake.TabIndex = 0;
            this.txtRegistarskeOznake.TextChanged += new System.EventHandler(this.txtRegistarskeOznake_TextChanged);
            // 
            // txtBrojDokumenta
            // 
            this.txtBrojDokumenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBrojDokumenta.Location = new System.Drawing.Point(186, 98);
            this.txtBrojDokumenta.Name = "txtBrojDokumenta";
            this.txtBrojDokumenta.Size = new System.Drawing.Size(188, 22);
            this.txtBrojDokumenta.TabIndex = 1;
            this.txtBrojDokumenta.TextChanged += new System.EventHandler(this.txtRegistarskeOznake_TextChanged);
            // 
            // txtVrijemeRezervacije
            // 
            this.txtVrijemeRezervacije.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVrijemeRezervacije.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVrijemeRezervacije.Location = new System.Drawing.Point(186, 236);
            this.txtVrijemeRezervacije.Name = "txtVrijemeRezervacije";
            this.txtVrijemeRezervacije.Size = new System.Drawing.Size(188, 22);
            this.txtVrijemeRezervacije.TabIndex = 5;
            this.txtVrijemeRezervacije.Leave += new System.EventHandler(this.txtVrijemeRezervacije_Leave);
            // 
            // cmbTipVozila
            // 
            this.cmbTipVozila.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTipVozila.FormattingEnabled = true;
            this.cmbTipVozila.Items.AddRange(new object[] {
            "Automobil\t",
            "Motocikl\t\t",
            "Teretno vozilo",
            "Cetvorocikl "});
            this.cmbTipVozila.Location = new System.Drawing.Point(186, 145);
            this.cmbTipVozila.Name = "cmbTipVozila";
            this.cmbTipVozila.Size = new System.Drawing.Size(188, 24);
            this.cmbTipVozila.TabIndex = 2;
            this.cmbTipVozila.TextChanged += new System.EventHandler(this.cmbTipVozila_TextChanged);
            // 
            // btnRezervisi
            // 
            this.btnRezervisi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRezervisi.Location = new System.Drawing.Point(140, 296);
            this.btnRezervisi.Name = "btnRezervisi";
            this.btnRezervisi.Size = new System.Drawing.Size(132, 30);
            this.btnRezervisi.TabIndex = 6;
            this.btnRezervisi.Text = "Rezervisi";
            this.btnRezervisi.UseVisualStyleBackColor = true;
            this.btnRezervisi.Click += new System.EventHandler(this.btnRezervisi_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Registarske oznake ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Broj dokumenta";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tip vozila ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Vrijeme dolaska:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(199, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Upravo sada ";
            // 
            // cbTrenutnoVrijeme
            // 
            this.cbTrenutnoVrijeme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTrenutnoVrijeme.AutoSize = true;
            this.cbTrenutnoVrijeme.Location = new System.Drawing.Point(295, 199);
            this.cbTrenutnoVrijeme.Name = "cbTrenutnoVrijeme";
            this.cbTrenutnoVrijeme.Size = new System.Drawing.Size(18, 17);
            this.cbTrenutnoVrijeme.TabIndex = 4;
            this.cbTrenutnoVrijeme.UseVisualStyleBackColor = true;
            this.cbTrenutnoVrijeme.CheckedChanged += new System.EventHandler(this.cbTrenutnoVrijeme_CheckedChanged);
            // 
            // Parking_rezervacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 349);
            this.Controls.Add(this.cbTrenutnoVrijeme);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRezervisi);
            this.Controls.Add(this.cmbTipVozila);
            this.Controls.Add(this.txtVrijemeRezervacije);
            this.Controls.Add(this.txtBrojDokumenta);
            this.Controls.Add(this.txtRegistarskeOznake);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(531, 494);
            this.MinimumSize = new System.Drawing.Size(431, 394);
            this.Name = "Parking_rezervacija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "M1-Parking_rezervacija";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Parking_rezervacija_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRegistarskeOznake;
        private System.Windows.Forms.TextBox txtBrojDokumenta;
        private System.Windows.Forms.TextBox txtVrijemeRezervacije;
        private System.Windows.Forms.ComboBox cmbTipVozila;
        private System.Windows.Forms.Button btnRezervisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbTrenutnoVrijeme;
    }
}