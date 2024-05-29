using System;

namespace CenturiesConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of centuries: ");
            int centuries = int.Parse(Console.ReadLine());

            int years = centuries * 100;
            long days = (long)(years * 365.2425);  // using 365.2425 to account for leap years
            long hours = days * 24;
            long minutes = hours * 60;
            long seconds = minutes * 60;
            long milliseconds = seconds * 1000;
            long microseconds = milliseconds * 1000;
            decimal nanoseconds = microseconds * 1000m; // use decimal to handle large value

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");


        }
    }
}

