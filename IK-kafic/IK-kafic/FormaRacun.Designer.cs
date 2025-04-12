namespace IK_kafic
{
    partial class FormaRacun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaRacun));
            this.pcbSlikaKonobara = new System.Windows.Forms.PictureBox();
            this.lblImePrezime = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstRacun = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstPonuda = new System.Windows.Forms.ListBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnIzdajRacun = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSlikaKonobara)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcbSlikaKonobara
            // 
            this.pcbSlikaKonobara.Image = global::IK_kafic.Properties.Resources.konobar;
            this.pcbSlikaKonobara.Location = new System.Drawing.Point(12, 12);
            this.pcbSlikaKonobara.Name = "pcbSlikaKonobara";
            this.pcbSlikaKonobara.Size = new System.Drawing.Size(150, 150);
            this.pcbSlikaKonobara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbSlikaKonobara.TabIndex = 0;
            this.pcbSlikaKonobara.TabStop = false;
            // 
            // lblImePrezime
            // 
            this.lblImePrezime.AutoSize = true;
            this.lblImePrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImePrezime.Location = new System.Drawing.Point(168, 130);
            this.lblImePrezime.Name = "lblImePrezime";
            this.lblImePrezime.Size = new System.Drawing.Size(207, 32);
            this.lblImePrezime.TabIndex = 1;
            this.lblImePrezime.Text = "Petar Petrovic";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDodaj, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnObrisi, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnIzdajRacun, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 181);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(559, 340);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lstRacun);
            this.groupBox2.Location = new System.Drawing.Point(309, 3);
            this.groupBox2.Name = "groupBox2";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox2, 2);
            this.groupBox2.Size = new System.Drawing.Size(247, 300);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Racun";
            // 
            // lstRacun
            // 
            this.lstRacun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstRacun.FormattingEnabled = true;
            this.lstRacun.ItemHeight = 16;
            this.lstRacun.Location = new System.Drawing.Point(3, 18);
            this.lstRacun.Name = "lstRacun";
            this.lstRacun.Size = new System.Drawing.Size(241, 279);
            this.lstRacun.TabIndex = 0;
            this.lstRacun.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstRacun_MouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lstPonuda);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox1, 2);
            this.groupBox1.Size = new System.Drawing.Size(245, 300);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ponuda";
            // 
            // lstPonuda
            // 
            this.lstPonuda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPonuda.FormattingEnabled = true;
            this.lstPonuda.ItemHeight = 16;
            this.lstPonuda.Location = new System.Drawing.Point(3, 18);
            this.lstPonuda.Name = "lstPonuda";
            this.lstPonuda.Size = new System.Drawing.Size(239, 279);
            this.lstPonuda.TabIndex = 0;
            this.lstPonuda.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstPonuda_MouseDoubleClick);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDodaj.Location = new System.Drawing.Point(254, 127);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(49, 23);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = ">>";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnObrisi.Location = new System.Drawing.Point(254, 156);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(49, 23);
            this.btnObrisi.TabIndex = 3;
            this.btnObrisi.Text = "<<";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnIzdajRacun
            // 
            this.btnIzdajRacun.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.btnIzdajRacun, 3);
            this.btnIzdajRacun.Location = new System.Drawing.Point(228, 310);
            this.btnIzdajRacun.Name = "btnIzdajRacun";
            this.btnIzdajRacun.Size = new System.Drawing.Size(103, 26);
            this.btnIzdajRacun.TabIndex = 4;
            this.btnIzdajRacun.Text = "Izdaj racun ";
            this.btnIzdajRacun.UseVisualStyleBackColor = true;
            this.btnIzdajRacun.Click += new System.EventHandler(this.btnIzdajRacun_Click);
            // 
            // FormaRacun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 533);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblImePrezime);
            this.Controls.Add(this.pcbSlikaKonobara);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(732, 578);
            this.MinimumSize = new System.Drawing.Size(500, 578);
            this.Name = "FormaRacun";
            this.Text = "Racun-Petar Petrovic";
            ((System.ComponentModel.ISupportInitialize)(this.pcbSlikaKonobara)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbSlikaKonobara;
        private System.Windows.Forms.Label lblImePrezime;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstPonuda;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnIzdajRacun;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstRacun;
    }
}