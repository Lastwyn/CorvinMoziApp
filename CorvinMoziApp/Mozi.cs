using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorvinMoziApp
{
    internal class Mozi
    {
        List<Terem> termek;

        public Mozi(List<Terem> termek)
        {
            this.termek = termek;
        }

        internal List<Terem> terem{ get => termek; set => termek = value; }
    }
}
