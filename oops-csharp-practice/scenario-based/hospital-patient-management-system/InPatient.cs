using System;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.hospital_patient_management_system
{
    class InPatient : Patient
    {
        private string roomNumber;
        private Doctor doctorAssigned;
        private double roomChargePerDay;

        public double RoomChargePerDay
        {
            get { return roomChargePerDay; }
        }

        public InPatient(
            string patientId,
            string patientName,
            string roomNumber,
            Doctor doctorAssigned,
            double roomChargePerDay
        ) : base(patientId, patientName)
        {
            this.roomNumber = roomNumber;
            this.doctorAssigned = doctorAssigned;
            this.roomChargePerDay = roomChargePerDay;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("====== InPatient Info ======");
            base.DisplayInfo();
            Console.WriteLine($"Room Number --> {roomNumber}");
            Console.WriteLine($"Room Charge Per Day --> {roomChargePerDay}");
            Console.WriteLine("============================");
            Console.WriteLine();

            doctorAssigned.DisplayInfo();
        }
    }
}
