namespace OnlineApp
{
    internal class StackTutorial
    {
        struct Bod
        {
            public int X { get; set; }
            public int Y { get; set; }
        }
        static void Main(string[] args)
        {

            bool konec = false;
            Bod pozice = new Bod();
            pozice.X = Console.WindowWidth / 2;
            pozice.Y = Console.WindowHeight / 2;

            Stack<Bod> postup = new Stack<Bod>();

            while (!konec)
            {
                Console.Clear();
                Console.WriteLine("Příklad použití kolece zásobník");
                Console.WriteLine("Pohyb : kurzorovné klávesy");
                Console.WriteLine("Zpět : Backspace");
                Console.WriteLine("Konec : escape");
                Console.CursorLeft = pozice.X;
                Console.CursorTop = pozice.Y;
                Console.Write("-");

                //Reakce na klávesy
                ConsoleKeyInfo c = Console.ReadKey();
                if ((c.Key == ConsoleKey.UpArrow) && (pozice.Y > 0)) pozice.Y--;
                else if ((c.Key == ConsoleKey.DownArrow) && (pozice.Y < Console.WindowHeight - 2)) pozice.Y++;
                else if ((c.Key == ConsoleKey.LeftArrow) && (pozice.X > 0)) pozice.X--;
                else if ((c.Key == ConsoleKey.RightArrow) && (pozice.X < Console.WindowWidth - 1)) pozice.X++;
                else if (c.Key == ConsoleKey.Escape) konec = true;

                if ((c.Key == ConsoleKey.Backspace) && (postup.Count > 0))
                {
                    pozice = postup.Pop();
                }
                else postup.Push(pozice);

            }
        }
    }
}