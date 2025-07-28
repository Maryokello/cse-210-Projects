using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // First video
        Video video1 = new Video { Title = "Intro to C#", Author = "CodeAcademy", LengthInSeconds = 300 };
        video1.AddComment(new Comment("Alice", "Great explanation!"));
        video1.AddComment(new Comment("Bob", "Very helpful."));
        video1.AddComment(new Comment("Eve", "Nice and short."));

        // Second video
        Video video2 = new Video { Title = "LINQ Tutorial", Author = "Programming with Mosh", LengthInSeconds = 480 };
        video2.AddComment(new Comment("David", "This really cleared things up."));
        video2.AddComment(new Comment("Sarah", "Thank you!"));
        video2.AddComment(new Comment("Mike", "Awesome content."));

        // Third video
        Video video3 = new Video { Title = "Object Oriented Design", Author = "TechSimplified", LengthInSeconds = 600 };
        video3.AddComment(new Comment("Anna", "Very informative."));
        video3.AddComment(new Comment("Tom", "Best video I watched today."));
        video3.AddComment(new Comment("Laura", "Helped me understand better."));

        // Add to list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Display info
        foreach (Video v in videos)
        {
            Console.WriteLine($"Title: {v.Title}");
            Console.WriteLine($"Author: {v.Author}");
            Console.WriteLine($"Length: {v.LengthInSeconds} seconds");
            Console.WriteLine($"Number of comments: {v.GetCommentCount()}");

            foreach (Comment c in v.GetComments())
            {
                Console.WriteLine($"  - {c.Name}: {c.Text}");
            }
            Console.WriteLine(); // Space between videos
        }
    }
}
