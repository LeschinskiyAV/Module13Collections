using System.Text.RegularExpressions;

namespace WordCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\temp\data\Text1.txt";
            if (File.Exists(filePath))
            {
                Dictionary<string, int> Words = new Dictionary<string, int>();
                var text = File.ReadAllText(filePath);
                var noPunctuationText = new string(text.Where(c => !char.IsPunctuation(c)).ToArray());
                var newString = string.Join(" ", Regex.Split(noPunctuationText, @"(?:\r\n|\n|\r)"));
                string[] words = newString.Split(' ');
                foreach (var word in words)
                {
                    if (word == "")
                    {
                        continue;
                    }
                    else if (Words.ContainsKey(word))
                    {
                        Words[word] += 1;
                    }
                    else
                    {
                        Words.Add(word, 1);
                    }
                }
                var sortedWords = (from entry in Words orderby entry.Value descending select entry)
                    .Take(10)
                    .ToDictionary(pair => pair.Key, pair => pair.Value);
                Console.WriteLine("top 10 words by usage, w/o punctuiation and return carrieage");
                foreach (var SortedWord in sortedWords)
                {
                    Console.WriteLine($"Word: {SortedWord.Key}, Usages: {SortedWord.Value}");
                }
            }
            else
            {
                Console.WriteLine("I refuse to do work! Place file Text1.txt in C:\\temp\\data\\, please");
            }
        }
    }
}