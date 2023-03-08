using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class Person
    {
        protected string Name { get; set; }
        protected string Address { get; set; }
         
        public Person(string name, string address)
        {
            Name = name;
            Address = address;
        }
    }
    public class Doctor : Person
    {
        string RegnNo { get; set; }
        double FeesCharged { get; set; }
        string Specification { get; set; }

        public Doctor(string name, string address, string regnNo, double feesCharged, string specification)
            : base(name, address)
        {
            RegnNo = regnNo;
            FeesCharged = feesCharged;
            Specification = specification;
        }

        public void ShowData()
        {
            
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Address: " + Address);
            Console.WriteLine("Registration number: " + RegisterNo);
            Console.WriteLine("Fees Charged: " + Fees);
            Console.WriteLine("Specialization: " + Specification);
            Console.Read();
        }
    }

    public class Doctor
    {
        public static void Main()
        {
            Console.Write("Enter the name of the doctor: ");
            string name = Console.ReadLine();

            Console.Write("Enter the address of the doctor: ");
            string address = Console.ReadLine();

            Console.Write("Enter the registration number of the doctor: ");
            string registerNo = Console.ReadLine();

            Console.Write("Enter the fees charged by the doctor: ");
            double fees = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the specialization of the doctor: ");
            string specification = Console.ReadLine();

            Doctor doctor = new Doctor(name, address, regnNo, feesCharged, specification);
            doctor.ShowData();
        }
    }

}