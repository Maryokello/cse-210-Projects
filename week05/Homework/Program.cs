// Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Mary Okello", "C# Classes and Inheritance");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment math = new MathAssignment("Mary Okello", "Fractions", "7.3", "8-19");
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());

        WritingAssignment writing = new WritingAssignment("Mary Okello", "European History", "The Causes of World War II");
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
    }
}
