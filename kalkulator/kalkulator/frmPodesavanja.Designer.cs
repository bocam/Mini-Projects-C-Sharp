namespace kalkulator
{
    partial class frmPodesavanja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPodesavanja));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMinKredita = new System.Windows.Forms.TextBox();
            this.txtMaxKredita = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMaxMjeseci = new System.Windows.Forms.TextBox();
            this.txtMinMjeseci = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaxKredita);
            this.groupBox1.Controls.Add(this.txtMinKredita);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podesavanja za iznos kredita ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minimum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Maksimum";
            // 
            // txtMinKredita
            // 
            this.txtMinKredita.Location = new System.Drawing.Point(103, 31);
            this.txtMinKredita.Name = "txtMinKredita";
            this.txtMinKredita.Size = new System.Drawing.Size(148, 22);
            this.txtMinKredita.TabIndex = 2;
            // 
            // txtMaxKredita
            // 
            this.txtMaxKredita.Location = new System.Drawing.Point(103, 59);
            this.txtMaxKredita.Name = "txtMaxKredita";
            this.txtMaxKredita.Size = new System.Drawing.Size(148, 22);
            this.txtMaxKredita.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMaxMjeseci);
            this.groupBox2.Controls.Add(this.txtMinMjeseci);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(15, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Podesavanja za broj mjeseci";
            // 
            // txtMaxMjeseci
            // 
            this.txtMaxMjeseci.Location = new System.Drawing.Point(103, 59);
            this.txtMaxMjeseci.Name = "txtMaxMjeseci";
            this.txtMaxMjeseci.Size = new System.Drawing.Size(148, 22);
            this.txtMaxMjeseci.TabIndex = 3;
            // 
            // txtMinMjeseci
            // 
            this.txtMinMjeseci.Location = new System.Drawing.Point(103, 31);
            this.txtMinMjeseci.Name = "txtMinMjeseci";
            this.txtMinMjeseci.Size = new System.Drawing.Size(148, 22);
            this.txtMinMjeseci.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Maksimum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Minimum";
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.Color.ForestGreen;
            this.btnOdustani.Image = global::kalkulator.Properties.Resources.Odustani_24p;
            this.btnOdustani.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOdustani.Location = new System.Drawing.Point(160, 263);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(125, 34);
            this.btnOdustani.TabIndex = 6;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSnimi
            // 
            this.btnSnimi.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSnimi.Image = global::kalkulator.Properties.Resources.Snimi_24p;
            this.btnSnimi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSnimi.Location = new System.Drawing.Point(15, 263);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(125, 34);
            this.btnSnimi.TabIndex = 5;
            this.btnSnimi.Text = "Snimi";
            this.btnSnimi.UseVisualStyleBackColor = false;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // frmPodesavanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 318);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(319, 363);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(319, 363);
            this.Name = "frmPodesavanja";
            this.Text = "Podesavanja";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaxKredita;
        private System.Windows.Forms.TextBox txtMinKredita;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMaxMjeseci;
        private System.Windows.Forms.TextBox txtMinMjeseci;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.Button btnOdustani;
    }
}