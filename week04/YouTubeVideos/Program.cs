using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video v1 = new Video("Product Review: WidgetX", "TechGuru", 420);
        v1.AddComment(new Comment("Alice", "Great review!"));
        v1.AddComment(new Comment("Bob", "I love WidgetX."));
        v1.AddComment(new Comment("Charlie", "Very informative."));
        videos.Add(v1);

        // Video 2
        Video v2 = new Video("Unboxing WidgetY", "GadgetGuy", 315);
        v2.AddComment(new Comment("Diana", "Can't wait to try this!"));
        v2.AddComment(new Comment("Eve", "Looks awesome."));
        v2.AddComment(new Comment("Frank", "Thanks for the unboxing."));
        videos.Add(v2);

        // Video 3
        Video v3 = new Video("WidgetZ in Action", "ReviewMaster", 600);
        v3.AddComment(new Comment("Grace", "WidgetZ is so cool!"));
        v3.AddComment(new Comment("Heidi", "Where can I buy it?"));
        v3.AddComment(new Comment("Ivan", "Nice demonstration."));
        videos.Add(v3);

        // Display all videos and their comments
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length (seconds): {video.LengthSeconds}");
            Console.WriteLine($"Number of comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}