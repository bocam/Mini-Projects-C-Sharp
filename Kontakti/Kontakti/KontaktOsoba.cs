using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kontakti
{
    class KontaktOsoba
    {
        public string ime{get ; set;}
        public string prezime { get; set; }
        public string telefon { get; set; }
        public string email { get; set; }
        public string slika { get; set; }

        public KontaktOsoba(string ime, string prezime, string telefon, string email, string slika) 
        {

            this.ime = ime;
            this.prezime = prezime;
            this.telefon = telefon;
            this.email = email;
            this.slika = slika;
        }

        public override string ToString()
        {
            return ime + " " +prezime;
        }

    }
}
