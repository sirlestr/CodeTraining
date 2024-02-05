namespace OnlineApp
{


    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> categories = new Dictionary<int, string>
        {
            { 0, "Ovoce a zelenina" },
            { 1, "Luštěniny" },
            { 2, "Pečivo" },
            { 3, "Mléčné výrobky" },
            { 4, "Maso" },
            { 5, "Sladkosti" },
            { 6, "Nápoje" },
            { 7, "Ostatní" }
        };

            foreach (var category in categories)
            {
                Console.WriteLine($"[{category.Key}]: {category.Value.ToLower()}");
            }
            Console.WriteLine("-------------------------------------");

            Dictionary<int, List<Polozka>> shoppingList = new Dictionary<int, List<Polozka>>();

            // Zadání položek
            bool addAnotherItem = true;
            while (addAnotherItem)
            {
                Console.Write("Položka: ");
                string itemName = Console.ReadLine();

                Console.Write("Kategorie: ");
                int categoryIndex = int.Parse(Console.ReadLine());

                if (!shoppingList.ContainsKey(categoryIndex))
                {
                    shoppingList[categoryIndex] = new List<Polozka>();
                }

                shoppingList[categoryIndex].Add(new Polozka { Name = itemName, Category = categories[categoryIndex] });

                Console.Write("Přidat další položku [ano/ne]: ");
                string input = Console.ReadLine().ToLower();
                addAnotherItem = (input == "ano" || input == "a");

            }

            // Seskupení položek podle kategorií
            var groupedItems = shoppingList.SelectMany(pair => pair.Value)
                                           .GroupBy(item => item.Category)
                                           .ToDictionary(group => group.Key, group => group.ToList());

            // Výpis výsledků
            Console.WriteLine("-------------------------------------");

            foreach (var category in categories)
            {
                Console.Write($"{category.Value.ToUpper()}: ");
                if (groupedItems.ContainsKey(category.Value))
                {
                    Console.WriteLine(string.Join(", \n", groupedItems[category.Value]));

                }
                else
                {
                    Console.WriteLine("-");
                }
                Console.WriteLine();
            }
        }
    }
}