using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    public abstract class Student
    {
        public string Name;
        public int StudentId;
        public double Grade;

        public abstract bool Ispassed(double grade);
    }

    class Under_Graduate : Student
    {
        public override bool Ispassed(double grade)
        {
            if (grade > 70.0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }

    class Graduate : Student
    {
        public override bool Ispassed(double grade)
        {
            if (grade > 80.0)
            {
                return true;

            }
            else
            {
                return false;
            }

        }
    }

    class student
    {
        static void Main(string[] args)
        {

            Under_Graduate ug = new Under_Graduate();


            Console.Write("Enter  name of the ug student: ");
            ug.Name = Console.ReadLine();

            Console.Write("Enter studentID: ");
            ug.StudentId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter grade for the course: ");
            ug.Grade = Convert.ToDouble(Console.ReadLine());


            bool status = ug.Ispassed(ug.Grade);
            Console.WriteLine("Status for {0} with ID {1}: {2}", ug.Name, ug.StudentId, status);


            Graduate gt = new Graduate();


            Console.Write("Enter name of the graduate student: ");
            gt.Name = Console.ReadLine();

            Console.Write("Enter studentID: ");
            gt.StudentId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter grade for the course: ");
            gt.Grade = Convert.ToDouble(Console.ReadLine());


            status = gt.Ispassed(gt.Grade);
            Console.WriteLine("Status for {0} with ID {1}: {2}", gt.Name, gt.StudentId, status);

            Console.ReadLine();
        }
    }


}
