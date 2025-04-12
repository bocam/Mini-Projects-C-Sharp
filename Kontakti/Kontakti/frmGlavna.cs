using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kontakti
{
    public partial class frmGlavna : Form
    {
        public frmGlavna()
        {
            InitializeComponent();

            KontaktOsoba [] osobe=   {
                                        new KontaktOsoba("Dragan","Draganic","065/111-222","dragan@gmail.com","dragan.draganic.jpg"),
                                        new KontaktOsoba("Petar","Petrovic","065/111-333","petar@gmail.com","petar.petrovic.jpg"),
                                         new KontaktOsoba("Dragana","Draganic","065/111-444","dragana@gmail.com","dragana.draganic.jpg"),
                                          new KontaktOsoba("Ivana","Ivanovic","065/111-555","ivana@gmail.com","ivana.ivanovic.jpg"),
                                           new KontaktOsoba("Jovan","Jovanovic","065/111-666","jovan@gmail.com","jovan.jovanovic.jpg"),
                                    };
           

            foreach(KontaktOsoba osoba in osobe)
            {

                lstbKontaktOsoba.Items.Add(osoba);
            }

            
            
            lstbKontaktOsoba.SelectedItem = osobe[0];
            lblIme.Text = osobe[0].ime;
            lblPrezime.Text = osobe[0].prezime;
            lblTelefon.Text = osobe[0].telefon;
            lblEmail.Text = osobe[0].email;
            pcbSlika.Image = Image.FromFile(@"Resources\"+osobe[0].slika); //Da bi mogla ova relativna putanja moramo sve slike nakon importovanja
                                                                            // u Resources kliknuti na svaku pojedinacno i u Property (Copy to Output Directory) staviti na (copy always) kako bi otisle gdje i izvrsni fajl aplikacije
            
            lblVrijeme.Text = DateTime.Now.ToString("dd. MMMM yyyy. hh:mm:ss"); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblVrijeme.Text = DateTime.Now.ToString("dd. MMMM yyyy. hh:mm:ss"); ;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            NoviKontakt noviKontakt = new NoviKontakt();
           DialogResult rezultat= noviKontakt.ShowDialog();

           if (rezultat == DialogResult.OK) 
           {
               KontaktOsoba novaOsoba = new KontaktOsoba(noviKontakt.imeNovog, noviKontakt.prezimeNovog, noviKontakt.telefonNovog, noviKontakt.emailNovog, noviKontakt.slikaNovog);
               lstbKontaktOsoba.Items.Add(novaOsoba);
           }

            
        }

        private void lstbKontaktOsoba_SelectedIndexChanged(object sender, EventArgs e)
        {
            KontaktOsoba selektovanaOsoba = (KontaktOsoba)lstbKontaktOsoba.SelectedItem;

            lblIme.Text = selektovanaOsoba.ime;
            lblPrezime.Text = selektovanaOsoba.prezime;
            lblTelefon.Text = selektovanaOsoba.telefon;
            lblEmail.Text = selektovanaOsoba.email;
           
            pcbSlika.Image = Image.FromFile(@"Resources/" + selektovanaOsoba.slika);
            
           
        }
    }
}
