using System;
using System.Linq;
using System.Collections.Generic;

namespace MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
            var mostFrequent = array.GroupBy(x => x)
                                    .OrderByDescending(g => g.Count())
                                    .ThenBy(g => Array.IndexOf(array, g.Key))
                                    .First().Key;

            int frequency = array.Count(x => x == mostFrequent);

            Console.WriteLine($"The number {mostFrequent} is the most frequent (occurs {frequency} times)");
        }
    }
}
