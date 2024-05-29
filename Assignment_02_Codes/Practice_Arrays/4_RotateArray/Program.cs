using System;

namespace RotateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 2, 4, -1 };
            int k = 2;
            int n = array.Length;
            int[] sumArray = new int[n];

            for (int r = 1; r <= k; r++)
            {
                int[] rotatedArray = new int[n];

                for (int i = 0; i < n; i++)
                {
                    rotatedArray[(i + r) % n] = array[i];
                }

                for (int i = 0; i < n; i++)
                {
                    sumArray[i] += rotatedArray[i];
                }

                Console.WriteLine($"Rotated {r} times: " + string.Join(", ", rotatedArray));
            }

            Console.WriteLine("Sum Array: " + string.Join(", ", sumArray));
        }
    }
}
