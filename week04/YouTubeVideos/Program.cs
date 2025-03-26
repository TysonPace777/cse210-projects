using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        Video video1 = new Video("Cooking Tutorial", "BestChef", "12:30");
        Video video2 = new Video("Cool Cars Video", "CarEnthusiast", "08:15");
        Video video3 = new Video("Guide to C# Coding", "CodeMaster", "15:40");
        Video video4 = new Video("Top Ten Hardest Hikes in America", "AdventureGuy", "20:10");

        video1.AddComment(new Comments("I learned a lot about cooking"));
        video1.AddComment(new Comments("Great tutorial!"));
        video1.AddComment(new Comments("Thanks for sharing"));

        video2.AddComment(new Comments("What a cool car!"));
        video2.AddComment(new Comments("I want this car!"));
        video2.AddComment(new Comments("Amazing video!"));

        video3.AddComment(new Comments("This helped me learn C#!"));
        video3.AddComment(new Comments("Very informative"));
        video3.AddComment(new Comments("Best tutorial on C#"));

        video4.AddComment(new Comments("I would love to hike there."));
        video4.AddComment(new Comments("Incredible landscapes"));
        video4.AddComment(new Comments("Adding this to my bucket list"));

        video1.DisplayVideoDetails();
        video2.DisplayVideoDetails();
        video3.DisplayVideoDetails();
        video4.DisplayVideoDetails();
    }
}