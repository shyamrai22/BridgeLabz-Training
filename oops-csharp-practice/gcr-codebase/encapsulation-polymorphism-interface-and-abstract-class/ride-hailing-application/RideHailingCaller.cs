using System;

namespace BridgeLabzTraining.oops_csharp_practice.encapsulation_polymorphism_interface_and_abstract_class.ride_hailing_application
{
    class RideHailingCaller
    {
        static void Main(string[] args)
        {
            Vehicle[] vehicles = new Vehicle[5];
            int index = 0;

            vehicles[index++] = new Car(1, "Rahul", 15);
            vehicles[index++] = new Bike(2, "Amit", 8);
            vehicles[index++] = new Auto(3, "Raman", 12);

            double distance = 10;

            Console.WriteLine("RIDE DETAILS");
            Console.WriteLine();

            for (int i = 0; i < index; i++)
            {
                ProcessRide(vehicles[i], distance);
                Console.WriteLine("----------------------------------");
            }
        }

        static void ProcessRide(Vehicle vehicle, double distance)
        {
            vehicle.GetVehicleDetails();

            double fare = vehicle.CalculateFare(distance);
            Console.WriteLine("Distance : " + distance + " km");
            Console.WriteLine("Fare     : " + fare);
        }
    }
}
