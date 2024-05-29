using System;

namespace LongestSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };
            int longestStart = 0;
            int longestLength = 1;
            int currentStart = 0;
            int currentLength = 1;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i - 1])
                {
                    currentLength++;
                }
                else
                {
                    if (currentLength > longestLength)
                    {
                        longestLength = currentLength;
                        longestStart = currentStart;
                    }

                    currentStart = i;
                    currentLength = 1;
                }
            }

            if (currentLength > longestLength)
            {
                longestLength = currentLength;
                longestStart = currentStart;
            }

            int[] longestSequence = new int[longestLength];
            Array.Copy(array, longestStart, longestSequence, 0, longestLength);

            Console.WriteLine("Longest Sequence: " + string.Join(", ", longestSequence));
        }
    }
}
