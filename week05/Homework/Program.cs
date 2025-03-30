using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        Assignment assignment1 = new Assignment("Tyson", "Multiplication");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment mathassignment2 = new MathAssignment("Tyson", "Multiplication", "7.3", "8-19");
        Console.WriteLine(mathassignment2.GetHomeworkList());

        WritingAssignment writingassignment3 = new WritingAssignment("Tyson", "European History", "The causes of WW2");
        Console.WriteLine(writingassignment3.GetWritingInformation());
    }
}