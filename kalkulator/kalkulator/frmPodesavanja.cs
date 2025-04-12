using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kalkulator
{
    public partial class frmPodesavanja : Form
    {
        public frmPodesavanja()
        {
            InitializeComponent();
            txtMinKredita.Text = Properties.Settings.Default.minKredita.ToString();
            txtMaxKredita.Text = Properties.Settings.Default.maksKredita.ToString();
            txtMinMjeseci.Text = Properties.Settings.Default.minMjeseci.ToString();
            txtMaxMjeseci.Text = Properties.Settings.Default.maksMjeseci.ToString();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtMaxKredita.Text) < int.Parse(txtMinKredita.Text)) 
            {
                MessageBox.Show("Maksimalna vrijednost iznosa kredita ne moze biti manja od minimalne","Greska",MessageBoxButtons.OK,MessageBoxIcon.Error); 
            }
            else if (int.Parse(txtMaxMjeseci.Text) < int.Parse(txtMinMjeseci.Text))
                MessageBox.Show("Maksimalna vrijednost broja mjeseci  ne moze biti manja od minimalne", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {


                try
                {
                    Properties.Settings.Default.minKredita = int.Parse(txtMinKredita.Text);
                    Properties.Settings.Default.maksKredita = int.Parse(txtMaxKredita.Text);
                    Properties.Settings.Default.minMjeseci = int.Parse(txtMinMjeseci.Text);
                    Properties.Settings.Default.maksMjeseci = int.Parse(txtMaxMjeseci.Text);

                    Properties.Settings.Default.Save();

                    MessageBox.Show("Podaci su sacuvani!!! ", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;

                }
                catch (Exception)
                {

                    MessageBox.Show("Unesite korektan tip podatka", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }



    }
}
