using System;
using System.Reflection.PortableExecutable;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("How to Make Pancakes","CookingWithSam", 420);
        video1.AddComment(new Comment("Mia", "This recipe was really easy to follow!"));
        video1.AddComment(new Comment("Jake", "I tried this and my family liked it."));
        video1.AddComment(new Comment("Sarah", "Great recipe, thanks for sharing!"));
        video1.AddComment(new Comment("Tom", "I'll definitely be making these again."));
        videos.Add(video1);

        Video video2 = new Video("Top 10 Travel Destinations","WanderlustAdventures", 315);
        video2.AddComment(new Comment("Emily", "I want to visit all of these places!"));
        video2.AddComment(new Comment("David", "Great video, very informative."));
        video2.AddComment(new Comment("Sophia","I love the beach destinations you mentioned!"));
        videos.Add(video2);

        Video video3 = new Video("Beginner Guitar Lesson","MusicMastery", 560);
        video3.AddComment(new Comment("Alex", "This lesson was perfect for me as a beginner!"));
        video3.AddComment(new Comment("Olivia", "I can already play a few chords thanks to this video!"));
        video3.AddComment(new Comment("Ethan", "Great teaching style, very clear and easy to understand."));
        video3.AddComment(new Comment("Lily", "I can't wait to practice more and improve my guitar skills!"));
        videos.Add(video3);

        Video video4 = new Video("DIY Home Decor Ideas","CreativeLiving", 780);
        video4.AddComment(new Comment("Mason", "These ideas are so creative, I can't wait to try them out!"));
        video4.AddComment(new Comment("Ava", "I love the rustic wood decor idea, it looks amazing!"));
        video4.AddComment(new Comment("Logan", "Thanks for sharing these budget-friendly decor ideas!"));
        videos.Add(video4);

        foreach (Video video in videos)
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length (seconds): {video.GetLengthSeconds()}");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.GetName()}: {comment.GetText()}");
            }
        }
    }
}