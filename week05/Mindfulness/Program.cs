using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        Console.WriteLine();

        string choice = "";

        while (choice != "4")
        {
            Console.WriteLine("Choose an Activity or type '4' to quit the program.");
            Console.WriteLine("Breathing Activity - 1");
            Console.WriteLine("Reflecting Activity - 2");
            Console.WriteLine("Listing Activity - 3");
            Console.WriteLine("Quit - 4");
            Console.Write("Enter Choice: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Clear();
                Activity Breathing = new Activity(choice);
                Breathing.DisplayStartingMessage();

                Console.Write("How long do you want the Breathing exercise in seconds: ");
                string length = Console.ReadLine();
                int BreathingDuration = int.Parse(length);

                BreathingActivity activity1 = new BreathingActivity(BreathingDuration);
                activity1.Run();

                Breathing.DisplayEndingMessage();
            }
            else if (choice == "2")
            {
                Console.Clear();
                Activity Reflecting = new Activity(choice);
                Reflecting.DisplayStartingMessage();

                ReflectingActivity activity2 = new ReflectingActivity();
                activity2.Run();

                Reflecting.DisplayEndingMessage();
            }
            else if (choice == "3")
            {
                Console.Clear();
                Activity Listing = new Activity(choice);
                Listing.DisplayStartingMessage();

                Console.Write("How long do you want the Breathing exercise in seconds: ");
                string count = Console.ReadLine();
                int listingDuration = int.Parse(count);

                ListingActivity activity3 = new ListingActivity(listingDuration);
                activity3.Run();

                Listing.DisplayEndingMessage();
            }
            else if (choice == "4")
            {
                break;
            }
            else
            {
                Console.WriteLine("Not an option. Please enter 1-4.");
            }
        }
    }
}