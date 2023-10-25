using System;

public class Comment
{
    public string _name;
    public string _text;

    public void DisplayComments()
    {    
        Console.WriteLine($"name:{_name}, comment: {_text}");
    }


}