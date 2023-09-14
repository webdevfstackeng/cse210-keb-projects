using System;
using System.Security;

class Program
{
    
    
    static void Main(string[] args)
    {
        /* Part 1 and 2.
        Console.Write("What is your guess? ");
        int guessNumber = int.Parse(Console.ReadLine()); */

        // Part 3.
        Random randomNumberGenerator = new Random();
        int magicNumber = randomNumberGenerator.Next(1, 100);
        
        int guessNumber = 0;
        int guessCounter = 0;
        
        while ( guessNumber != magicNumber)  
        {
            Console.Write("What is your guess? ");
            guessNumber = int.Parse(Console.ReadLine());
            guessCounter++;

            if (guessNumber < magicNumber)
            {
                Console.WriteLine("Higher");
            }

            else if (guessNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } 
        Console.WriteLine($"Number of guesses: {guessCounter}"); 
    }
}