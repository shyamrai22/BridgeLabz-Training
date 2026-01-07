using System;

namespace BridgeLabzTraining.oops_csharp_practice.encapsulation_polymorphism_interface_and_abstract_class.employee_management_system
{
    public abstract class Employee
    {
        private int employeeId;
        private string name;
        protected double baseSalary;

        public int EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Employee(int employeeId, string name, double baseSalary)
        {
            this.employeeId = employeeId;
            this.name = name;
            this.baseSalary = baseSalary;
        }

        public abstract double CalculateSalary();

        public void DisplayDetails()
        {
            Console.WriteLine($"Employee ID   : {EmployeeId}");
            Console.WriteLine($"Name          : {Name}");
            Console.WriteLine($"Total Salary  : {CalculateSalary()}");
        }
    }
}
