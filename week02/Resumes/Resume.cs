using System.Reflection.Metadata.Ecma335;

public class Resume
{
    public string _member;
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Member: {_member}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}