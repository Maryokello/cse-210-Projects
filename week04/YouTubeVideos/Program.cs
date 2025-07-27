using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
    
        List<Video> videos = new List<Video>();

        // Video 1
        Video v1 = new Video("How to Bake a Cake", "Chef Emma", 420);
        v1.AddComment(new Comment("Alice", "Looks delicious!"));
        v1.AddComment(new Comment("Bob", "I tried this and loved it."));
        v1.AddComment(new Comment("Carol", "Can I use almond flour?"));
        videos.Add(v1);

        // Video 2
        Video v2 = new Video("DIY Home Decor Ideas", "CreativeCorner", 360);
        v2.AddComment(new Comment("David", "This is so creative!"));
        v2.AddComment(new Comment("Eva", "Loved idea #3!"));
        v2.AddComment(new Comment("Frank", "Where did you get those lights?"));
        videos.Add(v2);

        // Video 3
        Video v3 = new Video("10 Minute Morning Yoga", "PeacefulYogi", 600);
        v3.AddComment(new Comment("Grace", "Felt so refreshed after this."));
        v3.AddComment(new Comment("Hannah", "Perfect for busy mornings."));
        v3.AddComment(new Comment("Ivy", "Can you do one for evenings too?"));
        videos.Add(v3);

        // Video 4
        Video v4 = new Video("Top 5 Travel Destinations 2025", "WanderlustWorld", 540);
        v4.AddComment(new Comment("Jake", "Adding all of these to my bucket list!"));
        v4.AddComment(new Comment("Karen", "I’ve been to #2 – it’s amazing."));
        v4.AddComment(new Comment("Liam", "What about places in Africa?"));
        videos.Add(v4);

        // Display
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"  - {comment.CommenterName}: {comment.CommentText}");
            }
            Console.WriteLine(new string('-', 40));
        }
    }
}

class Video
{
    public string Title { get; }
    public string Author { get; }
    public int LengthInSeconds { get; }
    private List<Comment> comments;

    public Video(string title, string author, int lengthInSeconds)
    {
        Title = title;
        Author = author;
        LengthInSeconds = lengthInSeconds;
        comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public List<Comment> GetComments()
    {
        return comments;
    }

    public int GetCommentCount()
    {
        return comments.Count;
    }
}

class Comment
{
    public string CommenterName { get; }
    public string CommentText { get; }

    public Comment(string name, string text)
    {
        CommenterName = name;
        CommentText = text;
    }
}
