using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipsMaskinen
{
    internal class Bok
    {
        
        //egenskaper
        public string titel; // Skapar sträng för titel
        public string författare; //Skapar sträng för författare
        public string typ; //Skapar sträng för typ
        public bool tillgänglig;
        // konstruktor
        public Bok(string titel, string författare, string typ, bool tillgänglig)
        {
            this.titel = titel;
            this.författare = författare;
            this.typ = typ;
            this.tillgänglig = tillgänglig;
        }
        public override string ToString()
        {
            if (tillgänglig)
            {
                return titel + " " + författare + " " + typ + " " + "tillgänglig";
            }
            else
            {
                return titel + " " + författare + " " + typ + " " + "otillgänglig";
            }
        }
    }
}
