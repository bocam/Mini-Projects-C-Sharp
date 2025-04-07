using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prodaja_karata
{
    class Karta
    {

        public string lokacijaKlase
        {
            get;
            set;
        }
        public int cijenaKlase
        {
            get;
            set;

        }

        public Karta(string lokacijaKlase, int cijenaKlase) 
        {
            this.cijenaKlase = cijenaKlase;
            this.lokacijaKlase = lokacijaKlase;
        }

        public override string ToString()
        {
            return lokacijaKlase +"\n";
        }
    }
}
