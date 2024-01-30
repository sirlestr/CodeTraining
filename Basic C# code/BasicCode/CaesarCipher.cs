internal class Program
{
    private static void Main(string[] args)
    {
        private static void Main(string[] args)
        {


            Console.WriteLine("Enter text:");
            string input = Console.ReadLine();
            Console.WriteLine("Original message: {0}", input);
            string encryptedMessage = "";
            int shift = 3;

            foreach (char c in input)
            {
                int asciiValue = (int)c;
                asciiValue += shift;

                if (asciiValue >= (int)'z')
                {
                    asciiValue -= 26;
                }

                char encryptedChar = (char)asciiValue;
                encryptedMessage += encryptedChar;
            }

            Console.WriteLine("Encrypted message: {0}", encryptedMessage);
            Console.ReadKey();
        }
    }
}