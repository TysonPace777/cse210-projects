using System.ComponentModel;
using System.IO;
using System.IO.Enumeration;
using System.Net.Mime;
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
        ListGoalDetails();
    }

    public void ListGoalDetails()
    {
        int counter = 1;
        foreach (Goal s in _goals)
        {
            Console.WriteLine($"{counter}. {s.GetDetailsString()}");
            counter++;
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
                int intGoalPoints = int.Parse(goalPoints);

                SimpleGoal simple1 = new SimpleGoal(goalName, goalDescription, intGoalPoints);
                _goals.Add(simple1);
            }
            else if (goalChoice == "2")
            {
                Console.Write("What is the name of your Goal? ");
                string goalName = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                string goalDescription = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                string goalPoints = Console.ReadLine();
                int intGoalPoints = int.Parse(goalPoints);

                EternalGoal eternal1 = new EternalGoal(goalName, goalDescription, intGoalPoints);
                _goals.Add(eternal1);
            }
            else if (goalChoice == "3")
            {
                Console.Write("What is the name of your Goal? ");
                string goalName = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                string goalDescription = Console.ReadLine();
                Console.Write("What is the amount of points associated with each step of this goal? ");
                string goalPoints = Console.ReadLine();
                int intGoalPoints = int.Parse(goalPoints);
                Console.Write("How many times are you trying to complete this goal? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus points for finsishing the goal? ");
                int bonus = int.Parse(Console.ReadLine());
                Console.Write("How many parts of this goal have you already completed (if any)? ");
                int amountCompleted = int.Parse(Console.ReadLine());

                ChecklistGoal check1 = new ChecklistGoal(goalName, goalDescription, intGoalPoints, target, bonus, amountCompleted);
                _goals.Add(check1);
            }
            else
            {
                Console.WriteLine("Invalid Goal, Try Again");
            }
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("The goals are: ");
        ListGoalDetails();

        Console.Write("Which goal did you complete? ");
        int completedGoal = int.Parse(Console.ReadLine()) - 1;

        if (completedGoal >= 0 && completedGoal < _goals.Count)
        {
            Goal goal = _goals[completedGoal];
            goal.RecordEvent();

            int pointsEarned = goal.GetPointsEarned();
            _score += pointsEarned;

            Console.WriteLine($"Total Score: {_score}");
        }
        else
        {
            Console.WriteLine("Invalid Choice");
        }
    }

    public void SaveGoals()
    {
        Console.Write("What do you want the file to be called: ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals Saved");
    }

    public void LoadGoals()
    {
        Console.Write("What file do you want to load: ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);

        _score = int.Parse(lines[0]);

        _goals.Clear();

        foreach (string line in lines.Skip(1))
        {
            string[] parts = line.Split(";");
            string goalType = parts[0];
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);

            if (goalType == "SimpleGoal")
            {
                bool isComplete = bool.Parse(parts[4]);
                SimpleGoal goal = new SimpleGoal(name, description, points);
                goal.SetComplete(isComplete);
                _goals.Add(goal);
            }
            else if (goalType == "EternalGoal")
            {
                bool isComplete = bool.Parse(parts[4]);
                EternalGoal goal = new EternalGoal(name, description, points);

                _goals.Add(goal);
            }
            else if (goalType == "ChecklistGoal")
            {
                int target = int.Parse(parts[4]);
                int bonus = int.Parse(parts[5]);
                int amountCompleted = int.Parse(parts[6]);
                ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus, amountCompleted);
                _goals.Add(goal);
            }
        }
        Console.WriteLine("Goals Loaded");
    }
}