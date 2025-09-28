using System;
using System.Collections.Generic;
using System.IO;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    private static Random _random = new Random();
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        //Split the text into words and punctuation/spaces
        string[] wordsArray = text.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
        //Convert each string word into a Word list
        foreach (string wordText in wordsArray)
        {
            _words.Add(new Word(wordText));
        }

    }

    // This method hides a specified number of unique, currently unhidden words.
    public void HideRandomWords(int numberToHide)
    {
        // 1. Create a list to hold all the words that are currently visible (not hidden).
        List<Word> unhiddenWords = new List<Word>();
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                unhiddenWords.Add(word);
            }
        }

        // 2. Check if there are any words left to hide. If not, we stop.
        if (unhiddenWords.Count == 0)
        {
            return;
        }

        // 3. Determine how many words we can actually hide (don't try to hide more than we have).
        int actualWordsToHide = Math.Min(numberToHide, unhiddenWords.Count);

        // 4. Loop to hide the required number of words.
        for (int i = 0; i < actualWordsToHide; i++)
        {
            // Get a random index from the list of unhidden words.
            int index = _random.Next(0, unhiddenWords.Count);
            Word wordToHide = unhiddenWords[index];

            // Tell the Word object to hide itself (replace text with underscores).
            wordToHide.Hide();

            // IMPORTANT: Remove the word from this temporary list so we don't pick it again in this iteration.
            unhiddenWords.RemoveAt(index);
        }
    }
    // This method creates the full string to display on the screen.
    public string GetDisplayText()
    {
        // 1. Get the scripture reference (e.g., "John 3:16").
        string referenceText = _reference.GetDisplayText();

        // 2. Build the scripture text by getting the display text from each word.
        List<string> displayWordStrings = new List<string>();
        foreach (Word word in _words)
        {
            // Each word returns either its text or its underscores.
            displayWordStrings.Add(word.GetDisplayText());
        }

        // 3. Join all the word strings back together with a space between each one.
        string scriptureText = string.Join(" ", displayWordStrings);

        // 4. Combine the reference and the scripture text for the final output.
        return $"{referenceText} {scriptureText}";
    }
// This method checks if every single word in the scripture has been hidden.
    public bool IsCompletelyHidden()
    {
        // Loop through every single word in the scripture.
        foreach (Word word in _words)
        {
            // If we find even one word that is NOT hidden, the scripture is not completely hidden yet.
            if (!word.IsHidden())
            {
                return false;
            }
        }
        
        // If the loop finishes without finding any unhidden words, it means they are all hidden.
        return true;
    }
}

