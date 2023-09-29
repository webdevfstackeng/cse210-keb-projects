using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Instantiate the Journal, Entry and PromptGenerator classes
        List<Entry> _entries = new List<Entry>();
        Entry entry = new Entry();
        Journal journal = new Journal();
        PromptGenerator prompt = new PromptGenerator();
        
        

        // A while loop for defining the options for calling the methods to process the journal entries.
        int choice = 0;

        while(choice != 5)
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to the journal Program!");
            Console.WriteLine();

            Console.WriteLine("Please select one of the following choices (1 - 5):"); 
            Console.WriteLine();

            Console.WriteLine("1. Write (type new journal entry)");     
            Console.WriteLine("2. Display (view journal entry)");
            Console.WriteLine("3. Save (save to text file) ");
            Console.WriteLine("4. Load (overwrite recent text entries)");
            Console.WriteLine("5. Quit (exit program)");
            Console.WriteLine();

            Console.Write("What would you like to do? ");   // I added two more promts to the journal list file.
            choice = int.Parse(Console.ReadLine());

            string prompting = prompt.GetPrompt();

            if (choice == 1)   
            {
                
                Console.WriteLine(prompting);   // I created a GetPrompt() method that generates a random prompt 
                entry._prompt = prompting;      // from journal list without a need for a loop. 
                
                entry.AddEntry();            // An AddEntry() function prompts the user to respond to a random prompt               
            }
            else if (choice == 2)
            {
                entry.DisplayAllEntries();      
            }
            
            else if (choice == 3)
            {
                journal.SaveToFile(_entries);
            }               
            else if (choice == 4)
            {
                journal.LoadFromFile();

            }             
        }
    }
}