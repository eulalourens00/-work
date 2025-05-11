using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33Pract
{
    //4
    public class WordCounter
    {
        public Dictionary<string, int> CountWords(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            { return new Dictionary<string, int>(); }

            var punctuation = text.Where(char.IsPunctuation).Distinct().ToArray();
            char[] separators = { ' ', '\t', '\n', '\r' };
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            List<string> cleanWords = new List<string>();
            foreach (string word in words)
            {
                string trimmedWord = word.Trim(punctuation).ToLower();

                if (!string.IsNullOrEmpty(trimmedWord))
                { cleanWords.Add(trimmedWord);}
            }

            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (wordCount.ContainsKey(word))
                { wordCount[word]++; }
                else
                { wordCount[word] = 1; }
            }

            return wordCount;
        }
    }
}
