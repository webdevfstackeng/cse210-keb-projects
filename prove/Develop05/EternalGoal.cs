using System;

// Give points when the goal is achieved but never mark it completed. Give points when the goal is achieved.
public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        _points = points;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override int RecordEvent()   
    {
        if(_isComplete)
        {
            Console.WriteLine($"Congtatulations! You have earned {_points} points!");
        }
        return _points;
    }

    public override string GetStringRepresentation()
    {
        return "";
    }
}



