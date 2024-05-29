/*
Playing with Console App
*/ 

using System;
namespace ConsoleApp01
{
    class Program 
    {
      static void Main(string[] args)
      {
        Console.WriteLine("Welcome to the console App!");
        
        //Ask questions
        Console.Write("Enter your favorite color: ");
        string color = Console.ReadLine();

        Console.Write("Enter your astrology sign: ");
        string sign = Console.ReadLine();

        Console.Write("Enter your street address number: ");
        string addressNumber = Console.ReadLine();

        string hacker_name = $"{color}{sign}{addressNumber}";
        Console.WriteLine($"Your hacker name is {hacker_name}");

      }
    }
}