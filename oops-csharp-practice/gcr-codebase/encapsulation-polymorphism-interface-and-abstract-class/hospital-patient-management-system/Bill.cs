using System;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.hospital_patient_management_system
{
    class Bill : IPayable
    {
        public void CalculateBill(Patient patient)
        {
            if (patient is InPatient inPatient)
            {
                Console.Write("Enter number of days admitted: ");
                int days = int.Parse(Console.ReadLine());
                Console.WriteLine();

                double total = inPatient.RoomChargePerDay * days;
                Console.WriteLine($"Total In-Patient Bill --> {total}");
            }
            else if (patient is OutPatient outPatient)
            {
                double total = outPatient.ConsultationFee;
                Console.WriteLine($"Total Out-Patient Bill --> {total}");
            }
            else
            {
                Console.WriteLine("Invalid patient type.");
            }
        }
    }
}
