using System;

public class SimpleGoal : Goal
{
    // Give points once the goal is accomplished and then mark it completed.
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override int RecordEvent()
    {
        if(IsComplete() == true)
        {
            Console.WriteLine($"Congtatulations! You have earned {_points} points!");
        }
        return _points;
    }

    // Show all of the details of a goal.
    public override string GetStringRepresentation()
    {
        //Console.WriteLine($"");
        return "";
    }
}