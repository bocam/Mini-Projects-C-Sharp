using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IK_kafic
{
    public partial class FormaRacun : Form
    {
        public FormaRacun(Image image,String name,String ime_forme)
        {
            InitializeComponent();
            pcbSlikaKonobara.Image = image;
            lblImePrezime.Text = name;
            this.Text = ime_forme; //za naslov forme

            Artikl[] stavke = { new Artikl("kafa", 1.5f), new Artikl("sok", 2.0f), new Artikl("kola", 2.5f), new Artikl("fanta", 2.5f), new Artikl("pivo", 1.7f) };
            //Artikl stavka1 = new Artikl("kafa", 1.5f);
            // Artikl stavka2 = new Artikl("sok", 2.0f);

            foreach (Artikl stavka in stavke)
                lstPonuda.Items.Add(stavka);

            //lstPonuda.Items.Add(stavka1);
            //lstPonuda.Items.Add(stavka2);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                lstRacun.Items.Add(lstPonuda.SelectedItem);
            }
            catch (Exception)
            {
                MessageBox.Show("Morate selektovati stavku iz liste " , "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Error);   

            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            lstRacun.Items.Remove(lstRacun.SelectedItem);
        }

        private void lstPonuda_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                lstRacun.Items.Add(lstPonuda.SelectedItem);
            }
            catch (Exception)
            {
                MessageBox.Show("Morate selektovati stavku iz liste ", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void lstRacun_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            lstRacun.Items.Remove(lstRacun.SelectedItem);
        }

        void Test()  //FUNKCIja koju smo dobili uz rok ,samo je trebalo ubaciti
        {
            throw new NotImplementedException();
        }
        private void btnIzdajRacun_Click(object sender, EventArgs e)
        {
           
            
                string racun = "Racun:\n-------------------------------\n";
                float zbir = 0;
                foreach (Artikl stavke_racuna in lstRacun.Items)
                {
                    racun += stavke_racuna.ToString() + "\n";
                    zbir += stavke_racuna.cijenaArtikla;

                }
                racun += "-------------------------------";
                racun += "\nUkupno\t\t" + zbir.ToString("0.00 KM");
                MessageBox.Show(racun, "proba", MessageBoxButtons.OKCancel);
                this.DialogResult = DialogResult.OK;
            try
            {
                Test();
            }
            catch
            {

            }
           
            
         
            //zatvaranje forme
            //this.Close();
        }
      
    }
}
