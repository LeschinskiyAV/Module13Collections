using System.Diagnostics;

namespace StopWatchOne
{
    public class Program
    {
        static void Main()
        {
            {
                LinkedList<string> linkedlist = new LinkedList<string>(
                    TextWorker.GetWordsFromFile(TextWorker.filepath));
                Stopwatch watch = Stopwatch.StartNew();
                linkedlist.AddFirst("smth");
                Console.WriteLine($"Вставка List: {watch.Elapsed.TotalMilliseconds} мс");
            }
        }
    }
}