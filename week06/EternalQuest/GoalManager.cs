using System.IO;
using System.IO.Enumeration;
public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public GoalManager(List<Goal> goals, int score)
    {
        _goals = goals;
        _score = score;
    }

    public void Start()
    {
        string choice = "";

        while (choice != "6")
        {
            Console.WriteLine("Please choose a number 1-5 or press '6' to quit.");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Choose a Menu Number: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Clear();
            }
            else if (choice == "2")
            {
                Console.Clear();
                foreach (Goal goal in _goals)
                {
                    Console.WriteLine($"{goal};");
                }
            }
            else if (choice == "3")
            {
                Console.Clear();
                Console.Write("What do you want the file to be called: ");
                string fileName = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    foreach (Goal goal in _goals)
                    {
                        outputFile.WriteLine(goal);
                    }
                }
                Console.WriteLine("Goals Saved");
            }
            else if (choice == "4")
            {
                Console.Clear();
                Console.Write("What file do you want to load: ");
                string fileName = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(fileName);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(";");
                    string name = parts[0];
                    string description = parts[1];
                    string points = parts[2];
                }
            }
            else if (choice == "5")
            {
                Console.Clear();
            }
            else if (choice == "6")
            {
                Console.WriteLine();
                Console.WriteLine("Goodbye");
                break;
            }
            else
            {
                Console.WriteLine("That is not an option, try again.");
            }
        }
    }

    public void DisplayPlayerInfo()
    {

    }

    public void ListGoalNames()
    {

    }

    public void ListGoalDetails()
    {

    }

    public void CreateGoal()
    {

    }

    public void RecordEvent()
    {

    }

    public void SaveGoals()
    {

    }

    public void LoadGoals()
    {

    }
}