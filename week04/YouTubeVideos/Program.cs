using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to hold the Video objects
        List<Video> videos = new List<Video>();

        //Information of video 1
        Video video1 = new Video("C# Basics for Beginners", "Coding Pro", 1200);
        video1.AddComment(new Comment("Alice", "Great introduction to C#!"));
        video1.AddComment(new Comment("Bob", "This video really helped me understand classes."));
        video1.AddComment(new Comment("Charlie", "Can you make a video about LINQ?"));
        video1.AddComment(new Comment("Diana", "Very clear explanations. Thanks!"));
        //Add video 1 to a list of videos
        videos.Add(video1);

        //Information of video 2
        Video video2 = new Video("Advanced C# Concepts", "Tech Guru", 2500);
        video2.AddComment(new Comment("Ethan", "The segment on delegates was confusing."));
        video2.AddComment(new Comment("Fiona", "Excellent deep dive. Keep them coming!"));
        video2.AddComment(new Comment("George", "I wish there were more code examples."));
        //Add video 2 to a list of videos
        videos.Add(video2);

        //Information of video 3
        Video video3 = new Video("Building a Simple App in C#", "The Developer", 950);
        video3.AddComment(new Comment("Hannah", "Perfect tutorial for a quick project."));
        video3.AddComment(new Comment("Ivan", "What UI framework did you use?"));
        //Add video 3 to a list of videos
        videos.Add(video3);

        // Display all video information
        Console.WriteLine("--- YouTube Video and Comment Tracker ---");
        Console.WriteLine("\n=======================================\n");

        foreach (Video video in videos)
        {
            //Display video details and all its comments
            Console.WriteLine(video.DisplayVideoInfo());
            Console.WriteLine("\n=======================================\n");
        }

    }
}