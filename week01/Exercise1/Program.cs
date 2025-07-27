using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Exercise 1
        Console.WriteLine("Hello World! This is the Exercise1 Project.");
        Console.Write("What is your first name? ");
        string first = Console.ReadLine();

        Console.Write("What is your last name? ");
        string last = Console.ReadLine();

        Console.WriteLine($"Your name is {last}, {last} {first}");

        
    }
}
