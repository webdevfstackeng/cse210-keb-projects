using System;

public class ReflectingActivity
{

    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(List<string> prompts, List<string> questions)
    {
        List<string> _prompts = prompts;
        List<string> _questions = questions;
    }

    public void Run()
    {

    }

    public string GetRandomPrompt(string _prompts)
    {
        return _prompts;
    }

    public string GetRandomQuestion(string _questions)
    {
        return _questions;
    }

    public void DisplayPrompt()
    {

    }

    public void DisplayQuestions()
    {

    }
}