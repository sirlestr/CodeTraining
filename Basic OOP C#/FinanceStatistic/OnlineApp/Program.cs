namespace OnlineApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] mesice = { "leden", "únor", "březen", "duben", "květen", "červen", "červenec", "srpen", "září", "říjen", "listopad", "prosinec" };

            List<MesicniVydelek> list = new List<MesicniVydelek>();


            for (int i = 0; i < 12; i++)
            {
                Console.Write("Zadej výdělěk za měsíc " +mesice[i] + ": ");
                double castka;
                if (!double.TryParse(Console.ReadLine(), out castka))
                    castka = 0;
                list.Add(new MesicniVydelek(i, castka));
            }

            var totalEarnings = list.Sum(m => m.Vydelek);
            var averageEarnings = list.Average(m => m.Vydelek);
            var minEarnings = list.Min(m => m.Vydelek);
            var maxEarnings = list.Max(m => m.Vydelek);
            var profitablelistCount = list.Count(m => m.Vydelek > 0);
            var losslistCount = list.Count(m => m.Vydelek < 0);
            var firstProfitableMonth = list.FirstOrDefault(m => m.Vydelek > 0);
            var lastProfitableMonth = list.LastOrDefault(m => m.Vydelek > 0);


            Console.WriteLine();
            Console.WriteLine("Celkový výdělek: "+totalEarnings +" Kč");
            Console.WriteLine("Průměrný výdělek: " + averageEarnings + " Kč");
            Console.WriteLine("Nejmenší výdělek: " + minEarnings + " Kč");
            Console.WriteLine("Největší výdělek: " + maxEarnings + " Kč");
            Console.WriteLine("Počet výdělečných měsíců: " + profitablelistCount);
            Console.WriteLine("Počet prodělečných měsíců: " + losslistCount);
            Console.WriteLine("První výdělečný měsíc: " + mesice[firstProfitableMonth.Mesic]);
            Console.WriteLine("Poslední výdělečný měsíc: " + mesice[lastProfitableMonth.Mesic]);


        }
    }
}