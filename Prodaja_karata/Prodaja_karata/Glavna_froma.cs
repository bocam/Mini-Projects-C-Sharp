using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prodaja_karata
{
    public partial class Glavna_froma : Form
    {
        int stariBrojKarti_Iklasa = 0;
        int stariBrojKarti_IIklasa = 0;
        int stariBrojKarti_IIIklasa = 0;
        int stariBrojKarti_ekonomskaKlasa = 0;

        int stara_cijenaIklasa = Properties.Settings.Default.IKlasa;
        int stara_cijenaIIklasa = Properties.Settings.Default.IIKlasa;
        int stara_cijenaIIIklasa = Properties.Settings.Default.IIIKlasa;
        int stara_cijenaEkonomskaKlasa = Properties.Settings.Default.Ekonomska_klasa;

        int ukupna_cijenaIklasa=0;
        int ukupna_cijenaIIklasa = 0;
        int ukupna_cijenaIIIklasa = 0;
        int ukupna_cijenaEkonomskaKlasa = 0;


        public Glavna_froma()
        {
            InitializeComponent();
            lblVrijeme.Text = DateTime.Now.ToString("dd. MMMMM yyyy. hh:mm:ss");
            Karta[] karte = {
                                new Karta("I klasa", 15),
                                new Karta("II klasa", 12),
                                 new Karta("III klasa", 10),
                                  new Karta("Ekonomska klasa", 7)
                            };

            foreach (Karta karta in karte) 
            {
                lbKlasa.Items.Add(karta);
            }

            btnKupi.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblVrijeme.Text = DateTime.Now.ToString("dd. MMMMM yyyy. HH:mm:ss");
        }



        private void izlazIzAplikacijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void podesavanjaToolStripMenuItem_Click(object sender, EventArgs e)


        {
            Podesavanja podesavanja = new Podesavanja();
            podesavanja.ShowDialog();
        }

        private void btnKupi_Click(object sender, EventArgs e)
        {
            if (lbKlasa.SelectedIndex == 0) 
            {
                rtbUkupnoProdatihKarata.Clear();
                lblCijenaKarte.Text = Properties.Settings.Default.IKlasa.ToString();
                Izracunaj_sve_za_klasu(lbKlasa.SelectedIndex);

            }
            if (lbKlasa.SelectedIndex == 1) 
            {
                rtbUkupnoProdatihKarata.Clear();
                lblCijenaKarte.Text = Properties.Settings.Default.IIKlasa.ToString();
                Izracunaj_sve_za_klasu(lbKlasa.SelectedIndex);
            }
            if (lbKlasa.SelectedIndex == 2)
            {
                rtbUkupnoProdatihKarata.Clear();
                lblCijenaKarte.Text = Properties.Settings.Default.IIIKlasa.ToString();
                Izracunaj_sve_za_klasu(lbKlasa.SelectedIndex);
            }
            if (lbKlasa.SelectedIndex == 3)
            {
                rtbUkupnoProdatihKarata.Clear();
                lblCijenaKarte.Text = Properties.Settings.Default.Ekonomska_klasa.ToString();
                Izracunaj_sve_za_klasu(lbKlasa.SelectedIndex);
            }

            lblBrojKarata.Text = txtBrojKarata.Text;

            try
            {
                int broj_karata = int.Parse(txtBrojKarata.Text);
                int cijena_karte=int.Parse(lblCijenaKarte.Text);
                int ukupna_cijena = broj_karata * cijena_karte;
                txtUkupnaCijena.Text = ukupna_cijena.ToString("0. KM");
            }
            catch (Exception)
            {

                MessageBox.Show("Neispravan tip podatka");
            }

          
            

        }

        private void lbKlasa_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lbKlasa.SelectedItems.Count>0 && txtBrojKarata.Text.Length > 0)
            {
                btnKupi.Enabled = true ;
            }
            else 
            {
                btnKupi.Enabled = false;
            }
        }

        private void txtBrojKarata_TextChanged(object sender, EventArgs e)
        {
            if (lbKlasa.SelectedItems.Count>0 && txtBrojKarata.Text.Length > 0)
            {
                btnKupi.Enabled = true;
            }
            else
            {
                btnKupi.Enabled = false;
            }
        }

        private void Izracunaj_sve_za_klasu(int stavka_liste) 
        {
           
            int novi_brojKarti = 0;
            
     
             novi_brojKarti = int.Parse(txtBrojKarata.Text);

             if (lbKlasa.SelectedIndex == 0)
             {

                 stariBrojKarti_Iklasa = stariBrojKarti_Iklasa + novi_brojKarti;
                

                     ukupna_cijenaIklasa = ukupna_cijenaIklasa+ (Properties.Settings.Default.IKlasa * novi_brojKarti);


                 

                 ukupna_cijenaIIklasa = ukupna_cijenaIIklasa;

                 ukupna_cijenaIIIklasa = ukupna_cijenaIIIklasa;
                 ukupna_cijenaEkonomskaKlasa = ukupna_cijenaEkonomskaKlasa;

             }
             else if(lbKlasa.SelectedIndex==1){
            
                 stariBrojKarti_IIklasa = stariBrojKarti_IIklasa + novi_brojKarti;

                
                        ukupna_cijenaIIklasa = ukupna_cijenaIIklasa+(Properties.Settings.Default.IIKlasa * novi_brojKarti);
                 
                 ukupna_cijenaIklasa = ukupna_cijenaIklasa;
                 ukupna_cijenaIIIklasa = ukupna_cijenaIIIklasa;
                 ukupna_cijenaEkonomskaKlasa = ukupna_cijenaEkonomskaKlasa;

                
        }
             else if (lbKlasa.SelectedIndex == 2) 
             {
                 stariBrojKarti_IIIklasa = stariBrojKarti_IIIklasa + novi_brojKarti;
                 ukupna_cijenaIIIklasa = ukupna_cijenaIIIklasa + (novi_brojKarti * Properties.Settings.Default.IIIKlasa);

                 ukupna_cijenaIklasa = ukupna_cijenaIklasa;
                 ukupna_cijenaIIklasa = ukupna_cijenaIIklasa;
                 ukupna_cijenaEkonomskaKlasa = ukupna_cijenaEkonomskaKlasa;
             }

             else if (lbKlasa.SelectedIndex ==3) 
             {
                 stariBrojKarti_ekonomskaKlasa = stariBrojKarti_ekonomskaKlasa + novi_brojKarti;
                 ukupna_cijenaEkonomskaKlasa = ukupna_cijenaEkonomskaKlasa + (novi_brojKarti * Properties.Settings.Default.Ekonomska_klasa);

                 ukupna_cijenaIklasa = ukupna_cijenaIklasa;
                 ukupna_cijenaIIklasa = ukupna_cijenaIIklasa;
                 ukupna_cijenaIIIklasa = ukupna_cijenaIIIklasa;
             }

                
             

             rtbUkupnoProdatihKarata.AppendText("Lokacija\t\tBroj karti\t\t Ukupno\n I klasa\t\t " + stariBrojKarti_Iklasa.ToString("F2") + "\t\t" + ukupna_cijenaIklasa.ToString("0.00 KM") + "\n");
             rtbUkupnoProdatihKarata.AppendText("II klasa\t\t" + stariBrojKarti_IIklasa.ToString("F2") + "\t\t" + ukupna_cijenaIIklasa.ToString("F2") + "KM\n");
             rtbUkupnoProdatihKarata.AppendText("III klasa\t\t" + stariBrojKarti_IIIklasa.ToString("F2") + "\t\t" + ukupna_cijenaIIIklasa.ToString("F2") + "KM");
             rtbUkupnoProdatihKarata.AppendText("\nEkonomska klasa \t" + stariBrojKarti_ekonomskaKlasa.ToString("F2") + "\t\t" + ukupna_cijenaEkonomskaKlasa.ToString("F2") + "KM");


        }

      
    }
}
