using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt user for the first name.
        Console.Write("What is your first name? ");

        // Store the first name in variable firstName.
        string firstName = Console.ReadLine();

        // Prompt user for the last name.
        Console.Write("What is your last name? ");

        // Store the lasst name in variable lastName.
        string lastName = Console.ReadLine();

        Console.WriteLine(); //Leave a space.

        // Display the results on the console.
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
        Console.WriteLine();
    }
}