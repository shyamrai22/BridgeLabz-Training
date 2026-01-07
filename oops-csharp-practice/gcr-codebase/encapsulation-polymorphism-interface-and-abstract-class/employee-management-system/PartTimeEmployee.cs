using System;

namespace BridgeLabzTraining.oops_csharp_practice.encapsulation_polymorphism_interface_and_abstract_class.employee_management_system
{
    public class PartTimeEmployee : Employee, IDepartment
    {
        private int workHours;
        private string department;

        public PartTimeEmployee(int id, string name, double hourlyRate, int workHours)
            : base(id, name, hourlyRate)
        {
            this.workHours = workHours;
        }

        public override double CalculateSalary()
        {
            return baseSalary * workHours;
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
