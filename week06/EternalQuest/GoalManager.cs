using System.ComponentModel;
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
            Console.WriteLine($"You have {_score} points");
            Console.WriteLine();
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
                CreateGoal();
            }
            else if (choice == "2")
            {
                Console.Clear();
                ListGoalNames();
            }
            else if (choice == "3")
            {
                Console.Clear();
                SaveGoals();
            }
            else if (choice == "4")
            {
                Console.Clear();
                LoadGoals();
            }
            else if (choice == "5")
            {
                Console.Clear();
                RecordEvent();
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
        Console.WriteLine("The goals are: ");
        foreach (Goal goal in _goals)
        {
            ListGoalDetails();
        }
    }

    public void ListGoalDetails()
    {
        foreach (Goal s in _goals)
        {
            Console.WriteLine(s.GetStringRepresentation());
        }
    }

    public void CreateGoal()
    {
        string goalChoice = "";

        while (goalChoice != "1" && goalChoice != "2" && goalChoice != "3")
        {
            Console.WriteLine("The types of Goals are:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.WriteLine("Which goal would you like to create: ");
            goalChoice = Console.ReadLine();

            if (goalChoice == "1")
            {
                Console.Write("What is the name of your Goal? ");
                string goalName = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                string goalDescription = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                string goalPoints = Console.ReadLine();
                int intGoalPoints = Int32.Parse(goalPoints);

                SimpleGoal simple1 = new SimpleGoal(goalName, goalDescription, intGoalPoints, false);
                _goals.Add(simple1);
            }
            else if (goalChoice == "2")
            {

            }
            else if (goalChoice == "3")
            {
                
            }
            else
            {
                Console.WriteLine("Invalid Goal, Try Again");
            }
        }
    }

    public void RecordEvent()
    {
        Console.Write("Which goal do you want to add an event to? ");
        string completedGoal = Console.ReadLine();
    }

    public void SaveGoals()
    {
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

    public void LoadGoals()
    {
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
        Console.WriteLine("Goals Loaded");
    }
}