using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ExtractPalindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hi,exe? ABBA! Hog fully a string: ExE. Bob";
            string[] words = Regex.Split(text, @"\W+");

            var palindromes = new HashSet<string>(words.Where(word => IsPalindrome(word)), StringComparer.OrdinalIgnoreCase);

            Console.WriteLine("Palindromes: " + string.Join(", ", palindromes.OrderBy(word => word)));
        }

        static bool IsPalindrome(string word)
        {
            int length = word.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (char.ToLower(word[i]) != char.ToLower(word[length - 1 - i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}

