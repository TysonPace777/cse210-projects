public class BreathingActivity : Activity
{
    private int _length = 0;

    public BreathingActivity(int length)
        : base("1")
    {
        _length = length;
    }
    public void Run()
    {
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        
        Console.WriteLine("Get Ready...");
        ShowSpinner(2);

        List<string> breathing = new List<string>();
        breathing.Add("Breath in - 3");
        breathing.Add("Breath in - 2");
        breathing.Add("Breath in - 1");
        breathing.Add("Breath Out - 3");
        breathing.Add("Breath Out - 2");
        breathing.Add("Breath Out - 1");

        DateTime endTime = DateTime.Now.AddSeconds(_length);

        while (DateTime.Now < endTime)
        {
            foreach (string s in breathing)
            {
                Console.Write(s);
                Thread.Sleep(1000);
                Console.Write("\r" + new string(' ', s.Length) + "\r");
            }
        }
        Console.WriteLine("Well done!");
        ShowSpinner(1);
        Console.WriteLine($"You have completed the breathing exercise for {_length} seconds.");
        ShowSpinner(1);
    }
}