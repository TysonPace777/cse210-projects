using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Hello World! This is the Exercise2 Project.");

        Console.WriteLine("What is your grade percentage?");
        string grade = Console.ReadLine ();
        int number = int.Parse(grade);

        string letter = "";

        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"You have a(n) {letter}");

        if (number >= 70)
        {
            Console.Write("You passed the class");
        }
        else
        {
            Console.Write("You did not pass");
        }
    }
}