using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create the videos
        Video video1 = new Video("Pokemon Adventures", "Ash Ketchum", 320);
        video1.AddComment(new Comment("John", "That was a great video!"));
        video1.AddComment(new Comment("Lucy", "Not my thing honestly"));
        video1.AddComment(new Comment("Jack", "Pretty interesting story"));

        Video video2 = new Video("Rocks in the Mountains", "Peter Stone", 1200);
        video2.AddComment(new Comment("Sara", "Beautiful scenery!"));
        video2.AddComment(new Comment("Mike", "Where was this filmed?"));
        video2.AddComment(new Comment("Anna", "So relaxing to watch"));

        Video video3 = new Video("C# for Juniors", "MoruiDev", 900);
        video3.AddComment(new Comment("Dave", "Very helpful tutorial"));
        video3.AddComment(new Comment("Emma", "Can you make a part 2?"));
        video3.AddComment(new Comment("Luis", "Finally I understand classes!"));

        Video video4 = new Video("How to Make Tacos", "Chef Rosa", 480);
        video4.AddComment(new Comment("Carlos", "I tried this and it was amazing"));
        video4.AddComment(new Comment("Amy", "What kind of salsa do you recommend?"));
        video4.AddComment(new Comment("Ben", "Best recipe on YouTube"));

        // Put all videos in a list
        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        // Loop through each video and display the info
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLengthInSeconds()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  {comment.GetCommenterName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}