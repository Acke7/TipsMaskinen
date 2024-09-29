using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipsMaskinen
{
    internal class Novellsamling : Bok
    {
        public Novellsamling(string titel, string författare, bool tillgänglig) : base(titel, författare, "Novellsamling", tillgänglig) { }
    }
}
