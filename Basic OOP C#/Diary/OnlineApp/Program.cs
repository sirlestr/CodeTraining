using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineApp
{
    class Program
    {
        static void Main(string[] args)
        {

            LinkedList<Zaznam> denik = new LinkedList<Zaznam>();
            LinkedListNode<Zaznam> aktualniZaznamUzel = denik.First;
            string prikaz = "";
            bool naNovyZaznam = false;

            do
            {
                VytiskniMenu();
                Console.WriteLine("\nPočet záznamů: {0}", denik.Count);

                if (aktualniZaznamUzel != null && !naNovyZaznam)
                    ZobrazZaznam(aktualniZaznamUzel.Value);

                if (naNovyZaznam)
                {
                    Zaznam zaznam = PridejZaznam();
                    aktualniZaznamUzel = denik.AddLast(zaznam);

                    naNovyZaznam = false;
                    continue;
                }

                Console.WriteLine("Zadej příkaz: ");
                prikaz = Console.ReadLine();

                switch (prikaz)
                {
                    case "predchozi":
                        if (aktualniZaznamUzel != null && aktualniZaznamUzel.Previous != null)
                            aktualniZaznamUzel = aktualniZaznamUzel.Previous;
                        break;
                    case "dalsi":
                        if (aktualniZaznamUzel != null && aktualniZaznamUzel.Next != null)
                            aktualniZaznamUzel = aktualniZaznamUzel.Next;
                        break;
                    case "novy":
                        naNovyZaznam = true;
                        break;
                    case "smaz":
                        if (aktualniZaznamUzel == null)
                            break;
                        if (SmazZaznam(aktualniZaznamUzel.Value))
                        {
                            denik.Remove(aktualniZaznamUzel.Value);
                            aktualniZaznamUzel = denik.Count != 0 ? denik.First : null;
                        }
                        break;
                }

            } while (prikaz != "zavri");

            static Zaznam PridejZaznam()
            {
                Console.Write("\nDatum: ");
                DateTime noveDatum;
                while (!DateTime.TryParse(Console.ReadLine(), out noveDatum))
                    Console.Write("Chybné zadání, zadejte znovu: ");

                VytiskniMenu();
                Console.WriteLine("\nDatum: " + noveDatum.ToString(" d. M. yyyy"));

                Console.WriteLine("\nText:\n");
                string radek = "";
                string text = "";

                do
                {
                    text += radek + "\n";
                    radek = Console.ReadLine();
                }
                while (radek != "uloz");

                Console.WriteLine("\n-------------------------------------------------------");

                return new Zaznam(noveDatum, text.Trim());
            }

            static bool SmazZaznam(Zaznam zaznam)
            {
                Console.Clear();
                ZobrazZaznam(zaznam);
                Console.WriteLine("Smazat záznam? [a/n]");
                string volba = Console.ReadLine();
                return volba.Contains("a") ? true : false;
            }

            static void ZobrazZaznam(Zaznam zaznam)
            {
                Console.WriteLine("\nDatum: " + zaznam.Datum.ToString(" d. M. yyyy"));
                Console.WriteLine("\n" + zaznam.Text);
                Console.WriteLine("\n-------------------------------------------------------\n");
            }

            static void VytiskniMenu()
            {
                Console.Clear();
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("Deník se ovládá následujícími příkazy:");
                Console.WriteLine("- predchozi: Přesunutí na předchozí záznam");
                Console.WriteLine("- dalsi: Přesunutí na další záznam");
                Console.WriteLine("- novy: Vytvoření nového záznamu");
                Console.WriteLine("- uloz: Uložení vytvořeného záznamu");
                Console.WriteLine("- smaz: Odstranění záznamu");
                Console.WriteLine("- zavri: Zavření deníku");
                Console.WriteLine("-------------------------------------------------------\n");
            }
        }
    }
}

