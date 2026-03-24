using System;
using System.Collections.Generic;

namespace ScriptureMemorizer
{
    public class Scripture
    {
        private Reference _reference;
        private List<Word> _words = new List<Word>();

        public Scripture(Reference Reference, string text)
        {
            _reference = Reference;
            
            // The instructions ask us to split the string into Word objects here
            string[] splitWords = text.Split(' ');
            foreach (string wordText in splitWords)
            {
                _words.Add(new Word(wordText));
            }
        }

        public void HideRandomWords(int numberToHide)
        {
            Random random = new Random();
            int hiddenCount = 0;

            while (hiddenCount < numberToHide)
            {
                int index = random.Next(_words.Count);
                if (!_words[index].IsHidden())
                {
                    _words[index].Hide();
                    hiddenCount++;
                }
            }
        }

        public string GetDisplayText()
        {
            string scriptureText = "";
            foreach (Word word in _words)
            {
                scriptureText += word.GetDisplayText() + " ";
            }

            return $"{_reference.GetDisplayText()} {scriptureText.Trim()}";
        }

        public bool IsCompletelyHidden()
        {
            foreach (Word word in _words)
            {
                if (!word.IsHidden())
                {
                    return false; // Found a visible word!
                }
            }
            return true; // Checked them all, all are hidden!
        }
    }
}