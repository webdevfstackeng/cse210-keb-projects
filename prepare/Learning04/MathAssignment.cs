using System;

public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    // Passing four parameters to Math constructor and two super constructor parameters
    public MathAssignment(string studentName, string textbookSection, string topic, string problems) : base(studentName, topic)
    {
        // Setting MathAssignment variables 
        _textbookSection = textbookSection;
        _problems = problems;
    }

    // Returning private variables.
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}
