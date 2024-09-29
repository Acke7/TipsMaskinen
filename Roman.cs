using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipsMaskinen
{
    internal class Roman : Bok
    {
        public Roman(string titel, string författare, bool tillgänglig) : base(titel, författare, "Roman", tillgänglig) { }
    }

}
