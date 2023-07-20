using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace PhoneBook
{
    class Program
    {
        private static List<int> BenchList = new List<int>()
        { };

        static void Main(string[] args)
        {
            var watch = Stopwatch.StartNew();
            BenchList.Add(0);
            Console.WriteLine($"Вставка List: {watch.Elapsed.TotalMilliseconds} мс");
        }
    }
}