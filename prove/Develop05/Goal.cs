using System;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;
    protected bool _isComplete;
    
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract int RecordEvent();

    public abstract bool IsComplete();

    public abstract string GetStringRepresentation();

    public bool GetIsComplete()
    {
        return _isComplete;
    }

    public string GetDetailsString()
    {
        string mark;

        if(_isComplete == true)
        {
            mark = "[✔]";
        }
        else 
            mark = "[ ]";
        Console.WriteLine($"{mark} {_shortName}({_description}) {_points}");        
        return mark; 
    } 
}