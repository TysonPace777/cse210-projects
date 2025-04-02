public class Activity
{

    protected string _activityName = "";
    protected string _description = "";
    protected int _duration = 0;

    public Activity(string activityName)
    {
        _activityName = activityName;
    }

    public void DisplayStartingMessage()
    {
        if (_activityName == "1")
        {
            Console.WriteLine("Welcome to the Breathing Activity.");
        }
        else if (_activityName == "2")
        {
            Console.WriteLine("Welcome to the Reflecting Activity.");
        }
        else if (_activityName == "3")
        {
            Console.WriteLine("Welcome to the Listing Activity.");
        }
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Good job! You finished the Activity.");
        ShowSpinner(3);
        Console.Clear();
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        for (int i = seconds; i > 0; i--)
            foreach (string s in animationStrings)
            {
                Console.Write(s);
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
    }

    public void ShowCountDown(int seconds)
    {
        Console.WriteLine("You may begin in:");
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}