using System;
using System.Collections.Generic;


public class Word
{
     private bool _isHidden;
    private string _text;

    // Constructor that sets the text and the isHidden bool. 
    public Word(string text)
    {
        _text = text;
        _isHidden  = false;
    }

    // Method sets the isHidden variable to true
    public void SetIsHidden()
    {
        _isHidden = true;
    }

    // Method returns the boolean _isHidden variable.
    public bool GetIsHidden()
    {
        return _isHidden;
    }

    // Method for showing words
    public string DisplayWords()
    {
        return _text;
    }

     // Method that replaces the random word with an underscore
    public void HideOrDisplayWord()   
    {
        if(_isHidden == true)
        {
            foreach (char letter in _text)
            {
                Console.Write("_");
            }
        }
        else
            Console.Write(_text);
    }

     

}



