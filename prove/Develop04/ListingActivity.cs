using System;
using System.Collections.Generic;
using System.IO;

public class ListingActivity : Activity    // ListingActivity class inherits from the base class Activity
{ 
    public ListingActivity(double duration) : base(duration) // Constructor used to set duration variable
    {
       _duration = duration; 
    }

    // A method for generating random prompt questions from a text file
    public string GenerateListingPrompts()
    {
        string filename = "Listingpromptquestions.txt";
        string[] _promptsQuestions = File.ReadAllLines(filename);
        Random random  = new Random();
        int prompt = random.Next(_promptsQuestions.Count());

        string randomPromptQuestion = _promptsQuestions[prompt];
         
        return randomPromptQuestion;
    }
    public void RunActivity()   // Run Activity method call the method for generating listing promts.
    {
        GenerateListingPrompts();
    }
}