using System;

namespace practical_1_StudentSystem
{
    class Student
    {
        // Private Data Members
        private string name;
        private double gpa;
        private double fees;
        private bool enrolled;

        // Constructor
        public Student(string studentName, double studentGpa, double studentFees)
        {
            name = studentName;
            gpa = studentGpa;
            fees = studentFees;
            enrolled = true;
        }

        // Public Method
        public bool IsEligible()
        {
            return fees > 50000;
        }

        // Public Method
        public void Display()
        {
            Console.WriteLine("\nStudent Record");
            Console.WriteLine("----------------");
            Console.WriteLine("Name      : " + name);
            Console.WriteLine("GPA       : " + gpa);
            Console.WriteLine("Fees      : " + fees);
            Console.WriteLine("Enrolled  : " + enrolled);
            Console.WriteLine("Scholarship Eligible : " + IsEligible());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter GPA: ");
            double gpa = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Fees: ");
            double fees = Convert.ToDouble(Console.ReadLine());

            Student s1 = new Student(name, gpa, fees);

            s1.Display();
        }
    }
}
