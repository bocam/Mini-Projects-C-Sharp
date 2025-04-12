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
    public partial class NoviKontakt : Form
    {   public string imeNovog,prezimeNovog,telefonNovog,emailNovog,slikaNovog;
    
        public NoviKontakt()
        {
            InitializeComponent();
            btnSnimi.Enabled = false;


        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {



            if (txtIme.Text.Length > 0 && txtPrezime.Text.Length > 0 && txtTelefon.Text.Length > 0)
            {

                if (rdbMuski.Checked == true)
                {
                    slikaNovog = "MenGeneric.jpg";
                }
                else if (rdbZenski.Checked == true)
                {
                    slikaNovog = "WomenGeneric.jpg";
                }

                imeNovog = txtIme.Text;
                prezimeNovog = txtPrezime.Text;
                emailNovog = txtEmail.Text;
                telefonNovog = txtTelefon.Text;

                this.DialogResult = DialogResult.OK;

            }
            else 
            {

                MessageBox.Show("popuniti polja za ime,prezime i telefon","Greska",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
               
                
                   
                
            
           
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {
            if (txtIme.Text.Length > 0 && txtPrezime.Text.Length > 0 && txtTelefon.Text.Length > 0)
            {
                btnSnimi.Enabled = true;
            }
            else 
            {
                btnSnimi.Enabled = false;
            }
        }

      

      

       
    }
}
