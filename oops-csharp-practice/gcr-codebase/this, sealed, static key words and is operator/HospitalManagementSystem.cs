using System;

namespace BridgeLabzTraining.oops_csharp_practice.this__sealed__static_key_words_and_is_operator
{
    class Patient
    {
        public static string HospitalName = "ABC Hospital";
        private static int totalPatients = 0;
        public readonly int PatientID;

        // instance variables
        public string Name;
        public int Age;
        public string Ailment;

        // using 'this' keyword
        public Patient(int patientID, string name, int age, string ailment)
        {
            this.PatientID = patientID;   
            this.Name = name;
            this.Age = age;
            this.Ailment = ailment;
            totalPatients++;
        }

        // static method
        public static void GetTotalPatients()
        {
            Console.WriteLine($"Total Patients --> {totalPatients}");
        }

        // using 'is' operator
        public void DisplayDetails(object obj)
        {
            if (obj is Patient)
            {
                Console.WriteLine("============================");
                Console.WriteLine($"Hospital Name --> {HospitalName}");
                Console.WriteLine($"Patient ID    --> {PatientID}");
                Console.WriteLine($"Name          --> {Name}");
                Console.WriteLine($"Age           --> {Age}");
                Console.WriteLine($"Ailment       --> {Ailment}");
                Console.WriteLine("============================");
            }
            else
            {
                Console.WriteLine("Object is not a Patient");
            }
        }
    }

    // Caller class
    class Caller
    {
        public static void Main(string[] args)
        {
            Patient patient1 = new Patient(1, "Shyam", 22, "Fever");
            Patient patient2 = new Patient(2, "raman", 22, "Cold");
            patient1.DisplayDetails(patient1);
            patient2.DisplayDetails(patient2);

            Patient.GetTotalPatients();

            object obj = "Not patient";
            patient1.DisplayDetails(obj);
        }
    }
}
