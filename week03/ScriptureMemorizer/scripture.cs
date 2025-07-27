// Scripture.cs
using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        foreach (var word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords()
    {
        int wordsToHide = 3;
        int attempts = 0;

        while (wordsToHide > 0 && attempts < _words.Count * 2)
        {
            int index = _random.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                wordsToHide--;
            }
            attempts++;
        }
    }

    public string GetDisplayText()
    {
        string scriptureText = "";
        foreach (var word in _words)
        {
            scriptureText += word.GetDisplayText() + " ";
        }
        return _reference.GetDisplayText() + "\n" + scriptureText.Trim();
    }

    public bool AllWordsHidden()
    {
        foreach (var word in _words)
        {
            if (!word.IsHidden())
                return false;
        }
        return true;
    }
}
