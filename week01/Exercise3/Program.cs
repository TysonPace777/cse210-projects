using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,100);

        int guess = 0;
        while (guess != number)
        {
        Console.WriteLine("What is your guess?");
        string userInput = Console.ReadLine ();
        guess = int.Parse(userInput);
    
        if (guess > number)
        {
            Console.WriteLine("Lower");
        }
        else if (guess < number)
        {
            Console.WriteLine("Higher");
        }
        else if (guess == number)
        {
            Console.WriteLine("You guessed it!");
        }
        }
    }
}