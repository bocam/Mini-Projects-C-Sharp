using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace kalkulator
{
    public partial class frmGlavna : Form
    {
        double mjesecnaRata=0;
        double kamatna_stopa = 0;
        double ukupnoZaduzenje = 0;
        double ukupnaKamata = 0;


        public frmGlavna()
        {
            

            InitializeComponent();

            PostaviTrackBar();

            lblVrijeme.Text = DateTime.Now.ToString("hh:mm:ss");

            txtBrojMjeseci.Text = tbBrojMjeseci.Minimum.ToString();
            txtIznosKredita.Text = tbIznosKredita.Minimum.ToString();
            rdbOdlicanKlijent.Checked = true;

            
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblVrijeme.Text = DateTime.Now.ToString("hh:mm:ss");
        }

       
        private void izlazIzAplikacijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void PostaviTrackBar() 
        {

            tbIznosKredita.Minimum = Properties.Settings.Default.minKredita;
            tbIznosKredita.Maximum = Properties.Settings.Default.maksKredita;
            tbBrojMjeseci.Minimum = Properties.Settings.Default.minMjeseci;
            tbBrojMjeseci.Maximum = Properties.Settings.Default.maksMjeseci;

        }


        private void podesavanjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPodesavanja formaPodesavanja = new frmPodesavanja();
            formaPodesavanja.ShowDialog();
            if (formaPodesavanja.DialogResult == DialogResult.OK) 
            {
                PostaviTrackBar();
                txtBrojMjeseci.Text = tbBrojMjeseci.Minimum.ToString();
                txtIznosKredita.Text = tbIznosKredita.Minimum.ToString();
                tbIznosKredita.Value = tbIznosKredita.Minimum;
                tbBrojMjeseci.Value = tbBrojMjeseci.Minimum;
                postaviLabele();
            }
        }



        private void tbIznosKredita_Scroll(object sender, EventArgs e)
        {
            txtIznosKredita.Text = tbIznosKredita.Value.ToString();
            postaviLabele();
        }

        private void tbBrojMjeseci_Scroll(object sender, EventArgs e)
        {
            txtBrojMjeseci.Text = tbBrojMjeseci.Value.ToString();
            postaviLabele();
        }

        

       
        
         private double IzracunajRatuKredita(int UkupanIznosKredita,int brojMjeseci,double kamatna_stopa)
   
    {
        double kamata = kamatna_stopa / 1200;
        double stepen = Math.Pow((1 + kamata), brojMjeseci);
        mjesecnaRata = (UkupanIznosKredita * kamata * stepen) / (stepen-1);

        return mjesecnaRata; 
    }

         private double IzracunajUkupnoZaduzenje(int brojMjeseci, double mjesecnaRata) 
         {
             ukupnoZaduzenje = brojMjeseci * mjesecnaRata;

             return ukupnoZaduzenje;
         }

         private double IzracunajUkupnuKamatu(double ukupnoZaduzenje,double ukupanIznosKredita) 
         {

             return ukupnaKamata=ukupnoZaduzenje-ukupanIznosKredita;
         }

         private void postaviLabele() 
         {
            mjesecnaRata= IzracunajRatuKredita(tbIznosKredita.Value, tbBrojMjeseci.Value, kamatna_stopa);
             txtMjesecnaRata.Text=mjesecnaRata.ToString("C",CultureInfo.CreateSpecificCulture("bs-Latn-BA"));
             ukupnoZaduzenje = IzracunajUkupnoZaduzenje(tbBrojMjeseci.Value, mjesecnaRata);
             txtUkupnoZaduzenje.Text = ukupnoZaduzenje.ToString("C", CultureInfo.CreateSpecificCulture("bs-Latn-BA"));
             ukupnaKamata = IzracunajUkupnuKamatu(ukupnoZaduzenje, Convert.ToDouble(tbIznosKredita.Value));
             txtUkupnaKamata.Text = ukupnaKamata.ToString("C", CultureInfo.CreateSpecificCulture("bs-Latn-BA"));
  
         
         }

         private void rdbOdlicanKlijent_CheckedChanged(object sender, EventArgs e)
         {
             if (rdbOdlicanKlijent.Checked == true) 
                 kamatna_stopa = 3D;
             postaviLabele();
             
         }

         private void rdbLosKlijent_CheckedChanged(object sender, EventArgs e)
         {
             if (rdbLosKlijent.Checked == true)
                 kamatna_stopa = 6D;
             postaviLabele();
         }

         private void rdbDobarKlijent_CheckedChanged(object sender, EventArgs e)
         {
             if (rdbDobarKlijent.Checked == true)
                 kamatna_stopa = 5D;
             postaviLabele();

         }


       
      
        
    }
}
