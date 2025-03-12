using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        string choice = "";

        while (choice != "5")
        {
            Console.WriteLine("Choose one of these options and input the number:");
            Console.WriteLine("1: Write");
            Console.WriteLine("2: Display");
            Console.WriteLine("3: Save");
            Console.WriteLine("4: Load");
            Console.WriteLine("5: Quit");

            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Here is your prompt:");
                    string promptNumber = Prompt.Random();
                    string entry = Console.ReadLine();
                    string entryWithDate = $"{dateText} - Prompt: {promptNumber} - Entry: {entry}";
                    Display.AddEntries(entryWithDate);
                    break;
                case "2":
                    Console.WriteLine("Here are the entries:");
                    Display.Entries();
                    break;
                case "3":
                    Console.WriteLine("What do You want the file to be called?");
                    string userFile = Console.ReadLine();
                    Display.SaveEntriesToFile(userFile);
                    Console.WriteLine($"Entries have been added to {userFile}");
                    break;
                case "4":
                    Console.WriteLine("What is your file name?");
                    string readFile = Console.ReadLine();
                    Display.LoadFiles(readFile);
                    Console.WriteLine("File loaded. Input 2 to display the contents.");
                    break;
                case "5":
                    Console.WriteLine("Goodbye.");
                    break;
            }
        }
    }
}