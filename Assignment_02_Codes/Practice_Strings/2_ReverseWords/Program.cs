using System;
using System.Text.RegularExpressions;

namespace ReverseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence: ");
            string sentence = Console.ReadLine();

            string reversedSentence = ReverseWordsInSentence(sentence);
            Console.WriteLine("Reversed Sentence: " + reversedSentence);
        }

        static string ReverseWordsInSentence(string sentence)
        {
            string[] words = Regex.Split(sentence, @"(\s+|[.,:;=()&[\]""'\\/!?])");
            Array.Reverse(words);
            return string.Concat(words);
        }
    }
}

