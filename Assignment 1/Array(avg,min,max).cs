using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 5, 1, 8, 4, 9, 3, 6, 7 };
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            double average = sum / arr.Length;
            Console.WriteLine("Average value of array elements: " + average);
            int minimum = arr[0];
            int maximum = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < minimum)
                {
                    minimum = arr[i];
                }
                if (arr[i] > maximum)
                {
                    maximum = arr[i];
                }
            }
            Console.WriteLine("Minimum value in an array: " + minimum);
            Console.WriteLine("Maximum value in an array: " + maximum);
            Console.Read();
        }
    }
}
