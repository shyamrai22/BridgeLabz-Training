using System;

namespace BridgeLabzTraining.oops_csharp_practice.encapsulation_polymorphism_interface_and_abstract_class.ride_hailing_application
{
    public abstract class Vehicle
    {
        private int vehicleId;
        private string driverName;
        protected double ratePerKm;

        public Vehicle(int vehicleId, string driverName, double ratePerKm)
        {
            this.vehicleId = vehicleId;
            this.driverName = driverName;
            this.ratePerKm = ratePerKm;
        }

        public abstract double CalculateFare(double distance);

        public void GetVehicleDetails()
        {
            Console.WriteLine("Vehicle ID  : " + vehicleId);
            Console.WriteLine("Driver Name : " + driverName);
            Console.WriteLine("Rate / Km   : " + ratePerKm);
        }
    }
}
