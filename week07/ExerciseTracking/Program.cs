using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        Running r1 = new Running();
        r1.SetDate("04/15/25");
        r1.SetLength(45);
        r1.SetDistance(5);

        Cycling c1 = new Cycling();
        c1.SetDate("04/10/25");
        c1.SetLength(60);
        c1.SetSpeed(13);

        Swimming s1 = new Swimming();
        s1.SetDate("03/29/25");
        s1.SetLength(30);
        s1.SetLaps(15);

        List<Activity> activites = new List<Activity>();
        activites.Add(r1);
        activites.Add(c1);
        activites.Add(s1);

        foreach (Activity thing in activites)
        {
            string activity = thing.GetSummary();
            Console.WriteLine(activity);
        }
    }
}