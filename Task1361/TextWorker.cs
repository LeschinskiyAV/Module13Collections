using System.Text.RegularExpressions;

namespace StopWatchOne
{
    public class TextWorker
    {
        public static readonly string filepath = @"C:\temp\data\Text1.txt";
        public static string[] GetWordsFromFile(string filepath)
        {
            string[] arrWords = Array.Empty<string>();

            if (File.Exists(filepath))
            {
                var text = File.ReadAllText(filepath);
                var noPunctuationText = new string(text.Where(c => !char.IsPunctuation(c)).ToArray());
                var newString = string.Join(" ", Regex.Split(noPunctuationText, @"(?:\r\n|\n|\r)"));
                arrWords = newString.Split(' ');
            }
            else
            {
                Console.WriteLine("I refuse to do work! Place file Text1.txt in C:\\temp\\data\\, please");
            }
            return arrWords;
        }
    }
}