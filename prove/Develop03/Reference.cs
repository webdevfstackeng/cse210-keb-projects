using System;
using System.Collections.Generic;
 
public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _verseEnd;
    private string _reference;

    // Default constructor
    Reference()
    {

    }

    //constractor to set reference for a scripture with one verse
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _reference = ($"{_book} {_chapter}:{_verse}");
    }

    // The setter constractor to set reference for a scripture with more than one verse
    public Reference(string book, int chapter, int verse, int verseEnd)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _verseEnd = verseEnd;
        _reference = ($"{_book} {_chapter}:{_verse}:{_verseEnd}");
    }

     // Method to return the string reference
    public string GetReferenceText()
    {
        return _reference;
    }
}