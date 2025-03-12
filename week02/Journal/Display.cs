using System.Runtime.CompilerServices;
using System.IO;

public class Display
{
    public static List<object> userEntries = new List<object>();
    public static void Entries()
    {
        if (userEntries.Count > 0)
        {
            userEntries.ForEach(entry => Console.WriteLine(entry));
        }
        else
        {
            Console.WriteLine("There is nothing stored.");
        }
    }

    public static void AddEntries(object newEntry)
    {
        userEntries.Add(newEntry);
        Console.WriteLine("Entry Added.");
    }

    public static void SaveEntriesToFile(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (var entry in userEntries)
            {
                outputFile.WriteLine(entry);
            }
        }
    }

    public static void LoadFiles(string readFile)
    {
        userEntries.Clear();

        string[] lines = System.IO.File.ReadAllLines(readFile);

        foreach (string line in lines)
        {
            userEntries.Add(line);
        }
    }
}