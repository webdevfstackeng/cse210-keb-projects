using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter you grade percentage. ");
        string grade = Console.ReadLine();
        int gradePercentage = int.Parse(grade);
        string letter;

        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";  
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";            
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";    
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"You got grade: {letter}");

        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations, you have passed!");
        }
        else
        {
            Console.WriteLine("You have not passed. Try again next time.");
        }
    }
}