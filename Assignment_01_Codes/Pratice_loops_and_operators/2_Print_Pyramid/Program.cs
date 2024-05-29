using System;

namespace Exercise04_PrintPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 5;
            for (int i = 1; i <= rows; i++)
            {
                for (int j = i; j < rows; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}


