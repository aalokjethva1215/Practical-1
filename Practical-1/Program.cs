using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Practical_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.GetStudentData();
            s1.StudentDetails();
        }
    }
    public class Student
    {
        public int id;
        public string Name;
        public int Sem;
        public string Course;
        private int Fees;
        public int Scholarship;
        public int RemainingFees;



        public void GetStudentData()
        {
            

            Console.Write("Enter Student ID:");
            id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Student Name:");
            Name = Console.ReadLine();

            Console.Write("Enter Student Semester:");
            Sem = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Student Course:");
            Course = Console.ReadLine();

            Console.Write("Enter Student Fees:");
            Fees = Convert.ToInt32(Console.ReadLine());

        }

        public void StudentDetails()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Student Details");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Student ID : " + id);
            Console.WriteLine("Student Name : " + Name);
            Console.WriteLine("Student Semester : " + Sem);
            Console.WriteLine("Student Course : " + Course);
            Console.WriteLine("Student Fees : " + Fees);


            if (Fees > 50000)
            {
                Scholarship = Fees * 10 / 100;
                RemainingFees = Fees - Scholarship;
                Console.WriteLine("Scholarship Fees: " + Scholarship);
                Console.WriteLine("Remaining Fees: " + RemainingFees);
            }
            else
            {
                Console.Write("Scholarship : Not Eligible");
                Console.WriteLine("Scholarship Fees: " + Fees);
            }
        }
    }
}
