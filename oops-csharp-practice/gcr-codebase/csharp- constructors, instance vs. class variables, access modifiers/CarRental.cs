using System;

namespace BridgeLabzTraining.oops_csharp_practice.csharp_constructors__instance_vs._class_variables__access_modifiers
{
    class CarRental
    {
        private string customerName;
        private string carModel;
        private int rentalDays;
        private int cost;

        private int CostPerDay = 1000;

        // Default constructor
        public CarRental() : this("NA", "NA", 1)
        {
        }

        // Parameterized constructor
        public CarRental(string customerName, string carModel, int rentalDays)
        {
            this.customerName = customerName;
            this.carModel = carModel;
            this.rentalDays = rentalDays;
            CalculateCost();
        }

        // To calculate total cost
        private void CalculateCost()
        {
            cost = rentalDays * CostPerDay;
        }

        // To display rental details
        public void Display()
        {
            Console.WriteLine("==========================");
            Console.WriteLine($"Customer Name --> {customerName}");
            Console.WriteLine($"Car Model     --> {carModel}");
            Console.WriteLine($"Rental Days   --> {rentalDays}");
            Console.WriteLine($"Total Cost    --> {cost}");
            Console.WriteLine("==========================");
        }
    }

    // Caller class
    class Caller
    {
        public static void Main(string[] args)
        {
            CarRental car1 = new CarRental();
            CarRental car2 = new CarRental("Shyam", "Verna", 3);

            car1.Display();
            car2.Display();
        }
    }
}
