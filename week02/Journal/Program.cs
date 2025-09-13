using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {


        Journal journal = new Journal();
        string choice = "";

        while (choice != "5")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                journal.AddEntry();
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("Enter filename to load from: ");
                string loadFilename = Console.ReadLine();
                journal.LoadFromFile(loadFilename);
            }
            else if (choice == "4")
            {
                Console.Write("Enter filename to save to: ");
                string saveFilename = Console.ReadLine();
                journal.SaveToFile(saveFilename);
            }
            else if (choice != "5")
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Goodbye!");
    }      
}