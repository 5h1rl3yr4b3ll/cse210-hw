using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Create a Reference and a Scripture object
        // We will use the John 3:16 example.
        Reference reference = new Reference("John", 3, 16);
        string text = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        
        Scripture scripture = new Scripture(reference, text);

        string userInput = "";

        // 2. Main loop runs as long as the scripture is not fully hidden AND the user hasn't typed 'quit'
        while (!scripture.IsCompletelyHidden() && userInput.ToLower() != "quit")
        {
            // Clear the console screen for a clean look
            Console.Clear();

            // Display the current state of the scripture (words or underscores)
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            // Prompt the user for input
            Console.WriteLine("Press Enter to hide more words, or type 'quit' to end the program.");
            userInput = Console.ReadLine();

            if (userInput.ToLower() != "quit")
            {
                // Hide a few more words for the user to guess next time.
                scripture.HideRandomWords(3); 
            }
        }

        // Final clear and display
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine();
        Console.WriteLine("Program ended. Well done!");
    }
}