using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace OnlineAPP
{
    internal class GeneratorVet
    {
        private string[] podnet = { "jednorožec", "programátor", "manažer", "hroch", "T - rex" };
        private string[] prisudek = { "spal", "ležel", "vařil", "uklízel", "derivoval"};
        private string[] privlastek = { "modrý", "velký", "hubený", "nejlepší", "automatizovaný" };
        private string[] prislovce = { "rychle", "s oblibou", "hodně", "málo", "se zpožděním" };
        private string[] prislovecneUrceniMista = { "pod stolem", "v lese", "u babičky", "v práci", "na stole" };
        private int[] vyber = {0,0,0,0,0 };
        private Random rnd = new Random();
        private string[] veta = new string[5];




        







        // skladba věty : přívlastek, podnět,příslovce,přísudek,příslověčné určení místa

        /// <summary>
        /// funkce poskladej Větu
        /// </summary>
        public void PoskladejVetu()
        {
            // generovani cisla na pozice textu
            for (int i = 0; i < vyber.Length; i++)
            {
                vyber[i] = rnd.Next(0, 5);
            }
            //prasacky zpusob jak poskladat pole s větou
            veta[0] = privlastek[vyber[0]];
            veta[1] = podnet[vyber[1]];
            veta[2] = prislovce[vyber[2]];
            veta[3] = prisudek[vyber[3]];
            veta[4] = prislovecneUrceniMista[vyber[4]];

            //vypsani vysledne vety

            Console.WriteLine("{0} {1} {2} {3} {4}", veta[0], veta[1], veta[2], veta[3], veta[4]);


        }






    }
}
