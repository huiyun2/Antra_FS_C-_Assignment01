using System;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz();
            SimulatedCodeExecution();
            GuessNumber();
        }

        static void FizzBuzz()
        {
            Console.WriteLine("FizzBuzz Game:");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void SimulatedCodeExecution()
        {
            Console.WriteLine("\nSimulated Code Execution:");
            int max = 500;
            for (byte i = 0; i < max; i++)
            {
                Console.WriteLine(i);
            }

            // Warning about potential overflow
            if (max > byte.MaxValue)
            {
                Console.WriteLine("Warning: Loop will cause overflow.");
            }
        }

        static void GuessNumber()
        {
            Console.WriteLine("\nGuess the Number Game:");
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


