using System;

namespace BridgeLabzTraining.oops_csharp_practice.encapsulation_polymorphism_interface_and_abstract_class.vehicle_rental_system
{
    class VehicleRentalCaller
    {
        static void Main(string[] args)
        {
            Vehicle[] vehicles = new Vehicle[5];
            int index = 0;

            vehicles[index++] = new Car("UP32AB1234", 2000, "CAR-INS-101");
            vehicles[index++] = new Bike("UP32XY5678", 800, "BIKE-INS-202");
            vehicles[index++] = new Truck("UP32TR9090", 5000, "TRUCK-INS-303");

            int rentalDays = 3;

            Console.WriteLine("VEHICLE RENTAL DETAILS");
            Console.WriteLine();

            for (int i = 0; i < index; i++)
            {
                PrintRentalDetails(vehicles[i], rentalDays);
                Console.WriteLine("------------------------------------------------");
            }

            Console.ReadLine();
        }

        static void PrintRentalDetails(Vehicle vehicle, int days)
        {
            vehicle.DisplayVehicleDetails();

            double rentalCost = vehicle.CalculateRentalCost(days);
            double insurance = 0;

            if (vehicle is IInsurable insurable)
            {
                insurance = insurable.CalculateInsurance();
                Console.WriteLine($"Insurance     : {insurable.GetInsuranceDetails()}");
            }

            Console.WriteLine($"Rental Days  : {days}");
            Console.WriteLine($"Rental Cost  : {rentalCost}");
            Console.WriteLine($"Insurance    : {insurance}");
            Console.WriteLine($"Total Amount : {rentalCost + insurance}");
        }
    }
}
