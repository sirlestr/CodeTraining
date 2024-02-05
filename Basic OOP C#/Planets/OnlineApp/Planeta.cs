using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineApp
{

    class Planeta
    {
        public string Jmeno { get; private set; }
        public int Prumer { get; private set; }
        public int PocetMesicu { get; private set; }
        public bool JeKamenna { get; private set; }
        public double PrumernaTeplota { get; private set; }

        public Planeta(string jmeno, int prumer, int pocetMesicu, bool jeKamenna, double prumernaTeplota)
        {
            Jmeno = jmeno;
            Prumer = prumer;
            PocetMesicu = pocetMesicu;
            JeKamenna = jeKamenna;
            PrumernaTeplota = prumernaTeplota;
        }
    }

}
