namespace Kontakti
{
    partial class NoviKontakt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoviKontakt));
            this.ime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rdbMuski = new System.Windows.Forms.RadioButton();
            this.rdbZenski = new System.Windows.Forms.RadioButton();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ime
            // 
            this.ime.AutoSize = true;
            this.ime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ime.Location = new System.Drawing.Point(83, 57);
            this.ime.Name = "ime";
            this.ime.Size = new System.Drawing.Size(32, 18);
            this.ime.TabIndex = 0;
            this.ime.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(135, 56);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(177, 22);
            this.txtIme.TabIndex = 4;
            this.txtIme.TextChanged += new System.EventHandler(this.txtIme_TextChanged);
            
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(135, 96);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(177, 22);
            this.txtPrezime.TabIndex = 5;
            this.txtPrezime.TextChanged += new System.EventHandler(this.txtIme_TextChanged);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(135, 136);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(177, 22);
            this.txtTelefon.TabIndex = 6;
            this.txtTelefon.TextChanged += new System.EventHandler(this.txtIme_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(135, 176);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(177, 22);
            this.txtEmail.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(83, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Pol";
            // 
            // rdbMuski
            // 
            this.rdbMuski.AutoSize = true;
            this.rdbMuski.Location = new System.Drawing.Point(135, 214);
            this.rdbMuski.Name = "rdbMuski";
            this.rdbMuski.Size = new System.Drawing.Size(65, 21);
            this.rdbMuski.TabIndex = 9;
            this.rdbMuski.TabStop = true;
            this.rdbMuski.Text = "Muski";
            this.rdbMuski.UseVisualStyleBackColor = true;
            // 
            // rdbZenski
            // 
            this.rdbZenski.AutoSize = true;
            this.rdbZenski.Location = new System.Drawing.Point(222, 214);
            this.rdbZenski.Name = "rdbZenski";
            this.rdbZenski.Size = new System.Drawing.Size(71, 21);
            this.rdbZenski.TabIndex = 10;
            this.rdbZenski.TabStop = true;
            this.rdbZenski.Text = "Zenski\r\n";
            this.rdbZenski.UseVisualStyleBackColor = true;
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.Color.White;
            this.btnOdustani.Location = new System.Drawing.Point(198, 258);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(113, 48);
            this.btnOdustani.TabIndex = 12;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSnimi
            // 
            this.btnSnimi.BackColor = System.Drawing.Color.White;
            this.btnSnimi.Location = new System.Drawing.Point(55, 258);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(113, 48);
            this.btnSnimi.TabIndex = 13;
            this.btnSnimi.Text = "Snimi";
            this.btnSnimi.UseVisualStyleBackColor = false;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // NoviKontakt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 320);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.rdbZenski);
            this.Controls.Add(this.rdbMuski);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NoviKontakt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novi kontakt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdbMuski;
        private System.Windows.Forms.RadioButton rdbZenski;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSnimi;
    }
}