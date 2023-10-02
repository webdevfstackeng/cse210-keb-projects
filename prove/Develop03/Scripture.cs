using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private string _scripture;
    
    // Constructor for setting up text and reference, and processing split words
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _scripture = text;
        string[] words = _scripture.Split(" ");

        foreach (string word in words)
        {
            Word eachWord = new Word(word);
            _words.Add(eachWord);
        }    
    }

    public string GetScripture()
    {
        return _scripture;
    }

    // Method for checking if the all the words in the scripture are hedden
    public bool IsCompletelyHidden()
    {
        //if all the words are hidden, return true else return false
        // use a foreach loop to check if all the words are hidden
        foreach (Word word in _words)
        {
            if (word.GetIsHidden() == false)
                return false;
        }
        return true;

    }

    // Method to get the reference
    public string GetReferenceText()     
    {
        return _reference.GetReferenceText();
    }

    // Method that displays the list of words.
    public void DisplayWords()    
    {
        foreach (Word word in _words)
        {
            word.HideOrDisplayWord();
            Console.Write(" ");    
        }
    }
    
    //Method returns a new list of word object for only the words that are still visible.
    // Checks if the word is still visible and add the word to the new list of words and 
    //returns the new list.
    public List<Word> GetShownWords()  
    {
        List<Word> wordsLeft = new List<Word>();
        foreach (Word word in _words)
        {
            if (word.GetIsHidden() == false)
                wordsLeft.Add(word);
        }
        return wordsLeft;
    }
}


