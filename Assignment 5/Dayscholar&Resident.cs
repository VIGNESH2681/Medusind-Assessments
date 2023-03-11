using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    interface IStudent
    {
        int StudentId { get; set; }
        string Name { get; set; }
        int Fees { get; set; }
        void ShowDetails();
    }

    class DayScholar : IStudent
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public int Fees { get; set; }

        public void ShowDetails()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("DayScholar Details");
            Console.WriteLine("Student ID: " + StudentId);
            Console.WriteLine("Name of the Student: " + Name);
            Console.WriteLine("Fees:50000"+ Fees);
            Console.WriteLine();
        }
    }

    class Resident : IStudent
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public int Fees { get; set; }

        public void ShowDetails()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Resident Details");
            Console.WriteLine("Student ID: " + StudentId);
            Console.WriteLine("Name of the Student: " + Name);
            Console.WriteLine("Fees:100000" + Fees);
            Console.WriteLine();
        }
    }

    class Interface
    {
        public static void Main()
        {
            DayScholar ds = new DayScholar();

            Console.WriteLine("Enter StudentId :");
            ds.StudentId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Name Of The Student :");
            ds.Name = Console.ReadLine();

            ds.ShowDetails();

            Resident r = new Resident();

            Console.WriteLine("Enter Student Id :");
            r.StudentId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Name Of The Student:");
            r.Name = Console.ReadLine();

            r.ShowDetails();

            Console.Read();
        }
    }
}