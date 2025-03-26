using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

public class Video
{

    private string _title;
    private string _author;
    private string _length;
    private List<Comments> _comments;

    public Video(string title, string author, string length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comments>();
    }

    public void AddComment(Comments comment)
    {
        _comments.Add(comment);
    }

    public void DisplayVideoDetails()
    {
        Console.WriteLine("Title: " + _title);
        Console.WriteLine("Author: " + _author);
        Console.WriteLine("Length: " + _length);
        Console.WriteLine("Number of Comments: " + _comments.Count);
        Console.WriteLine("Comments:");

        foreach (Comments comment in _comments)
        {
            Console.WriteLine("- " + comment.GetComment());
        }

        Console.WriteLine();
    }
}