using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {       
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int num;
        do
        {
            Console.Write("Enter number: ");
            num = int.Parse(Console.ReadLine());
            if (num != 0)
            {
                numbers.Add(num);
            }
        } while (num != 0);

        int sum = numbers.Sum();
        double average = numbers.Count > 0 ? numbers.Average() : 0;
        int largest = numbers.Count > 0 ? numbers.Max() : 0;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");

        // Stretch challenge: smallest positive number
        int smallestPositive = numbers.Where(n => n > 0).DefaultIfEmpty(0).Min();
        if (smallestPositive > 0)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }

        // Stretch challenge: sorted list
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int n in numbers)
        {
            Console.WriteLine(n);
        }
    }
}