using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");

        List<Goal> newGoals = new List<Goal>();
        int startScore = 0;

        GoalManager start1 = new GoalManager(newGoals, startScore);
        start1.Start();
    }
}