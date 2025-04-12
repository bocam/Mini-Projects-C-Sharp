using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK_kafic
{
    class Artikl
    {
       public string nazivArtikla { get; set; }
        public float cijenaArtikla { get; set; }

        public Artikl(string naziv, float cijena)
        {
            this.nazivArtikla = naziv;
            this.cijenaArtikla = cijena;

        }
        public override string ToString()
        {
            return nazivArtikla + "\t\t" +  cijenaArtikla.ToString("0.#0 KM");
        }
    }
}
