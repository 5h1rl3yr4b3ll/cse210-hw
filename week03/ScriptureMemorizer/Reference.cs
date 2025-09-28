using System;
using System.Collections.Generic;
using System.IO;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    //Set to 0 to indicate a single verse reference
    private int _endVerse;
    //Constructor for a single verse scripture
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = 0;
    }
    //Constructor for a scripture of 2 of more verses
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }
    //Public cause other classes can access it
    public string GetDisplayText()
    {
        //Check if it's a 2 or more scripture
        if (_endVerse > 0)
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}";
        }
    }
}