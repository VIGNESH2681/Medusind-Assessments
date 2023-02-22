using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Compare_Words_Same_or_Not
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first word: ");
            string a = Console.ReadLine();
            Console.Write("Enter second word: ");
            string b = Console.ReadLine();
            if (a == b)
            {
                Console.WriteLine($"The words '{a}' and '{b}' are the same.");
            }
            else
            {
                Console.WriteLine($"The words '{a}' and '{b}' are not the same.");
            }
            Console.ReadLine();
        }
    }
}