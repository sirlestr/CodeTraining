class Program
{
    // Main method
    static void Main(string[] args)
    {
        // Morse code representation of the alphabet
        string[] morseCode = {".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....",
                              "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-",
                              "...-", ".--", "-..-", "-.--", "--.."};

        // Alphabet in lowercase
        string alphabet = "abcdefghijklmnopqrstuvwxyz";

        // Prompt user to enter a message for encoding
        Console.WriteLine("Enter the message to encode:");
        // Read user input and convert to lowercase
        string message = Console.ReadLine().ToLower();
        // Initialize the encoded message
        string encodedMessage = "";

        // Iterate through each character in the message
        foreach (char letter in message)
        {
            // Find the index of the letter in the alphabet
            int index = alphabet.IndexOf(letter);
            // If the letter is found in the alphabet
            if (index >= 0)
            {
                // Append the morse code for the letter to the encoded message
                encodedMessage += morseCode[index] + " ";
            }
        }

        // Display the encoded message
        Console.WriteLine("Encoded message: {0}", encodedMessage);
    }
}