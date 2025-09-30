using System;

class Program
{
    static void Main(string[] args)
    {
        Assigment a1 = new Assigment("Samuel Bennett", "Multiplication");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Roberto Rodiguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}