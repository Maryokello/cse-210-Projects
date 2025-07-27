using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Exercise 4
        Console.WriteLine("\nHello World! This is the Exercise4 Project.");
        List<int> numbers = new List<int>();
        int inputNumber = -1;

        while (inputNumber != 0)
        {
            Console.Write("Enter a number (0 to stop): ");
            inputNumber = int.Parse(Console.ReadLine());

            if (inputNumber != 0)
                numbers.Add(inputNumber);
        }

        int sum = numbers.Sum();
        Console.WriteLine($"The total sum is: {sum}");

        double average = numbers.Count > 0 ? (double)sum / numbers.Count : 0;
        Console.WriteLine($"The average is: {average}");

        int max = numbers.Count > 0 ? numbers.Max() : 0;
        Console.WriteLine($"The max number is: {max}");

       
    }
}
