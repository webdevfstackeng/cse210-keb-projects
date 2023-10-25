using System;
using System.Collections.Generic;
using System.IO;
public class Video
{
    public string _title;
    public string _author;

    public int _length;

    public List<Video> _videos = new List<Video>();

    public List<Comment> _comments = new List<Comment>();
 
public void SetTitle(string title)
{
    _title = title;
}

public void SetAuthor(string author)
{
    _author = author;
}

public void SetLength(int length)
{
    _length = length;
}

public string GetTitle()
{
    return _title;
}

public string GetAuthor()
{
    return _author;
}

public int GetLength()
{
    return _length;
}

public void GetComments(Comment comment)
{
    _comments.Add(comment);
}

public void DisplayVideos()
{  
    foreach(Video video in _videos)
    {
        Console.WriteLine($"Title: {video._title}, Author: {video._author}, Lenght: {video._length}, Number of Comments: {video._comments.Count} ");
        
        foreach(Comment comment in video._comments)
        {
            comment.DisplayComments();
        }
    }
    
}


}

