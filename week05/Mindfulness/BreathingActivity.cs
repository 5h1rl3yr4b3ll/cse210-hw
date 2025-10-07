using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

public class BreathingActivity : Activity
{
    public BreathingActivity(): base(
        "Breathing Activity",
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {

    }
    public void Run()
    {
        Console.Clear();

        DisplayStartingMessage();

        Console.WriteLine();
        Console.WriteLine("Begin the breathing cycle.");

        // Loop until the total duration is reached
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            // Check if there's enough time left for a full breath cycle (e.g., 4s in, 6s out)
            if ((endTime - DateTime.Now).TotalSeconds < 10)
            {
                // If not, break early or complete the current cycle if possible
                break; 
            }

            // Breathe in
            Console.Write("Breathe in...");
            ShowCountDown(4); // 4 seconds in
            Console.WriteLine();

            // Breathe out
            Console.Write("Now breathe out...");
            ShowCountDown(6); // 6 seconds out
            Console.WriteLine();
            Console.WriteLine(); // Add a blank line for separation
        }

        DisplayEndingMessage();
    }
}