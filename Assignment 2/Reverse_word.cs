using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class reverse_word
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();
            char[] chars = word.ToCharArray();
            Array.Reverse(chars);
            string reverse = new string(chars);
            Console.WriteLine($"The reverse of the word '{word}' is '{reverse}'.");
            Console.ReadLine();
        }
    }
}