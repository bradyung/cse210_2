using System;
using System.Collections.Generic;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        _random = new Random();

        string[] parts = text.Split(' ');

        foreach (string part in parts)
        {
            Word word = new Word(part);
            _words.Add(word);
        }
    }
    public string GetDisplayText()
    {
        string displayText = "";

        foreach (Word word in _words)
        {
            displayText += word.GetWordString() + " ";
        }
        return _reference.GetDisplayText() + "\n" + displayText.Trim();
    }
    public void HideRandomWords(int numberToHide)
    {
        for(int i = 0; i < numberToHide; i++)
        {
            if (IsCompletelyHidden())
            {
                return;
            }
            int index = _random.Next(_words.Count);

            while (_words[index].IsHidden())
            {
                index = _random.Next(_words.Count);
            }
            _words[index].HideWord();

        }

    }
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

}