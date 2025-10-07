using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    protected List<string> _animationStrings = new List<string>
    {
        "|",
        "/",
        "-",
        "\\",
        "|",
        "/",
        "-",
        "\\"
    };

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}\n");
        Console.WriteLine($"{_description}\n");
        Console.WriteLine("How long, in seconds, would you like for your session? ");

        string input = Console.ReadLine();
        int duration = int.Parse(input);

        _duration = duration;

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5); // Pause for a 5-second preparation


    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        ShowSpinner(3); // Show a brief spinner

        Console.WriteLine($"You have completed the {_name} activity in {_duration} seconds.");
        ShowSpinner(5); // Final 5-second pause
        Console.Clear();
    }

    public void ShowSpinner(int seconds)
    {

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = _animationStrings[i];
            Console.Write(s);
            Thread.Sleep(250);
            Console.Write("\b");

            i = (i+1) % _animationStrings.Count;

        }


    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b");
        }

    }
}