using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            string reversedString = ReverseWithCharArray(input);
            Console.WriteLine("Reversed with char array: " + reversedString);

            reversedString = ReverseWithForLoop(input);
            Console.WriteLine("Reversed with for loop: " + reversedString);
        }

        static string ReverseWithCharArray(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        static string ReverseWithForLoop(string str)
        {
            string result = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                result += str[i];
            }
            return result;
        }
    }
}
