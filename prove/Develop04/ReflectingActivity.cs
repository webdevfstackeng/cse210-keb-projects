using System;
using System.Collections.Generic;
using System.IO;

public class ReflectionActivity : Activity   // ReflectionActivity class inherits from the base class Activity
{ 
    public ReflectionActivity(double duration) : base(duration) 
    {
        _duration = duration;
    }
    public string ReflectionPrompts()  // Methods that generates random reflection prompts from a text file
    {
        
        string filename = "reflectionprompts.txt";
        string[] _reflectionPrompts = File.ReadAllLines(filename);
        Random random  = new Random();
        int prompt = random.Next(_reflectionPrompts.Count());

        string randomPrompt = _reflectionPrompts[prompt];
         
        return randomPrompt;
    }

    // Methods that generates random reflection questions from a text file and gets random questions
    public string ReflectionQuestionnaire()
    {
        string filename = "reflectionQuestions.txt";
        string[] _questionPrompts = File.ReadAllLines(filename);
        Random rand  = new Random();
        int prompt = rand.Next(_questionPrompts.Count());

        string randQuestionPrompt = _questionPrompts[prompt];
         
        return randQuestionPrompt;
    }  

    public void RunActivity()
    {
        // display more text responses to reflection promts and questions
        while (_duration > 0)
        {
            ReflectionPrompts();
            ReflectionQuestionnaire();
        }
    }
}



