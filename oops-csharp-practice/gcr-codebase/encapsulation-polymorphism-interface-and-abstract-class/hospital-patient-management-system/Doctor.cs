using System;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.hospital_patient_management_system
{
    class Doctor
    {
        private string doctorId;
        private string doctorName;
        private string doctorSpecialization;
        private string department;

        public Doctor(
            string doctorId,
            string doctorName,
            string doctorSpecialization,
            string department
        )
        {
            this.doctorId = doctorId;
            this.doctorName = doctorName;
            this.doctorSpecialization = doctorSpecialization;
            this.department = department;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("====== Doctor Info ======");
            Console.WriteLine($"Doctor ID --> {doctorId}");
            Console.WriteLine($"Doctor Name --> {doctorName}");
            Console.WriteLine($"Doctor Specialization --> {doctorSpecialization}");
            Console.WriteLine($"Department --> {department}");
            Console.WriteLine();
        }
    }
}
