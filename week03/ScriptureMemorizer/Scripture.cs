using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        foreach (string word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    public string GetDisplayText()
    {
        string verse = "";
        foreach (Word word in _words)
        {
            verse += word.GetDisplayText() + " ";
        }
        return $"{_reference.GetDisplayText()} {verse.Trim()}";
    }

    public void HideRandomWords(int count)
    {
        Random rand = new Random();
        for (int i = 0; i < count; i++)
        {
            // Stretch: Only hide words that are not already hidden
            List<int> visibleIndexes = new List<int>();
            for (int j = 0; j < _words.Count; j++)
            {
                if (!_words[j].IsHidden())
                    visibleIndexes.Add(j);
            }
            if (visibleIndexes.Count == 0) break;
            int idx = visibleIndexes[rand.Next(visibleIndexes.Count)];
            _words[idx].Hide();
        }
    }

    public bool AllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
                return false;
        }
        return true;
    }
}


