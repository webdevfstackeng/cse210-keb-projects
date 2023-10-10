using System;
 
public class Activity        // The base class Activity is defined
{
    protected double _duration;  // Protected member variable
    public Activity(double duration)      // Constructor method used to set the _duration variable
    {
        _duration = duration;      
    }
    
    // Get duration method returning the _duration variable
    public double GetDuration()   
    {
        return _duration;
    }

    // The display the starting message method defined.
    public void DisplayStartingMessage()
    {
        Console.WriteLine("Get ready ...");
        PauseWithSpinner();
        Console.WriteLine();     
    }

    // The display the ending message method defined.
    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine($"Well done!! \nYou have completed another {_duration} seconds of the Activity");
        PauseWithSpinner();
        Console.WriteLine();
        PauseWithSpinner();
    }

    // The pause with the spinner animation method defined.
    public void PauseWithSpinner()
    {
        List<string> animation = new List<string> { "|", "/", "-", "\\", "|", "/", "-", "\\" };

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);

        int i = 0;
        while(DateTime.Now < endTime)
        {
            string str = animation[i];
            Console.Write(str);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;
            if(i >= animation.Count)
            {
                i = 0;
            }
        }
    }
    
    // The pause with count down timer method defined.
    public void PauseCountdownTimer(int countdownTimer)
    {
        int _countdownTimer = countdownTimer; // Set the countdown time in seconds
       
        _duration -= _countdownTimer;
        while (_countdownTimer > 0)
        {
            Console.Write(_countdownTimer);
            _countdownTimer--;
            Thread.Sleep(1000); // Pause for 1 second
            Console.Write("\b \b");
        }
     
        Console.WriteLine("\n");
    }
}







