using System;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.vechile_management_system
{
    class RentalService
    {
        private Vechile[] vechiles;
        private Customer[] customers;

        private int vechileCount;
        private int customerCount;

        public RentalService(int vechileCapacity, int customerCapacity)
        {
            vechiles = new Vechile[vechileCapacity];
            customers = new Customer[customerCapacity];
            vechileCount = 0;
            customerCount = 0;
        }

        // VECHILE

        public void AddVechile(Vechile vechile)
        {
            if (vechileCount >= vechiles.Length)
            {
                Console.WriteLine("Vechile storage full.");
                return;
            }

            vechiles[vechileCount++] = vechile;
            Console.WriteLine("Vechile added successfully.");
        }

        public void DisplayAllVechiles()
        {
            for (int i = 0; i < vechileCount; i++)
            {
                Console.WriteLine($"Vechile Index: {i}");
                Console.WriteLine($"Type: {vechiles[i].GetType().Name}");
            }
        }

        // CUSTOMER

        public void AddCustomer(Customer customer)
        {
            if (customerCount >= customers.Length)
            {
                Console.WriteLine("Customer storage full.");
                return;
            }

            customers[customerCount++] = customer;
            Console.WriteLine("Customer added successfully.");
        }

        // RENTAL

        public void RentVechile(int customerIndex, int vechileIndex, int days)
        {
            if (customerIndex < 0 || customerIndex >= customerCount ||
                vechileIndex < 0 || vechileIndex >= vechileCount)
            {
                Console.WriteLine("Invalid index.");
                return;
            }

            Vechile vechile = vechiles[vechileIndex];
            double rent = vechile.CalculateRent(days);

            Console.WriteLine("Vechile rented successfully.");
            Console.WriteLine($"Total Rent for {days} days : {rent}");
        }
    }
}
