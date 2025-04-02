public class ListingActivity : Activity
{
    private int _count = 0;
    private List<string> _prompts = new List<string>();

    public ListingActivity(int count)
        : base("3")
    {
        _count = count;
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }
    public void Run()
    {
        Console.WriteLine("List as many responses as you can to the following prompt:");
        string randomprompt = GetRandomPrompt();
        Console.WriteLine($"--{randomprompt}--");
        ShowCountDown(3);

        List<string> userList = new List<string>();

        DateTime endTime = DateTime.Now.AddSeconds(_count);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            userList.Add(item);
        }

        int responses = userList.Count;
        Console.WriteLine($"You got {responses} response(s)!");

        Console.WriteLine("Well done!");
        ShowSpinner(1);
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }
}