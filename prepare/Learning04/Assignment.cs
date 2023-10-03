using System;
using System.Collections.Generic;

public class Assignment
{
    private string _studentName;
    private string _topic;

    // Setter to enable access to private member variables
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Getter to enable access to private member variables in both Super class and Sub classes. 
    public string GetStudentName()
    {
        return _studentName;
    }

    // Getter to enable access to private member variables in both Super class and Sub classes.
    public string GetTopic()
    {
        return _topic;
    }
    // Getter to enable access to private member variables
    public string GetSummary()
    {
        return _studentName + " - " + _topic;  
    }
}