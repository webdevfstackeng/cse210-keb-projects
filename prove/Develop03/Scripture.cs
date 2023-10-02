using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private string _scripture;
    
    public Scripture(Reference reference, string text)
    {
         
    }

    public string GetScripture()
    {
        return _scripture;
    }

    public bool IsCompletelyHidden()
    {
       
        return true;

    }

    // Method to get the reference
    public string GetReferenceText()    //GetReferenceText()
    {
        return _reference.GetReferenceText();
    }

    // Method that displays the list of words.
    public void DisplayWords()    
    {
         
    }
    
    //Method returns a new list of word object for only the words that are still visible.
    // Checks if the word is still visible and add the word to the new list of words and 
    //returns the new list.
    public List<Word> GetShownWords()  
    {
        List<Word> wordsLeft = new List<Word>();
         
        return wordsLeft;
    }
}

