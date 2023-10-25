using System;

class Program
{
    static void Main(string[] args)
    {
        // List<Video> _videos = new List<Video>();
        Video video1 = new Video();
        video1._title = "Home Comming.";
        video1._author = "John Jones";
        video1._length = 6000;

        Video video2 = new Video();
        video2._title = "Hackers.";
        video2._author = "Kevin Cool";
        video2._length = 5000;

        Video video3 = new Video();
        video3._title = "Eye Bots.";
        video3._author = "Samuel Smith";
        video3._length = 7000;
        
        Comment comment1  = new Comment();
        comment1._name = "Johnson";
        comment1._text = "I love this movie.";

        Comment comment2  = new Comment();
        comment2._name = "Dave";
        comment2._text = "This film is awesome!";

        Comment comment3  = new Comment();
        comment3._name = "Joseph";
        comment3._text = "The move is cool!";

        video1._comments.Add(comment1);
        video1._comments.Add(comment2);
        video1._comments.Add(comment3);

        video2._comments.Add(comment1);
        video2._comments.Add(comment2);
        video2._comments.Add(comment3);

        video3._comments.Add(comment1);
        video3._comments.Add(comment2);
        video3._comments.Add(comment3);

        Video video = new Video();
        video._videos.Add(video1);
        video._videos.Add(video2);
        video._videos.Add(video3);

        video.DisplayVideos();
    }
}