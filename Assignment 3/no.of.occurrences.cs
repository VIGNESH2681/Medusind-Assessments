using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            Console.Write("Enter the letter to count: ");
            char letter = Console.ReadLine()[0];

            int count = CountOccurrences(input, letter);

            Console.WriteLine($"The letter '{letter}' appears {count} times in the string '{input}'.");
        }

        static int CountOccurrences(string input, char letter)
        {
            int count = 0;
            foreach (char c in input)
            {
                if (c == letter)
                {
                    count++;
                }
            }

            return count;
            
        }
    }
}