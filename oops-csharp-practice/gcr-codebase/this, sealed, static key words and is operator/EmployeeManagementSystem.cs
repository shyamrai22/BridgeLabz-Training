using System;

namespace BridgeLabzTraining.oops_csharp_practice.this__sealed__static_key_words_and_is_operator
{
    class Employee
    {
        public static string CompanyName = "GLA";
        private static int totalEmployees = 0;
        public readonly int Id;

        // instance variables
        public string Name;
        public string Designation;

        // using 'this' keyword
        public Employee(int id, string name, string designation)
        {
            this.Id = id;                 
            this.Name = name;             
            this.Designation = designation;
            totalEmployees++;
        }

        // static method
        public static void DisplayTotalEmployees()
        {
            Console.WriteLine($"Total Employees --> {totalEmployees}");
        }

        // using 'is' operator
        public void DisplayDetails(object obj)
        {
            if (obj is Employee)
            {
                Console.WriteLine("============================");
                Console.WriteLine($"Company     --> {CompanyName}");
                Console.WriteLine($"Employee ID --> {Id}");
                Console.WriteLine($"Name        --> {Name}");
                Console.WriteLine($"Designation --> {Designation}");
                Console.WriteLine("============================");
            }
            else
            {
                Console.WriteLine("Object is not an Employee");
            }
        }
    }

    // Caller class
    class Caller
    {
        public static void Main(string[] args)
        {
            Employee emp1 = new Employee(101, "Shyam", "Software Engineer");
            Employee emp2 = new Employee(102, "Daman", "Data Analyst");
            emp1.DisplayDetails(emp1);
            emp2.DisplayDetails(emp2);

            Employee.DisplayTotalEmployees();
            
            object obj = "Not an employee";
            emp1.DisplayDetails(obj);
        }
    }
}
