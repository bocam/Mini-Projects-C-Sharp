using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Omov_zakon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblVrijeme.Text = DateTime.Now.ToString();
            txtI.Select();
            btnIzracunaj.Enabled = false;
            txtRekv.Enabled = false;
            //rdbSerijska.Checked = true;
          
           
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblVrijeme.Text = DateTime.Now.ToString("dd. MMMM yyyy.   h:mm:ss  tt ");
          
        }

        private void btnIzracunaj_Click(object sender, EventArgs e)
        {
            float I=0 , U=0 , R=0 ;
            try
            {   
                
               
        
		 if (txtI.Text.Length > 0 && txtU.Text.Length > 0)
                {
                    
                    U = float.Parse(txtU.Text);
                    I = float.Parse(txtI.Text);

                    R = U / I;
                    txtR.Text = R.ToString("0.00  ");

                
                }
	
	    
               
             
            
                
                else if (txtI.Text.Length > 0 && txtR.Text.Length > 0)
                {
                  
                    
                        I = float.Parse(txtI.Text);
                        R = float.Parse(txtR.Text);

                        U = R * I;
                        txtU.Text = U.ToString("0.00  ");
                    
                   
                    

                }
                else if (txtR.Text.Length > 0 && txtU.Text.Length > 0)
                {

                    R = float.Parse(txtR.Text);
                    U = float.Parse(txtU.Text);

                    I = U / R;
                    txtI.Text = I.ToString("0.00  ");

                }
               
            }
            catch (Exception)
            {
                
                MessageBox.Show("Podaci koji ste unijeli nisu ispravni\nUnesite broj!!!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void txtI_TextChanged(object sender, EventArgs e)
        {
            if((txtI.Text.Length>0 &&txtR.Text.Length >0)  )
            {
            
                btnIzracunaj.Enabled=true;
         
            }
            else if (txtU.Text.Length > 0 && txtR.Text.Length > 0) 
            {
                btnIzracunaj.Enabled = true;
               
            }

            else if ((txtU.Text.Length > 0 && txtI.Text.Length > 0))
            {
                btnIzracunaj.Enabled = true;
               
            }

          
            else
            {
                btnIzracunaj.Enabled = false;
            }
        }

        private void rdbSerijska_CheckedChanged(object sender, EventArgs e)
        {   
            if(txtR1.Text.Length>0 && txtR2.Text.Length>0)
            IzracunajOtpornost(txtR1.Text, txtR2.Text);
         
            
        }

        private void txtR2_TextChanged(object sender, EventArgs e)
        {
            if (txtR1.Text.Length > 0 && txtR2.Text.Length > 0)
            {
                IzracunajOtpornost(txtR1.Text, txtR2.Text);
            }
            if (txtR1.Text.Length == 0 || txtR2.Text.Length == 0) 
            {
                txtRekv.Text = " ";
            }
        }


        private void IzracunajOtpornost(string R1String, string R2String) 
        {
            float R1 = 0, R2 = 0, Rekv = 0;
           

            try
            {
                R1 = float.Parse(R1String);
                R2 = float.Parse(R2String);

            }
            catch (Exception)
            {

                MessageBox.Show("Podaci koji ste unijeli nisu ispravni\nUnesite broj!!!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
                if (rdbSerijska.Checked ) 
                {
                    Rekv = R1 + R2;
                    txtRekv.Text = Rekv.ToString("0.00");
                  
                   
                }
                else if (rdbParalelna.Checked )
                {
                    Rekv = (R1 * R2) / (R1 + R2);
                    txtRekv.Text = Rekv.ToString("0.00");
                   
                }
                else 
                {
                    MessageBox.Show("Izaberite vezu i upisite podatke za R1 i R2", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtR1.Text = "";
                    txtR2.Text = "";
                       
                }

              

                
         

            
            
        
        }

   
   

     

      
      
    }
}
