using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineApp
{
    internal class Hra
    {
        public Lokace poziceHrace;

        /// <summary>
        /// vytvoří instanci hry
        /// </summary>
        public Hra()
        {
            Lokace hrad = new Lokace("Hrad", "Stojíš před okovanou branou gotického hradu, " +
                    "která je zřejmě jediným vchodem do pevnosti. Klíčová dírka je pokryta pavučinami, " +
                    "což vzbuzuje dojem, že je budova opuštěná.");
            Lokace les = new Lokace("Les", "Jsi na lesní cestě, která se klikatí až za obzor, " +
                    "kde mizí v siluetě zapadajícího slunce. Ticho podvečerního lesa občas přeruší zpěv posledních " +
                    "ptáků.");
            Lokace lesniCesta = new Lokace("Lesní rozcestí", "Nacházíš se na lesním rozcestí.");
            Lokace les2 = new Lokace("Les", "Jsi na lesní cestě, která se klikatí až za obzor, " +
                    "kde mizí v siluetě zapadajícího slunce. Ticho podvečerního lesa občas přeruší zpěv posledních " +
                    "ptáků.");
            Lokace rybnik = new Lokace("Rybník", "Došel jsi ke břehu malého rybníka. Hladina je v bezvětří " +
                    "jako zrcadlo. Kousek od tebe je dřevěná plošina se stavidlem.");
            Lokace les3 = new Lokace("Les", "Jsi na lesní cestě, která se klikatí až za obzor, " +
                    "kde mizí v siluetě zapadajícího slunce. Ticho podvečerního lesa občas přeruší zpěv posledních " +
                    "ptáků.");
            Lokace dum = new Lokace("Dům", "Stojíš před svým rodným domem, cítíš vůni čerstvě nasekaného dřeva, " +
                    "která se line z hromady vedle vstupních dveří.");
            poziceHrace = dum;
            dum.zapad = les;
            les.vychod = dum;
            les.sever = lesniCesta;
            lesniCesta.vychod = les2;
            lesniCesta.jih = les;
            lesniCesta.zapad = les3;
            les2.vychod = rybnik;
            les2.zapad = lesniCesta;
            rybnik.zapad = les2;
            les3.vychod = lesniCesta;
            les3.zapad = hrad;
            hrad.vychod = les3;
        }

        /// <summary>
        /// odstartuje hru
        /// </summary>
        public void StartHry()
        {
            bool konec = false;
            Console.Write(poziceHrace);
            string vstupOdHrace = "";

            while (!konec)
            {
                vstupOdHrace = Console.ReadLine().ToLower();
                if (vstupOdHrace == "konec")
                {
                    konec = true;
                    break;
                }
                else if (vstupOdHrace == "jdi na sever" || vstupOdHrace == "jdi na jih" || vstupOdHrace == "jdi na východ" || vstupOdHrace == "jdi na západ")
                {
                    if (poziceHrace.NovaPozice(vstupOdHrace) != null)
                    {
                        poziceHrace = poziceHrace.NovaPozice(vstupOdHrace);
                        Console.Write(poziceHrace);

                    }
                    else
                    {
                        Console.Write("Tímto směrem nelze jít.\n");
                        Console.Write(poziceHrace);
                    }

                }
                else
                {
                    Console.Write("Můj vstupní slovník neobsahuje tento příkaz.\n");
                    Console.Write(poziceHrace);
                }



            }


        }


    }
}
