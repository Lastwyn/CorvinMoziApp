using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorvinMoziApp
{
    class Terem
    {
        string nev;
        int sorok;
        int szekek;
        int[,] ulesek;

        public string Nev { get => nev; set => nev = value; }
        public int Sorok { get => sorok; set => sorok = value; }
        public int Szekek { get => szekek; set => szekek = value; }
        public int[,] Ulesek { get => ulesek; set => ulesek = value; }

        public Terem(string nev, int sorok, int szekek, int[,] ulesek)
        {
            this.Nev = nev;
            this.Sorok = sorok;
            this.Szekek = szekek;
            this.Ulesek = ulesek;
        }
    }
}
