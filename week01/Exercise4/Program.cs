using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Transactions;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> nums = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        string input = Console.ReadLine ();
        int numbers = int.Parse(input);
        nums.Add(numbers);

        while (numbers != 0)
        {
            Console.WriteLine("Enter number:");
            input = Console.ReadLine();
            numbers = int.Parse(input);
            if (numbers != 0)
            {
                nums.Add(numbers);
            }
        }
            if (numbers == 0)
            {
                int summed = 0;
                float average = 0;
                int largest = 0;
                int count = nums.Count;
                foreach (int number in nums)
                {
                    summed += number;
                    if (number > largest)
                    {
                        largest = number;
                    }
                }
                average = (float)summed / count;
                Console.WriteLine($"The sum is: {summed}");
                Console.WriteLine($"The average is: {average}");
                Console.WriteLine($"The largest number is: {largest}");
            }
    }
}