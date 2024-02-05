using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineApp
{
    internal class MesicniVydelek
    {
        public int Mesic { get; private set; }
        public double Vydelek { get; private set; }

        public MesicniVydelek(int mesic, double vydelek)
        {
            Mesic = mesic;
            Vydelek = vydelek;
        }

    }
}
