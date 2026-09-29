class Program
{
    static void Main(string[] args)
    {
        // Video 1
        Video video1 = new Video(
            "Learn C# Programming",
            "Prosper Nwogu",
            600
        );

        video1.AddComment(new Comment("John", "This was very helpful!"));
        video1.AddComment(new Comment("Mary", "I learned a lot from this."));
        video1.AddComment(new Comment("David", "Great explanation."));
        video1.AddComment(new Comment("Sarah", "Thank you for sharing!"));

        // Video 2
        Video video2 = new Video(
            "Introduction to Python",
            "Tech Academy",
            720
        );

        video2.AddComment(new Comment("Michael", "Python is interesting."));
        video2.AddComment(new Comment("Grace", "Great tutorial."));
        video2.AddComment(new Comment("Daniel", "Very easy to understand."));
        video2.AddComment(new Comment("James", "I will try this myself."));

        // Video 3
        Video video3 = new Video(
            "How to Build a Website",
            "Web Developer",
            900
        );

        video3.AddComment(new Comment("Peter", "Excellent lesson."));
        video3.AddComment(new Comment("Linda", "The CSS part helped me."));
        video3.AddComment(new Comment("Chris", "Very useful information."));
        video3.AddComment(new Comment("Anna", "I enjoyed this video."));

        // Video 4
        Video video4 = new Video(
            "GitHub for Beginners",
            "Code School",
            480
        );

        video4.AddComment(new Comment("Paul", "GitHub is much clearer now."));
        video4.AddComment(new Comment("Ruth", "Thanks for the tutorial."));
        video4.AddComment(new Comment("Mark", "This was easy to follow."));
        video4.AddComment(new Comment("Elizabeth", "Very good explanation."));

        // Put all videos into a list
        List<Video> videos = new List<Video>();

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        // Display each video
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");

            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetDisplayText()}");
            }

            Console.WriteLine();
        }
    }
}