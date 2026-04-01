using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // localVariable is camelCase
        List<Video> videos = new List<Video>();

        Video video1 = new Video("How to Bake Sourdough", "Moe's Kitchen", 600);
        video1.AddComment(new Comment("Melissa", "This was so helpful!"));
        video1.AddComment(new Comment("Sophia", "Can I use whole wheat flour?"));
        video1.AddComment(new Comment("John", "Best tutorial I've seen yet."));
        videos.Add(video1);

        Video video2 = new Video("English Mastiff Puppy Training", "Dog Life Hawaii", 900);
        video2.AddComment(new Comment("Sarah", "What a giant puppy!"));
        video2.AddComment(new Comment("Mike", "I need one of these dogs."));
        video2.AddComment(new Comment("Dave", "How much do they eat per day?"));
        videos.Add(video2);

        Video video3 = new Video("Caffeine-Free Coffee Review", "Healthy Brews", 450);
        video3.AddComment(new Comment("Anna", "The mushroom matcha is my favorite."));
        video3.AddComment(new Comment("Chris", "Does this taste like real coffee?"));
        video3.AddComment(new Comment("Beth", "Great alternatives, thanks!"));
        videos.Add(video3);

        Console.WriteLine("YouTube Video Tracking System\n");
        foreach (Video video in videos)
        {
            video.DisplayVideoDetails();
        }
    }
}