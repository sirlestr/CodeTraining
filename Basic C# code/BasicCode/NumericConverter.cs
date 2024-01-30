class Program
{
// Convert a decimal number to a different numeral system
static void Main(string[] args) 
{
    // Get user input for the decimal number
    Console.Write("Enter a number in decimal system: ");
    int number = int.Parse(Console.ReadLine());

    // Get user input for the target numeral system
    Console.Write("Enter the numeral system (2-16): ");
    int baseSystem = int.Parse(Console.ReadLine());

    // Define characters for numeral systems up to base 16
    string characters = "0123456789ABCDEF";
    string reversedResult = "";
    string result = "";
    int intermediateResult = number;

    // Check if the base system is within the valid range
    if (baseSystem > 1 && baseSystem <= characters.Length)
    {
        // Convert the number to the chosen numeral system
        do
        {
            int remainder = intermediateResult % baseSystem;
            intermediateResult = intermediateResult / baseSystem;
            reversedResult += characters[remainder];
        }
        while (intermediateResult != 0);

        // Reverse the result to get the correct order
        for (int i = reversedResult.Length - 1; i >= 0; i--)
            result += reversedResult[i];
    }

    // Display the converted number in the chosen system
    Console.Write("The number in the chosen system: {0}", result);	
}
}