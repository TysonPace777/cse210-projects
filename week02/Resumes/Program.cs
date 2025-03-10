using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "CEO";
        job1._startYear = 2019;
        job1._endYear = 2024;

        job1.Display();

        Resume resume1 = new Resume();
        resume1._member = "Allison Rose";
        resume1._jobs.Add(job1);

        resume1.Display();
    }
}