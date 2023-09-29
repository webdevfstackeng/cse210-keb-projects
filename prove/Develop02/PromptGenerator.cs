using System;
using System.Collections.Generic;
using System.IO;

public class PromptGenerator
{
    //Define the response randomizing method that returns a random prompt.
    public string GetPrompt()
    {  
        string fileName = "journal.txt";
        
        string[] lines = File.ReadAllLines(fileName);
        Random random  = new Random();
        int prompt = random.Next(lines.Count());
        string randomPrompt = lines[prompt];
         
        return randomPrompt;
    }


}