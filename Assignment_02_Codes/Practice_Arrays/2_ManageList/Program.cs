using System;
using System.Collections.Generic;

namespace ManageList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            while (true)
            {
                Console.WriteLine("Enter command (+ item, - item, or -- to clear):");
                string input = Console.ReadLine();

                if (input.StartsWith("+"))
                {
                    list.Add(input.Substring(2));
                }
                else if (input.StartsWith("-"))
                {
                    list.Remove(input.Substring(2));
                }
                else if (input == "--")
                {
                    list.Clear();
                }

                Console.WriteLine("Current List: " + string.Join(", ", list));
            }
        }
    }
}
