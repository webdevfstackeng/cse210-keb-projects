using System;
using System.Collections.Generic;
using System.IO; 


public class Journal
{
   //Declare entry list
   List<Entry> _entries = new List<Entry>();
 
    //Instantiate the Entry class.
    Entry entry = new Entry();
    
    //Define the SaveToFile method.
    public void SaveToFile(List<Entry> _entries)
    {
        Console.WriteLine("Type the name of your file with extension(for example thoughts.txt) and press enter:");
        string userFileName = Console.ReadLine();
        string filePath = @$"C:\cse210-keb-project\cse210-keb-projects\prove\Develop02\{userFileName}";
         
        // Create the directory if it doesn't exist
        string directoryPath = Path.GetDirectoryName(filePath);
        if (!Directory.Exists(directoryPath))
        {
            Directory.CreateDirectory(directoryPath);
        }

        // Writting data to a file
        using (StreamWriter outputFile = new StreamWriter(filePath))
        {
            Console.WriteLine("Writing data to file...");

            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._prompt}|{entry._response}");
            }
             Console.WriteLine("Text saved to file..... Happy Journaling!!. ");
            //Console.WriteLine();
        }
    }

     // Define the load method
    public void LoadFromFile()
    { 
        Console.Write("Type file name you entered earlier to and press enter: ");
        string userFileName = Console.ReadLine();
         
        string filePath = @$"C:\cse210-keb-project\cse210-keb-projects\prove\Develop02\{userFileName}";
        
        // Create the directory if it doesn't exist
        string directoryPath = Path.GetDirectoryName(filePath);

        if (!Directory.Exists(directoryPath))
        {
            Directory.CreateDirectory(directoryPath);
        }

        using (StreamReader inputFile = new StreamReader(filePath))
        {
            Console.WriteLine("Loading text from file......");

            string fileContent = inputFile.ReadToEnd();
            Console.WriteLine(fileContent);
            
        }
          
        string[] lines = File.ReadAllLines(filePath);
        
        _entries.Clear();
        foreach (string line in lines)
        {
            
            string[] parts = line.Split("|");
            Entry entry = new Entry();
            if (parts.Length >= 3) // Check for a minimum of three parts in the split array
            {
                //Adding entries to list array.
                
                entry._date = parts[0];
                entry._prompt = parts[1];
                entry._response = parts[2];
                _entries.Add(entry);
                // j._entries.Add(entry);             
            }
            else
            {
                // When there are not enough parts in the split array
                Console.WriteLine("Invalid line: " + line);
            }
            Console.WriteLine($"Entries loaded from file " + filePath);  
            //Console.WriteLine(_entries);
        }
             
    }    
}
 