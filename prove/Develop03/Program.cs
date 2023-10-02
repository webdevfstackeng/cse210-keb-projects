using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
            // Prompt the user to choose between two files
        Console.Write("Enter 1 to load scripture.txt or 2 to load scriptureverses.txt: ");
        string fileChoice = Console.ReadLine();

        // Load the contents of the chosen file
        string filePath = "";
        if (fileChoice == "1")
        {
            filePath = "scriptureverse.txt";
            string contents = File.ReadAllText(filePath); // Read selected file content
        }
        else if (fileChoice == "2") 
        {
            filePath = "scriptureverses.txt";
            string contents = File.ReadAllText(filePath); // Read selected file content
        }
        else
        {
            Console.WriteLine("Invalid choice. Please enter 1 or 2.");
            return;
        }

        string fileContents;
        try
        {
            // Read the contents of the file
            fileContents = File.ReadAllText(filePath);
        }
        catch (FileNotFoundException)
        {
            Console.Write("The chosen file does not exist: ");
            return;
        }
        Reference reference = new Reference("Mosiah", 8, 18);
        string text = fileContents; 
        Scripture scripture = new Scripture(reference, text);

        scripture.DisplayWords();  
        Console.WriteLine();

        Console.Write("Press Enter to hide words, or type quit to exit.");
        string userInput = Console.ReadLine().ToLower();

        if (userInput == "quit")
        {
            System.Environment.Exit(0);
        }
        Console.Clear();

        while (true)
        {
            // A list of the remaining words object and a random class object to randomly pick 
            //and replace 3 words at a time. 
            List<Word> wordsLeft  = scripture.GetShownWords();
            Random random = new Random(); 
            if (scripture.IsCompletelyHidden() == true)
            {
                break;
            }
            for (int i = 0; i < 3; i++)
            {
                int index = random.Next(wordsLeft.Count());
                wordsLeft[index].SetIsHidden();     
            }
            
            scripture.DisplayWords();  
            Console.WriteLine();

            Console.Write("Press Enter to hide words, or type quit to exit. ");
            string userPrompt = Console.ReadLine().ToLower();
            if (userPrompt == "quit")
            {
                break;
            }
            Console.Clear();

        }
    }
} 