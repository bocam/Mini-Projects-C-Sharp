using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Proracun_peleta
{
    public partial class frmGlavnaForma : Form
    {
        public frmGlavnaForma()
        {
            InitializeComponent();
            lblVrijeme.Text = DateTime.Now.ToString("dd. MMMM yyyy. hh:mm:ss ");
            btnIzracunaj.Enabled = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblVrijeme.Text = DateTime.Now.ToString("dd. MMMM yyyy. hh:mm:ss ");
        }

        private void izlazIzAplikacijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void podesavanja_Click(object sender, EventArgs e)
        {
            frmPodesavanja Podesavanja = new frmPodesavanja();
            Podesavanja.ShowDialog();
        }

        private void btnIzracunaj_Click(object sender, EventArgs e)
        {
            int rad = 0, pauza = 0,brojSati=0;


            try
            {
                brojSati = int.Parse(txtBrojSati.Text);

            }
            catch (Exception greska)
            {
                
               MessageBox.Show("Unesite korektan tip podatka \n","Greska",MessageBoxButtons.OK,MessageBoxIcon.Error);
                File.AppendAllText("error.log", "\n" +DateTime.Now.ToString() + "\n" +  greska.ToString() + "\n");
            }
            if (cmbIzaberiSnagu.SelectedItem == "P1") 
            {

                rad = Properties.Settings.Default.RadP1;
                pauza = Properties.Settings.Default.PauzaP1;
            }
            else if (cmbIzaberiSnagu.SelectedItem == "P2") 
            {
                rad = Properties.Settings.Default.RadP2;
                pauza = Properties.Settings.Default.PauzaP2;
                
            }
            else if (cmbIzaberiSnagu.SelectedItem == "P3")
            {
                rad = Properties.Settings.Default.RadP3;
                pauza = Properties.Settings.Default.PauzaP3;

            }

            double potrosnjaSat = 0,snagaPeci=0,potrosnjaDan=0;

            potrosnjaSat = (Properties.Settings.Default.Kolicina / 1000f) * ((rad * 60f) / (rad + pauza));//formula data na roku
            snagaPeci = potrosnjaSat * Properties.Settings.Default.KalorijskaMoc;
            potrosnjaDan = potrosnjaSat * brojSati;

            lblSnaga.Text = snagaPeci.ToString("F2") + " kW/h";
            lblPotrosnjaSat.Text = potrosnjaSat.ToString("F2") + " kg/h";
            lblPotrosnjaDan.Text = potrosnjaDan.ToString("F2") + " kg/dan";

          
           

        }

        private void cmbIzaberiSnagu_TextChanged(object sender, EventArgs e)
        {
            if (cmbIzaberiSnagu.Text.Length == 0 || txtBrojSati.Text.Length == 0)
            {
                btnIzracunaj.Enabled = false;
            }
            else 
            {
                btnIzracunaj.Enabled = true;
            }
        }

       

       
    }
}
