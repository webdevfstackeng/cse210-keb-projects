using System;
using System.Runtime;

public abstract class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    /* Update the counter for the number of times the goal has been achieved. 
    Return points everytime they meet the goal. 
    Returns additional bonus points once they have completed the goal multiple times according to the target */
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {     
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public int GetTarget()
    {
        return _target;
    }

     public int GetBonus()
    {
        return _bonus;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override int RecordEvent()
    {
        while(_amountCompleted != _target)
        {   
            _amountCompleted++;
            if(GetIsComplete() == true)
            {
                Console.WriteLine($"Congtatulations! You have earned {_points += _points} points!");
            }

            else if(GetIsComplete() == true && _amountCompleted == _target)
            {
                Console.WriteLine($"Congtatulations! You have earned {_points += _bonus} points!");
            } break;  
        }
        return _points + _bonus;         
    }

    // Overridden to show the number of times the goal has been accomplished so far.
    public override void GetDetailsString()
    {
        string mark;

        if(_isComplete == true)
        {
            mark = "[✔]";
        }
        else 
            mark = "[ ]";
         
        Console.WriteLine($"{mark} {_shortName} {_description} {_points}");         
    }

    public override string GetStringRepresentation()
    {
        string stringRepresentation  = Console.ReadLine($"{mark} {_shortName}({_description}) {_points}");  
        return stringRepresentation;
    }

}
