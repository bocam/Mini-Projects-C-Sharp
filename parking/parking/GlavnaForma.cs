using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace parking
{
    public partial class GlavnaForma : Form
    {
        Button btn_selektovani = null;
        int broj_mjesta = 14;

        public GlavnaForma()
        {
            
            InitializeComponent();

            lblVrijeme.Text = DateTime.Now.ToString();
            txtBrojMjesta.Enabled = false;
            rtbAktivnosti.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblVrijeme.Text = DateTime.Now.ToString();
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Rezrvisi_parking_Click(object sender, EventArgs e)
        {
            int mjesto = int.Parse(btn_selektovani.Text);
            Parking_rezervacija parkingRezervacija = new Parking_rezervacija();
            DialogResult odgovor = parkingRezervacija.ShowDialog();
            if (odgovor == DialogResult.OK) 
            {
                string s = "\n\nM" + mjesto.ToString() + "-Dolazak     " + parkingRezervacija.Dolazak.ToString("hh:mm:ss");
                s += "\nRegistarska oznaka:" + parkingRezervacija.RegOznake + "\n";
                s += "Tip:" + parkingRezervacija.TipVozila + "\n";
                rtbAktivnosti.Text = s + rtbAktivnosti.Text;
                btn_selektovani.BackColor = Color.Red;
                broj_mjesta--;
                txtBrojMjesta.Text = broj_mjesta.ToString();
            }
          
                 

            
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) 
            {

                btn_selektovani = (Button)sender;
            }
        }

        private void Rezervisi_Opening(object sender, CancelEventArgs e)
        {
            if (btn_selektovani.BackColor == Color.Red)
            {
                Rezrvisi_parking.Enabled = false;
                naplatiParking.Enabled = true;
            }
            else if (btn_selektovani.BackColor == Color.Green)
            {
                Rezrvisi_parking.Enabled = true;
                naplatiParking.Enabled = false;
                
            }
        }

        private void naplatiParking_Click(object sender, EventArgs e)
        {
            if (btn_selektovani.BackColor == Color.Red) 
            {

                rtbAktivnosti.Text = "\nM " + btn_selektovani.Text + "-Odlazak " + DateTime.Now.ToString("hh:mm:ss") + "\n\n" + rtbAktivnosti.Text;
                btn_selektovani.BackColor = Color.Green;
                broj_mjesta++;
                txtBrojMjesta.Text = broj_mjesta.ToString();
            }
        }
    }
}
