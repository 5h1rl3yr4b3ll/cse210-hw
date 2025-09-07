using System;
using System.Formats.Asn1;
using System.Globalization;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();

        int number = -1;

        while (number != 0)
        {
            Console.Write("Enter a number: ");
            string userNumber = Console.ReadLine();
            number = int.Parse(userNumber);

            if (number != 0)
            {
                numbers.Add(number);
            }

        }

        int sum = 0;
        foreach (int value in numbers)
        {
            sum += value;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum / numbers.Count);
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];

        foreach (int value in numbers)
        {
            if (value > max)
            {
                max = value;
            }
        }

        Console.WriteLine($"The mas is: {max}");

    }
}