using System;

namespace BridgeLabzTraining.oops_csharp_practice.encapsulation_polymorphism_interface_and_abstract_class.employee_management_system
{
    class EmployeeCaller
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[10];
            int idx = 0;

            Employee emp1 = new FullTimeEmployee(101, "Rahul", 50000);
            Employee emp2 = new PartTimeEmployee(102, "Anita", 500, 40);

            ((IDepartment)emp1).AssignDepartment("Developer");
            ((IDepartment)emp2).AssignDepartment("HR");

            employees[idx++] = emp1;
            employees[idx++] = emp2;

            for (int i = 0; i < idx; i++)
            {
                employees[i].DisplayDetails();
                Console.WriteLine($"Department --> {((IDepartment)employees[i]).GetDepartmentDetails()}");
                Console.WriteLine("-----------------------------------------------------------");
            }
        }
    }
}
