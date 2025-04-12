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
    public partial class Formlogin : Form
    {

        
        public Formlogin()
        {
         
            InitializeComponent();

            btnClear.Enabled = false;
            btnEnter.Enabled = false;
            //da bi na formi registrovali pritisak na neki taster na tastaturi
            this.KeyPreview = true;
            lblVrijeme.Text = DateTime.Now.ToString("\\da\\tu\\m :  dd.MM.yyyy.  HH:mm tt");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblVrijeme.Text = DateTime.Now.ToString("\\Da\\tu\\m : dd.MM.yyyy. HH:mm tt");
        }




        private void taster_Click(object sender, EventArgs e)
        {
            //ove dvije linije koda isto znacenje // Button taster = sender as Button;
            if (txtPIN.Text.Length < 8)
            {
           
                Button taster = (Button)sender;
                txtPIN.Text += taster.Text;
               
            }
            txtPIN.Focus();
            txtPIN.DeselectAll();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPIN.Text = "";
            txtPIN.Focus();
            //txtPIN.Clear();

        }
        private void btnEnter_Click(object sender, EventArgs e)
        {

            if (txtPIN.Text == "1234")
            {
                this.Hide();
                FormaRacun frmRacun = new FormaRacun(Properties.Resources.konobar,"Petar Petrovic","Racun -Petar Petrovic");
                frmRacun.ShowDialog();
                this.Show();
                txtPIN.Clear();

            }
            else if (txtPIN.Text == "4321")
            {
                this.Hide();
                FormaRacun frmRacun = new FormaRacun(Properties.Resources.konobarica, "Ivana Ivanovic","Racun -Ivana Ivanovic");
                frmRacun.ShowDialog();
                this.Show();
                txtPIN.Clear();
            }
            else
            {
                MessageBox.Show("Neispravan PIN kod", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPIN.Clear();
                txtPIN.Focus();

            }
            //MessageBox.Show("pritisnut enter");
            //txtPIN.Focus();
            //txtPIN.DeselectAll();
        }



        private void txtPIN_TextChanged(object sender, EventArgs e)
        {
            if (txtPIN.Text.Length > 0)
            {
                btnClear.Enabled = true;
            }
            else
            {
                btnClear.Enabled = false;
            }

            if (txtPIN.Text.Length >= 4)
            {

                btnEnter.Enabled = true;
            }
            else
            {
                btnEnter.Enabled = false;
            }
        }

        private void Formlogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                foreach (Control kontrola in tableLayoutPanel1.Controls)
                    if (kontrola is Button)
                    {
                        Button taster = (Button)kontrola;
                        if (taster.Text == e.KeyChar.ToString())
                            taster.PerformClick();

                    }

            }

            //e.Handled=true;  //posto se keypress izvrsio ne salji ga drugim 
                                    //kontrolama

        }

        private void Obrisi()
        {
            txtPIN.Text = "";
        }

        private void Formlogin_KeyDown(object sender, KeyEventArgs e)
        {
            foreach (Control kontrola in tableLayoutPanel2.Controls)
                if (kontrola is Button)
                {
                    Button taster = kontrola as Button;
                    if (taster.Text == "Clear" && e.KeyCode == Keys.Delete)
                        btnClear.PerformClick();

                    if (taster.Text == "Enter" && e.KeyData == Keys.Enter)
                        btnEnter.PerformClick();

                }

        }

       
    }
}
