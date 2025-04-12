using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace parking
{
    public partial class Parking_rezervacija : Form
    {
        public Parking_rezervacija()
        {
            InitializeComponent();
            cmbTipVozila.SelectedIndex = 0;
            cbTrenutnoVrijeme.Checked = true;
            txtVrijemeRezervacije.Enabled = false;
        }

        public DateTime Dolazak { get; set; }

        public string TipVozila { get; set; }
        public string RegOznake { get; set; }

        private void cbTrenutnoVrijeme_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTrenutnoVrijeme.Checked == true)
            {
                txtVrijemeRezervacije.Clear();
                popunjeniPodaci();
                txtVrijemeRezervacije.Enabled = false;

            }
            else
            {
                popunjeniPodaci();
                txtVrijemeRezervacije.Enabled = true;
                MessageBox.Show("Ispisite vrijeme u formatu HH:MM:SS");
            }

        }

        private void popunjeniPodaci() 
        {
            if (txtRegistarskeOznake.Text.Length > 0 && txtBrojDokumenta.Text.Length > 0 && cmbTipVozila.SelectedItem!=null )
            {
                if (cbTrenutnoVrijeme.Checked == true || txtVrijemeRezervacije.Text.Length > 0)
                {

                    btnRezervisi.Enabled = true;
                }
                else 
                {
                    btnRezervisi.Enabled = false;
                }


            }
            else 
            {

                btnRezervisi.Enabled = false;
            }
        
        }

        private void txtRegistarskeOznake_TextChanged(object sender, EventArgs e)
        {
            popunjeniPodaci();
        }

        private void cmbTipVozila_TextChanged(object sender, EventArgs e)
        {
            popunjeniPodaci();
        }

    
        private void Parking_rezervacija_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                if (cbTrenutnoVrijeme.Checked)
                {

                    Dolazak = DateTime.Now;
                }
                else
                {
                    Dolazak = DateTime.Parse(txtVrijemeRezervacije.Text);
                }

                TipVozila = cmbTipVozila.Text;
                RegOznake = txtRegistarskeOznake.Text;
            }
        }

        private void txtVrijemeRezervacije_Leave(object sender, EventArgs e)
        {
            string unos = txtVrijemeRezervacije.Text;
            Regex regex = new Regex(@"^\d{2}:\d{2}:\d{2}$");

            if (!regex.IsMatch(unos))
            {
                MessageBox.Show("Nevažeći unos vremena! Molimo unesite vrijeme u formatu 'hh:mm:ss'.");
             DialogResult izbor=   MessageBox.Show("zelite li da opet se vratite na trenutno vrijeme","Podrska",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
             if (izbor == DialogResult.Yes)
             {
                 cbTrenutnoVrijeme.Checked = true;
             }
             else
              {


                 btnRezervisi.Enabled = false;
                 txtVrijemeRezervacije.Focus();
                 return;
              }
            }
            else 
            {
                popunjeniPodaci();
                MessageBox.Show("Korektno popunjeno vrijeme"); 
            }
            

        }

        private void btnRezervisi_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
       
       
        
    }
}
