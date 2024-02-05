using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineApp
{
    internal class Lokace
    {
        public string nazevLokace;
        public string popisLokace;

        /// <summary>
        /// vytvoří novou instanci hry
        /// </summary>
        /// <param name="nazevLokace"></param>
        /// <param name="popisLokace"></param>
        public Lokace(string nazevLokace, string popisLokace)
        {
            this.nazevLokace = nazevLokace;
            this.popisLokace = popisLokace;
        }
        public Lokace sever;
        public Lokace jih;
        public Lokace vychod;
        public Lokace zapad;

        /// <summary>
        /// Zjištění možných směrů
        /// </summary>
        /// <returns></returns>
        private string Smer()
        {
            string smer = "Můžeš jít na";
            if (sever != null)
                smer += " sever";
            if (jih != null)
                smer += " jih";
            if (vychod != null)
                smer += " východ";
            if (zapad != null)
                smer += " západ";
            return smer;
        }

        public Lokace NovaPozice(string zvolenySmer)
        {
            Lokace novaPozice = null;
            if (zvolenySmer == "jdi na sever")
                novaPozice = sever;
            else if (zvolenySmer == "jdi na jih")
                novaPozice = jih;
            else if (zvolenySmer == "jdi na východ")
                novaPozice = vychod;
            else if (zvolenySmer == "jdi na západ")
                novaPozice = zapad;

            return novaPozice;
        }

        public override string ToString()
        {
            return String.Format("{0}\n{1}\n\n{2}\n\nZadej příkaz: ", nazevLokace, popisLokace, Smer());
        }
    }
}
