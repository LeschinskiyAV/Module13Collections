using System.Diagnostics;

namespace StopWatchOne
{ 
    public class Program
    {
        static void Main()
        {
            {
                List<string> list = new List<string>(TextWorker.GetWordsFromFile(TextWorker.filepath));
                Stopwatch watch = Stopwatch.StartNew();
                list.Add("smth");
                Console.WriteLine($"Вставка List: {watch.Elapsed.TotalMilliseconds} мс");
            }
        }
    }
}