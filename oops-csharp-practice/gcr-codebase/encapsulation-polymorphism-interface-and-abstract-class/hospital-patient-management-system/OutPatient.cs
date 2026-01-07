using System;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.hospital_patient_management_system
{
    class OutPatient : Patient
    {
        private DateTime arrivalDay;
        private string appointmentNumber;
        private double consultationFee;

        public double ConsultationFee
        {
            get { return consultationFee; }
        }

        public OutPatient(
            string patientId,
            string patientName,
            string appointmentNumber,
            double consultationFee
        ) : base(patientId, patientName)
        {
            arrivalDay = DateTime.Now;
            this.appointmentNumber = appointmentNumber;
            this.consultationFee = consultationFee;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("====== OutPatient Info ======");
            base.DisplayInfo();
            Console.WriteLine($"Arrival Date --> {arrivalDay}");
            Console.WriteLine($"Appointment Number --> {appointmentNumber}");
            Console.WriteLine($"Consultation Fees --> {consultationFee}");
            Console.WriteLine("============================");
            Console.WriteLine();
        }
    }
}
