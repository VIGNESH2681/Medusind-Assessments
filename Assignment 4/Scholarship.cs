using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class scholarship
    {
        public int total;
        public float fees;

        public float Merit(int m, float f)
        {
            if (m >= 70 && m <= 80)
            {
                return (f * 20) / 100;
            }
            else if (m > 80 && m <= 90)
            {
                return (f * 30) / 100;
            }
            else if (m > 90)
            {
                return (f * 50) / 100;
            }
            else
            {
                return 0;
            }
        }
        static void Main(String[] args)
        {
            scholarship s = new scholarship();

            Console.WriteLine("Please Enter Total Marks: ");
            s.total = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter Fees: ");
            s.fees = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Scholarship Amount is: " + s.Merit(s.total, s.fees));
            Console.ReadLine();
        }
    }

}