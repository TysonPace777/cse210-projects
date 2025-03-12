using System.Xml.Serialization;

public class Prompt
{
    public static string Random()
    {
        Random rand = new Random();

        int choice = rand.Next(5);

        string prompt = "";

        if (choice == 0)
        {
            string prompt1 = "Who played an important role in my day today?";
            Console.WriteLine("Who played an important role in my day today?");
            prompt = prompt1;
        }
        else if (choice == 1)
        {
            string prompt2 = "What was the highlight of my day?";
            Console.WriteLine("What was the highlight of my day?");
            prompt = prompt2;
        }
        else if (choice == 2)
        {
            string prompt3 = "How did I see the hand of the Lord in my life today?";
            Console.WriteLine("How did I see the hand of the Lord in my life today?");
            prompt = prompt3;
        }
        else if (choice == 3)
        {
            string prompt4 = "Who did I serve in some important way today?";
            Console.WriteLine("Who did I serve in some important way today?");
            prompt = prompt4;
        }
        else if (choice == 4)
        {
            string prompt5 = "If there was something I could do over today, what would it be?";
            Console.WriteLine("If there was something I could do over today, what would it be?");
            prompt = prompt5;
        }
        return prompt;
    }
}