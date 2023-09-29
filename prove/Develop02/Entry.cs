using System;
using System.Collections.Generic;
using System.IO;

public class Entry
{
     public string _date;
    public string _prompt = " ";
    public string _response = " ";
 
    // Method for getting entry responses. 
    public void AddEntry()
    {
        Console.Write("\nEnter your response: ");
        _response = Console.ReadLine(); 
    }
    
    // Method for displaying all entries
    public void DisplayAllEntries()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        _date = dateText;

        Console.WriteLine($"Date: {_date} | Prompt: {_prompt} | Response: {_response}");    
    }
}