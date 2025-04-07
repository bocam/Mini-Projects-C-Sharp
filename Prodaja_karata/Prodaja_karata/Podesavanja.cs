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
    public partial class Podesavanja : Form
    {
        public Podesavanja()
        {
            InitializeComponent();
            txtIklasa.Text = Properties.Settings.Default.IKlasa.ToString();
            txtIIklasa.Text = Properties.Settings.Default.IIKlasa.ToString();
            txtIIIklasa.Text = Properties.Settings.Default.IIIKlasa.ToString();
            txtEkonomska_klasa.Text = Properties.Settings.Default.Ekonomska_klasa.ToString();
        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {
          
            try
            {
                Properties.Settings.Default.IKlasa = int.Parse(txtIklasa.Text);
                Properties.Settings.Default.IIKlasa = int.Parse(txtIIklasa.Text);
                Properties.Settings.Default.IIIKlasa = int.Parse(txtIIIklasa.Text);
                Properties.Settings.Default.Ekonomska_klasa = int.Parse(txtEkonomska_klasa.Text);
                Properties.Settings.Default.Save();
                
                MessageBox.Show("Ispravno snimljeni podaci", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                
            }
            catch (Exception)
            {
                
                MessageBox.Show("Unesen neispravan tip podatka u polja", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
