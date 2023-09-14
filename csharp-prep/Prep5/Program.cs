using System;

class Program
{
    static void Main(string[] args)
    {
        // Functions Calls. 
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber  = PromptUserNumber();
        
        int numberSquared = SquareNumber(userNumber);

        DisplayResult(userName, numberSquared);

    }

        // Defining the functions.
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your full name: ");
            string fullName = Console.ReadLine();

            return fullName;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int favoriteNumber = int.Parse(Console.ReadLine());

            return favoriteNumber;

        }

        static int SquareNumber(int number)
        {
            int numberSquared = number * number;    // Compute the square of number

            return numberSquared;
        }

        static void DisplayResult(string fullName, int numberSquared)
        {
            Console.WriteLine($"{fullName}, the square of your number is {numberSquared}");
        }     
}