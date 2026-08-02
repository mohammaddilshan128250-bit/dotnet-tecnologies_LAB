using System;

namespace Practical_02_Employee_Payroll_System
{
    // Interface defining the payroll actions
    interface IPayroll
    {
        void CalcSalary();
        void LeaveAllow();
    }

    // Base class holding core employee information
    class Employee
    {
        private int employeeId;
        public string employeeName;
        protected double baseSalary;

        public void IngestData()
        {
            Console.WriteLine("Enter Employee ID:");
            employeeId = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter Employee Name:");
            employeeName = Console.ReadLine();
            
            Console.WriteLine("Enter Employee Base Salary:");
            baseSalary = Convert.ToDouble(Console.ReadLine());
        }

        public void DisplayDetails()
        {
            Console.WriteLine("\n----- Employee Details -----");
            Console.WriteLine("Employee ID    : " + employeeId);
            Console.WriteLine("Employee Name  : " + employeeName);
            Console.WriteLine("Basic Salary   : " + baseSalary);
        }
    }

    // Derived class for full-time workers with benefits
    class FullTimeEmployee : Employee, IPayroll
    {
        public void CalcSalary()
        {
            double hra = baseSalary * 0.20;
            double ma = baseSalary * 0.10;
            double pf = 2500;
            double netSalary = baseSalary + hra + ma - pf;

            Console.WriteLine("\nEmployee Type                  : Full Time");
            Console.WriteLine("House Rent Allowance (HRA)     : " + hra);
            Console.WriteLine("Medical Allowance              : " + ma);
            Console.WriteLine("Provident Fund (PF Deduction)  : " + pf);
            Console.WriteLine("Net Salary                     : " + netSalary);
        }

        public void LeaveAllow()
        {
            Console.Write("\nEnter Leave Days: ");
            int leave = Convert.ToInt32(Console.ReadLine());
            
            if (leave <= 12)
                Console.WriteLine("Leave Approved");
            else
                Console.WriteLine("Leave Limit Exceeded");
        }
    }

    // Derived class for part-time workers
    class PartTimeEmployee : Employee, IPayroll
    {
        public void CalcSalary()
        {
            Console.WriteLine("\nEmployee Type : Part Time");
            Console.WriteLine("Net Salary    : " + baseSalary);
        }

        public void LeaveAllow()
        {
            Console.WriteLine("\nPart-Time Employees are not eligible for paid leave.");
        }
    }

    // Main execution program
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******** EMPLOYEE PAYROLL SYSTEM ********");
            Console.WriteLine("1. Full Time Employee");
            Console.WriteLine("2. Part Time Employee");
            Console.Write("Enter Your Choice: ");
            
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                FullTimeEmployee ftEmp = new FullTimeEmployee();
                ftEmp.IngestData();
                ftEmp.DisplayDetails();
                ftEmp.CalcSalary();
                ftEmp.LeaveAllow();
            }
            else if (choice == 2)
            {
                PartTimeEmployee ptEmp = new PartTimeEmployee();
                ptEmp.IngestData();
                ptEmp.DisplayDetails();
                ptEmp.CalcSalary();
                ptEmp.LeaveAllow();
            }
            else
            {
                Console.WriteLine("Invalid Choice!");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
