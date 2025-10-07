using System;
using System.Collections.Generic;
using System.IO;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base(
        "Listing Activity",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
    )
    {
        _count = 0;
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
    public List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            // Use Console.ReadLine() to get user input
            string item = Console.ReadLine();
            
            // Check if user is done or if it's past the time
            if (string.IsNullOrWhiteSpace(item))
            {
                // If the user enters nothing, they might be done or pausing
            }
            else
            {
                items.Add(item);
            }
        }
        return items;
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();

        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($" --- {GetRandomPrompt()} --- ");

        Console.Write("You may begin in: ");
        ShowCountDown(5); // 5-second thinking countdown
        Console.WriteLine();
        
        List<string> userItems = GetListFromUser();
        _count = userItems.Count; // Set the count

        Console.WriteLine($"\nYou listed {_count} items!");
        
        DisplayEndingMessage();
    }
}