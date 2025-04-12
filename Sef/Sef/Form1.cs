using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;


namespace Sef
{
    public partial class Form1 : Form
    {
       public string  password = "";
       public string poruka_iz_textboxa = "";
       public string da_li_je_otkljucano = "";
        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
            lblVrijeme.Text = DateTime.Now.ToString("hh:mm \\(dd.mm.yyyy.\\)");
            Ponovno_pokretanje();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblVrijeme.Text = DateTime.Now.ToString("h:mm \\(dd.M.yyyy.\\)");
        }


        public string Crypt(string text) 
        { 
            return Convert.ToBase64String(ProtectedData.Protect(Encoding.Unicode.GetBytes(text), null, DataProtectionScope.CurrentUser)); 
        }

        public string Decrypt(string text) 
        { 
            return Encoding.Unicode.GetString(ProtectedData.Unprotect(Convert.FromBase64String(text), null, DataProtectionScope.CurrentUser)); 
        }


        private void btn1_Click(object sender, EventArgs e)

        {
            Button btn=(Button) sender;

            foreach (Control kontrola in tableLayoutPanel1.Controls)
            {

                if (kontrola is Button)
                {
                    if (btn.Text == kontrola.Text)
                    {
                        txtPassword.Text += kontrola.Text;
                    }

                }

            }

        }

        private void btnZakljucaj_Click(object sender, EventArgs e)
        {
           
                if (btnZakljucaj.Text == "Zakljucaj")
                {
                    if (txtPoruka.Text.Length > 0 && txtPassword.Text.Length > 0)
                    {


                        string tekst = txtPoruka.Text;
                        txtPoruka.Text = Crypt(tekst);

                        poruka_iz_textboxa = txtPoruka.Text; //radi snimanja

                        

                    }
                    else
                    {
                        MessageBox.Show("niste upisali password ili poruku");
                        txtPassword.Clear();
                        return;
                    }


                        btnZakljucaj.Text = "Otkljucaj";
                        da_li_je_otkljucano = "Otkljucaj";
                        pcbSlika.Image = Image.FromFile(@"Resources\Zakljucano.png");
                       
                        //txtPoruka.Enabled = false;
                        password = txtPassword.Text;
                        txtPassword.Clear();
                        txtPassword.Focus();
                        SnimiPromjene();
                    
                  


                }
                else if (btnZakljucaj.Text == "Otkljucaj")
                {
                    if (txtPassword.Text == password)
                    {
                        string tekst_dekript = txtPoruka.Text;
                       
                        btnZakljucaj.Text = "Zakljucaj";
                        da_li_je_otkljucano = "Zakljucaj";
                        txtPoruka.Text = Decrypt(tekst_dekript);
                        poruka_iz_textboxa = txtPoruka.Text;

                        txtPassword.Clear();
                        pcbSlika.Image = Image.FromFile(@"Resources\Otkljucano.png");
                        SnimiPromjene();

                    }
                    else
                    {
                        txtPassword.Clear();
                        MessageBox.Show("Neispravan password\nPokusajte ponovo!!!");
                        
                    }
                }

            
          



        }

    

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                e.SuppressKeyPress = true;
                btnZakljucaj.PerformClick();
               
            }
          
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                txtPassword.Text = txtPassword.Text.Remove(txtPassword.Text.Length - 1);
            }
            catch (Exception) 
            {
                MessageBox.Show("nemate nista upisano u text boxu");
            }
        }



        private void SnimiPromjene() 
        {
            Properties.Settings.Default.Otkljucano_Zakljucano = da_li_je_otkljucano;
            Properties.Settings.Default.poruka = poruka_iz_textboxa;
            Properties.Settings.Default.password = password;
            Properties.Settings.Default.Save();
        }



        private void Ponovno_pokretanje() 
        {
            poruka_iz_textboxa = Properties.Settings.Default.poruka;
            password = Properties.Settings.Default.password;
            da_li_je_otkljucano = Properties.Settings.Default.Otkljucano_Zakljucano;
            if (da_li_je_otkljucano == "Otkljucaj") 
            {
                pcbSlika.Image = Properties.Resources.Zakljucano;
                btnZakljucaj.Text = "Otkljucaj";
                txtPoruka.Text = poruka_iz_textboxa;
            }
            else if (da_li_je_otkljucano == "Zakljucaj") 
            {
                btnZakljucaj.Text = "Zakljucaj";
                pcbSlika.Image = Properties.Resources.Otkljucano;
                txtPoruka.Text = poruka_iz_textboxa;
                
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '1' && e.KeyChar <= '9')
            {
                foreach (Control kontrola in tableLayoutPanel1.Controls)
                    if (kontrola is Button)
                    {
                        Button taster = (Button)kontrola;
                        if (taster.Text == e.KeyChar.ToString())
                            taster.PerformClick();

                    }

            }
            e.Handled = true;
        }




    }

}
