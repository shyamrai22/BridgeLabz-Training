using System;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.hospital_patient_management_system
{
    class Utility
    {
        private Doctor[] doctors = new Doctor[15];
        private Patient[] patients = new Patient[15];

        private int doctorCount = 0;
        private int patientCount = 0;

        public void AddDoctor()
        {
            if (doctorCount >= doctors.Length)
            {
                Console.WriteLine("Doctor limit reached.");
                return;
            }

            Console.Write("Enter Doctor ID: ");
            string id = Console.ReadLine();

            Console.Write("Enter Doctor Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Specialization: ");
            string specialization = Console.ReadLine();

            Console.Write("Enter Department: ");
            string department = Console.ReadLine();

            doctors[doctorCount++] = new Doctor(id, name, specialization, department);

            Console.WriteLine("Doctor added successfully.");
            Console.WriteLine();
        }

        public void AddPatient()
        {
            if (patientCount >= patients.Length)
            {
                Console.WriteLine("Patient limit reached.");
                return;
            }

            Console.WriteLine("1. In-Patient");
            Console.WriteLine("2. Out-Patient");
            Console.Write("Choose patient type: ");
            int choice = int.Parse(Console.ReadLine());

            Console.Write("Enter Patient ID: ");
            string pid = Console.ReadLine();

            Console.Write("Enter Patient Name: ");
            string pname = Console.ReadLine();

            if (choice == 1)
            {
                if (doctorCount == 0)
                {
                    Console.WriteLine("No doctors available.");
                    Console.WriteLine();
                    return;
                }

                Console.Write("Enter Room Number: ");
                string room = Console.ReadLine();

                Console.Write("Enter Room Charge Per Day: ");
                double charge = double.Parse(Console.ReadLine());

                patients[patientCount++] =
                    new InPatient(pid, pname, room, doctors[0], charge);

                Console.WriteLine("In-Patient added successfully.");
                Console.WriteLine();
            }
            else if (choice == 2)
            {
                Console.Write("Enter Appointment Number: ");
                string app = Console.ReadLine();

                Console.Write("Enter Consultation Fee: ");
                double fee = double.Parse(Console.ReadLine());

                patients[patientCount++] =
                    new OutPatient(pid, pname, app, fee);

                Console.WriteLine("Out-Patient added successfully.");
                Console.WriteLine();
            }
        }

        public void DisplayPatients()
        {
            if (patientCount == 0)
            {
                Console.WriteLine("No patients found.");
                Console.WriteLine();
                return;
            }

            for (int i = 0; i < patientCount; i++)
            {
                patients[i].DisplayInfo();
            }
        }

        public void GenerateBill()
        {
            if (patientCount == 0)
            {
                Console.WriteLine("No patients available.");
                Console.WriteLine();
                return;
            }

            Console.WriteLine("Select Patient:");
            for (int i = 0; i < patientCount; i++)
            {
                Console.WriteLine($"{i + 1}. Patient");
            }

            int index = int.Parse(Console.ReadLine()) - 1;
            Bill bill = new Bill();
            bill.CalculateBill(patients[index]);
        }


    }
}
