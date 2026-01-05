using System;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.hospital_patient_management_system
{
    class Patient
    {
        private readonly string patientId;
        private string patientName;

        public Patient(string patientId, string patientName)
        {
            this.patientId = patientId;
            this.patientName = patientName;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Patient name --> {patientName}");
            Console.WriteLine($"Patient id --> {patientId}");
        }
    }
}
