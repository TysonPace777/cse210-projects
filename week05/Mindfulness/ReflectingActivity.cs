public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectingActivity()
        : base("2")
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("What could you learn from this experience?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What did you learn about yourself through this experience?");
    }
    public void Run()
    {
        Console.WriteLine("This activity is for reflection and pondering your life.");
        Console.WriteLine();
        Console.WriteLine("Get Ready...");
        ShowSpinner(2);

        GetRandomPrompt();
        GetRandomQuestion();
        DisplayPrompt();
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        DisplayQuestions();
        ShowSpinner(2);
        Console.WriteLine();
        
        GetRandomQuestion();
        DisplayQuestions();
        ShowSpinner(2);
        Console.WriteLine();

        Console.WriteLine("Well done!");
        ShowSpinner(1);
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        Random rand = new Random();
        int index = rand.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("Prompt: " + GetRandomPrompt());
    }

    public void DisplayQuestions()
    {
        Console.WriteLine("Question: " + GetRandomQuestion());
    }
}