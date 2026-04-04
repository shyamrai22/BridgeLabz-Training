using System;

namespace BridgeLabzTraining.oops_csharp_practice.encapsulation_polymorphism_interface_and_abstract_class.employee_management_system
{
    public interface IDepartment
    {
        void AssignDepartment(string departmentName);
        string GetDepartmentDetails();
    }
}
