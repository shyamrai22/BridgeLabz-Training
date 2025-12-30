using System;

namespace BridgeLabzTraining.oops_csharp_practice.class_and_object
{
    internal class Employee
    {
        private string name = "Sam Jhonston";
        private string id = "6829974";
        private int salary = 90000;

        public void Display()
        {
            Console.WriteLine($"Name : {this.name}");
            Console.WriteLine($"ID : {this.id}");
            Console.WriteLine($"Salary : {this.salary}");
        }
    }
}
