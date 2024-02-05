namespace OnlineApp
{
    class Factorial
    {
        static List<double> factorials;

        static void Main(string[] args)
        {
            // Inicializace seznamu faktoriálů pro čísla 0 až 170
            InitializeFactorials();
            int volba = 1;
            while (volba != 0)
            {
                Console.WriteLine("Maximalni honodta 170, zadej 0 pro konec programu ");
                Console.Write("Chci vědět faktoriál čísla: ");
                int userInput;

                try
                {
                    userInput = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Neplatný vstup. Zadejte platné celé číslo.");
                    continue;
                }

                if (userInput > 170)
                {
                    Console.WriteLine("Vysoká hodnota, zade prosím v rozmezí 1-170");
                    break;
                }

                if (userInput == 0)
                {
                    Console.WriteLine("Konec programu.");
                    volba = 0;
                    break;
                }

                Console.WriteLine("!{0} = {1}\n",userInput, GetFactorial(userInput));
            }
        }

        static void InitializeFactorials()
        {
            factorials = Enumerable.Range(0, 171)
                .Select(x => ComputeFactorial(x))
                .ToList();
        }

        static double ComputeFactorial(int n)
        {
            if (n == 0)
                return 1;

            double factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

        static double GetFactorial(int n)
        {
            return factorials[n];
        }
    }
}
    
