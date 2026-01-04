using System;

namespace BridgeLabzTraining.oops_csharp_practice.csharp_constructors__instance_vs._class_variables__access_modifiers
{
    class Employee
    {
        public int employeeID;
        protected string department;
        private double salary;

        // constructor
        public Employee(int employeeID, string department, double salary)
        {
            this.employeeID = employeeID;
            this.department = department;
            this.salary = salary;
        }

        // Method to get salary
        public double GetSalary()
        {
            return salary;
        }

        // Method to modify salary
        public void UpdateSalary(double newSalary)
        {
            if (newSalary > 0)
            {
                salary = newSalary;
            }
            else
            {
                Console.WriteLine("Invalid salary amount");
            }
        }
    }

    class Manager : Employee
    {
        private int teamStrength;

        public Manager(int employeeID, string department, double salary, int teamSize): base(employeeID, department, salary)
        {
            this.teamStrength = teamSize;
        }

        public void DisplayManagerDetails()
        {
            Console.WriteLine("============================");
            Console.WriteLine($"Employee ID --> {employeeID}");  
            Console.WriteLine($"Department  --> {department}");  
            Console.WriteLine($"Salary      --> {GetSalary()}"); 
            Console.WriteLine($"Team Size   --> {teamStrength}");
            Console.WriteLine("============================");
        }
    }

    // Caller class
    class Caller
    {
        public static void Main(string[] args)
        {
            Manager manager = new Manager(101, "IT", 85600, 10);

            manager.DisplayManagerDetails();
            manager.UpdateSalary(95000);
            Console.WriteLine("Updated Salary --> " + manager.GetSalary());
        }
    }
}
