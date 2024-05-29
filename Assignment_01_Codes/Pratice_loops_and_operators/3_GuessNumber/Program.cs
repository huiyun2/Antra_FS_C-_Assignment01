using System;

namespace Q03_GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int correctNumber = new Random().Next(1, 4); // Generates a number between 1 and 3
            Console.Write("Guess the number (between 1 and 3): ");
            int guessedNumber = int.Parse(Console.ReadLine());

            if (guessedNumber < 1 || guessedNumber > 3)
            {
                Console.WriteLine("Your guess is outside of the valid range.");
            }
            else if (guessedNumber < correctNumber)
            {
                Console.WriteLine("Your guess is too low.");
            }
            else if (guessedNumber > correctNumber)
            {
                Console.WriteLine("Your guess is too high.");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}


