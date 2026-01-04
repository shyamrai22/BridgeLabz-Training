using System;

namespace BridgeLabzTraining.oops_csharp_practice.inheritance
{
    // Base class
    class Employee
    {
        public string Name;
        public int Id;
        public double Salary;

        public Employee(string name, int id, double salary)
        {
            Name = name;
            Id = id;
            Salary = salary;
        }

        // Virtual method
        public virtual void DisplayDetails()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Name   --> {Name}");
            Console.WriteLine($"ID     --> {Id}");
            Console.WriteLine($"Salary --> {Salary}");
        }
    }

    // Manager subclass
    class Manager : Employee
    {
        public int TeamSize;

        public Manager(string name, int id, double salary, int teamSize)
            : base(name, id, salary)
        {
            TeamSize = teamSize;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Team Size --> {TeamSize}");
            Console.WriteLine("----------------------------");
        }
    }

    // Developer subclass
    class Developer : Employee
    {
        public string ProgrammingLanguage;

        public Developer(string name, int id, double salary, string programmingLanguage)
            : base(name, id, salary)
        {
            ProgrammingLanguage = programmingLanguage;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Programming Language --> {ProgrammingLanguage}");
            Console.WriteLine("----------------------------");
        }
    }

    // Intern subclass
    class Intern : Employee
    {
        public string InternshipDuration;

        public Intern(string name, int id, double salary, string internshipDuration)
            : base(name, id, salary)
        {
            InternshipDuration = internshipDuration;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Internship Duration --> {InternshipDuration}");
            Console.WriteLine("----------------------------");
        }
    }

    // Caller class
    class Caller
    {
        public static void Main(string[] args)
        {
            Employee employee1 = new Manager("Shyam", 101, 80000, 10);
            Employee employee2 = new Developer("Daman", 102, 60000, "C#");
            Employee employee3 = new Intern("Raman", 103, 15000, "6 Months");
            employee1.DisplayDetails();
            employee2.DisplayDetails();
            employee3.DisplayDetails();
        }
    }
}
