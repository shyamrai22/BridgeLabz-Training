using System;

namespace BridgeLabzTraining.oops_csharp_practice.encapsulation_polymorphism_interface_and_abstract_class.employee_management_system
{
    public class FullTimeEmployee : Employee, IDepartment
    {
        private string department;

        public FullTimeEmployee(int id, string name, double salary)
            : base(id, name, salary)
        {
        }

        public override double CalculateSalary()
        {
            return baseSalary; 
        }

        public void AssignDepartment(string departmentName)
        {
            department = departmentName;
        }

        public string GetDepartmentDetails()
        {
            return department;
        }
    }
}
