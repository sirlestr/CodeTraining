// this code was created based on input from ItNetvork.cz in C# tutorial

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter text to encrypt: ");
        string text = Console.ReadLine().ToLower();
        Console.Write("Enter password: ");
        string password = Console.ReadLine().ToLower();
        int shift;
        string encryptedText = "";

        for (int i = 0; i < text.Length; i++)
        {
            char character = text[i];
            int number = (int)character;
            shift = i % password.Length;
            number = (int)character + ((int)password[shift] - 96);
            if (number > (int)'z')
            {
                number -= 26;
            }
            character = (char)number;
            encryptedText += character;
        }
        Console.WriteLine(encryptedText);
        Console.ReadKey();
    }
}