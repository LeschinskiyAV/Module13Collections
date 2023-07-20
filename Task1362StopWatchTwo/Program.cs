using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace PhoneBook
{
    class Program
    {
        private static LinkedList<int> BenchList = new LinkedList<int>()
        { };

        static void Main(string[] args)
        {
            var watch = Stopwatch.StartNew();
            BenchList.AddFirst(1);
            Console.WriteLine($"Вставка LinkedList: {watch.Elapsed.TotalMilliseconds} мс");
        }
    }
}