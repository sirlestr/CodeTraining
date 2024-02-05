internal class Friday13thCounter
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Pro zadaný interval data vypíše všechny pátky 13.:");
        Console.WriteLine("Zadejte 1. datum:");
        DateTime datum1 = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Zadejte 2. datum:");
        DateTime datum2 = DateTime.Parse(Console.ReadLine());



        Console.Write("Pátky 13.:");

        for (DateTime d = datum1; d <= datum2; d = d.AddDays(1))
        {
            if (d.DayOfWeek == DayOfWeek.Friday && d.Day == 13)
            {
                Console.Write(d.ToShortDateString() + ", ");
            }

        }
    }
}