namespace OnlineApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Planeta> planety = new List<Planeta>
            {
                new Planeta("Merkur", 2440, 0, true, 440),
                new Planeta("Venuše", 12104, 0, true, 737),
                new Planeta("Země", 12756, 1, true, 287),
                new Planeta("Mars", 6792, 2, true, 210),
                new Planeta("Jupiter", 142984, 79, false, 152),
                new Planeta("Saturn", 120536, 82, false, 93),
                new Planeta("Uran", 51118, 27, false, 68),
                new Planeta("Neptun", 49528, 14, false, 53),
            };



            //planety s průměrnou teplotou vyšší 
            List<Planeta> temp = new(from t in planety
                                     where t.PrumernaTeplota > 273
                                     select t);
            //plynné planety
            List<Planeta> gas = new(from t in planety
                                    where !t.JeKamenna
                                    orderby t.Prumer descending
                                    select t);
            //kamenné planety
            List<Planeta> rock = new(from t in planety
                                     where t.JeKamenna
                                     orderby t.Prumer descending
                                     select t);
            // planety s mesícem 
            List<Planeta> moon = new(from t in planety
                                     where t.PocetMesicu > 0
                                     select t);
           

            var vetsiVenuse = from p in planety
                              let index = planety.IndexOf(p) + 1
                              where p.Prumer > planety[1].Prumer
                              select index + ". planeta - " + p.Jmeno;


            Console.WriteLine("Plynné planety");
            foreach (var t in gas)
            {
                Console.WriteLine(" " +t.Jmeno);
            }

            Console.WriteLine("Kamenné planety");
            foreach (var t in rock)
            {
                Console.WriteLine(" "+t.Jmeno);
            }

            Console.WriteLine("\nPlanety s průměrnou teplotou vyšší než 0 °C (273,15 K):");
            foreach (var t in temp)
            {
                Console.WriteLine(" "+t.Jmeno);
            }

            Console.WriteLine("\nPlanety s měsíci");
            foreach (var t in moon)
            {
                Console.WriteLine(" " + t.Jmeno);
            }

            Console.WriteLine("\nPlanety větší než Venuše:");
            foreach (var item in vetsiVenuse)
            {
                Console.WriteLine(" " + item);
            }

        }
    }
}