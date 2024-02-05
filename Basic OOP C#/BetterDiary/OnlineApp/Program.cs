namespace OnlineApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //instance Diáře :
            Diar diar = new Diar();
            char volba = '0';
            //hlavní cyklus
            while (volba != '4')
            {
                diar.VypisUvodniObrazovku();
                Console.WriteLine();
                Console.WriteLine("Vyberte následující operaci : ");
                Console.WriteLine("1 - Přidat záznam");
                Console.WriteLine("2 - Vyhledat záznam");
                Console.WriteLine("3 - Vymazat záznam ");
                Console.WriteLine("4 - Konec programu");
                volba = Console.ReadKey().KeyChar;
                Console.WriteLine();
                switch (volba)
                {
                    case '1':
                        diar.PridejZaznam();
                        break;
                    case '2':
                        diar.VyhledejZáznamy();
                        break;
                    case '3':
                        diar.VymazZaznamy();
                        break;
                    case '4':
                        Console.WriteLine("Libovolnou klávesou ukončíte program");
                        break;
                    default: 
                        Console.WriteLine("Neplatná volba, zadejte znovu");
                        break;
                }
                Console.ReadKey();
            }






        }
    }
}