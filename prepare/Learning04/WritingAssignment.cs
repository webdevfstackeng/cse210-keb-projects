using System;

public class WritingAssignment : Assignment
{
    private string _title;

    // Passing three parameters to WritingAssignment constructor and two to base constructor.
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title; // Setting WritingAssignment class variable
    }

    public string GetWritingInformation()
    {
        // Using the getter to access the private _studentName in the base class
        string studentName = GetStudentName(); 

        return $"{_title} by {studentName}";
    }
}