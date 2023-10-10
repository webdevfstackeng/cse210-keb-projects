using System;

public class BreathingActivity : Activity     // BreathingActivity deried class inherits from the base class Activity
{
    public BreathingActivity(double duration) : base(duration)   // Constructor inherits duration attribute from base class
    {   
        _duration = duration;                                     // and sets the variable _duration.
    }

    // The Breathing activity is defined in the RunActivity method
    public void RunActivity()     
    {
        
        Console.Write("Breath in ...");
        PauseCountdownTimer(2);
        Console.Write("Now breath out ...");
        PauseCountdownTimer(3);

        while (GetDuration() > 0)
        {
            Console.Write("Breath in ...");
            PauseCountdownTimer(3);
            Console.Write("Now breath out ...");
            PauseCountdownTimer(6);
        }
    }
}

 