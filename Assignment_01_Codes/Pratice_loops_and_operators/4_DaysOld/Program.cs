using System;

namespace Q4DaysOld_CalculateDaysOld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your birth date (yyyy-MM-dd): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            DateTime today = DateTime.Now;
            TimeSpan age = today - birthDate;
            int daysOld = (int)age.TotalDays;

            Console.WriteLine($"You are {daysOld} days old.");

            int daysToNextAnniversary = 10000 - (daysOld % 10000);
            DateTime nextAnniversary = today.AddDays(daysToNextAnniversary);

            Console.WriteLine($"Your next 10,000-day anniversary is on {nextAnniversary.ToShortDateString()}.");
        }
    }
}


