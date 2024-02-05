namespace OnlineApp
{
    class Diar
    {

        private Databaze databaze;

        public Diar()
        {
            databaze = new Databaze();
        }

        private DateTime ZjistiDatumCas()
        {
            Console.WriteLine("Zadejte datum a čas ve tvaru [1.1.2023 14:00]");
            DateTime datumCas;
            while (!DateTime.TryParse(Console.ReadLine(), out datumCas))
            {
                Console.WriteLine("Chybné zadání, zadejte znovu datum a čas");

            }
            return datumCas;
        }

        public void VypisZaznamy(DateTime den)
        {
            List<Zaznam> zaznamy = databaze.NajdiZaznamy(den, false);
            foreach (Zaznam z in zaznamy)
            {
                Console.WriteLine(z);
            }

        }

        public void PridejZaznam()
        {
            DateTime datumCas = ZjistiDatumCas();
            Console.WriteLine("zadej text zaznamu : ");
            string text;
            while (string.IsNullOrEmpty(text = Console.ReadLine()))
            {
                Console.WriteLine("zadej text znovu");

            }
            databaze.PridejZaznam(datumCas, text);


        }


        public void VyhledejZáznamy()
        {
            //zadáni dat uzivatelem
            DateTime datumCas = ZjistiDatumCas();
            //vyhledani zaznamu
            List<Zaznam> zaznamy = databaze.NajdiZaznamy(datumCas, false);
            //výpis záznamu
            if (zaznamy.Count > 0)
            {
                Console.WriteLine("Nalezeny tyto Záznamy: ");
                foreach (Zaznam z in zaznamy)
                {
                    Console.WriteLine(z);
                }
            }
            else
            {
                //nenalezeno
                Console.WriteLine("nebyly nalezeny žádné záznamy");
            }
        }

        public void VymazZaznamy()
        {
            Console.WriteLine("Budou vymázány záznamy v daný den a hodinu");
            DateTime datumCas = ZjistiDatumCas();
            databaze.VymazZaznamy(datumCas);
        }

        public void VypisUvodniObrazovku()
        {
            Console.Clear();
            Console.WriteLine("Vítejte v diáři");
            Console.WriteLine("Dnes je : {0}", DateTime.Now);
            Console.WriteLine();
            //výpis hlavní obrazovky 
            Console.WriteLine("Dnes : \n-----");
            VypisZaznamy(DateTime.Today);
            Console.WriteLine();
            Console.WriteLine("Zítra : \n-----");
            VypisZaznamy(DateTime.Today.AddDays(1));
            Console.WriteLine();
        }
    }
}
