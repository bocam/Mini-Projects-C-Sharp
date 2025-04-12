using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proracun_peleta
{
    public partial class frmPodesavanja : Form
    {
        public frmPodesavanja()
        {
            InitializeComponent();

            txtRadP1.Text = Properties.Settings.Default.RadP1.ToString();
            txtRadP2.Text = Properties.Settings.Default.RadP2.ToString();
            txtRadP3.Text = Properties.Settings.Default.RadP3.ToString();

            txtPauzaP1.Text = Properties.Settings.Default.PauzaP1.ToString();
            txtPauzaP2.Text = Properties.Settings.Default.PauzaP2.ToString();
            txtPauzaP3.Text = Properties.Settings.Default.PauzaP3.ToString();

            txtKalorijskaMoc.Text = Properties.Settings.Default.KalorijskaMoc.ToString();
            txtKolicina.Text = Properties.Settings.Default.Kolicina.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                Properties.Settings.Default.RadP1 = int.Parse(txtRadP1.Text);
                Properties.Settings.Default.RadP2 = int.Parse(txtRadP2.Text);
                Properties.Settings.Default.RadP3 = int.Parse(txtRadP3.Text);

                Properties.Settings.Default.PauzaP1 = int.Parse(txtPauzaP1.Text);
                Properties.Settings.Default.PauzaP2 = int.Parse(txtPauzaP2.Text);
                Properties.Settings.Default.PauzaP3 = int.Parse(txtPauzaP3.Text);

                Properties.Settings.Default.KalorijskaMoc = double.Parse(txtKalorijskaMoc.Text);
                Properties.Settings.Default.Kolicina = int.Parse(txtKolicina.Text);

                Properties.Settings.Default.Save();

                MessageBox.Show("Uspjesno ste izvrsili snimanje podataka","Poruka",MessageBoxButtons.OK,MessageBoxIcon.Information);
                //this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception)
            {

                MessageBox.Show("Unesite brojne vrijednosti,a ne slova","Greska",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtRadP1_TextChanged(object sender, EventArgs e)
        {
            
            
                if (txtRadP1.Text.Length == 0 || txtRadP2.Text.Length == 0 || txtRadP3.Text.Length == 0 || txtPauzaP1.Text.Length == 0 || txtPauzaP2.Text.Length == 0 || txtPauzaP3.Text.Length == 0 || txtKolicina.Text.Length == 0 || txtKalorijskaMoc.Text.Length == 0)
                {
                    btnSnimi.Enabled = false;
                }
                else
                {
                    btnSnimi.Enabled = true;
                }
            
            
        }

      
           

      
        

       
    }
}
