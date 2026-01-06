using System;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.vechile_management_system
{
    class Program
    {
        static void Main(string[] args)
        {
            RentalService rentalService = new RentalService(10, 10);
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("===== VEHICLE RENTAL SYSTEM =====");
                Console.WriteLine("1. Add Bike");
                Console.WriteLine("2. Add Car");
                Console.WriteLine("3. Add Truck");
                Console.WriteLine("4. Add Customer");
                Console.WriteLine("5. View Vehicles");
                Console.WriteLine("6. Rent Vehicle");
                Console.WriteLine("7. Exit");
                Console.Write("Enter your choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Bike ID: ");
                        string bikeId = Console.ReadLine();

                        Console.Write("Brand: ");
                        string bikeBrand = Console.ReadLine();

                        Console.Write("Model: ");
                        string bikeModel = Console.ReadLine();

                        Console.Write("Registration Number: ");
                        string bikeReg = Console.ReadLine();

                        Console.Write("Engine CC: ");
                        double engineCC = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Bike Type: ");
                        string bikeType = Console.ReadLine();

                        Console.Write("Has Gear (true/false): ");
                        bool hasGear = Convert.ToBoolean(Console.ReadLine());

                        Console.Write("Base Rent Per Day: ");
                        double bikeRent = Convert.ToDouble(Console.ReadLine());

                        Bike bike = new Bike(
                            bikeId, bikeBrand, bikeModel, bikeReg,
                            engineCC, bikeType, hasGear, bikeRent
                        );

                        rentalService.AddVechile(bike);
                        break;

                    case 2:
                        Console.Write("Car ID: ");
                        string carId = Console.ReadLine();

                        Console.Write("Brand: ");
                        string carBrand = Console.ReadLine();

                        Console.Write("Model: ");
                        string carModel = Console.ReadLine();

                        Console.Write("Registration Number: ");
                        string carReg = Console.ReadLine();

                        Console.Write("Number of Seats: ");
                        int seats = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Fuel Type: ");
                        string fuelType = Console.ReadLine();

                        Console.Write("Transmission Type: ");
                        string transmission = Console.ReadLine();

                        Console.Write("Has AC (true/false): ");
                        bool hasAC = Convert.ToBoolean(Console.ReadLine());

                        Console.Write("Base Rent Per Day: ");
                        double carRent = Convert.ToDouble(Console.ReadLine());

                        Car car = new Car(
                            carId, carBrand, carModel, carReg,
                            seats, fuelType, transmission, hasAC, carRent
                        );

                        rentalService.AddVechile(car);
                        break;

                    case 3:
                        Console.Write("Truck ID: ");
                        string truckId = Console.ReadLine();

                        Console.Write("Brand: ");
                        string truckBrand = Console.ReadLine();

                        Console.Write("Model: ");
                        string truckModel = Console.ReadLine();

                        Console.Write("Registration Number: ");
                        string truckReg = Console.ReadLine();

                        Console.Write("Load Capacity (tons): ");
                        int load = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Number of Axles: ");
                        int axles = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Is Commercial (true/false): ");
                        bool isCommercial = Convert.ToBoolean(Console.ReadLine());

                        Console.Write("Base Rent Per Day: ");
                        double truckRent = Convert.ToDouble(Console.ReadLine());

                        Truck truck = new Truck(
                            truckId, truckBrand, truckModel, truckReg,
                            load, axles, isCommercial, truckRent
                        );

                        rentalService.AddVechile(truck);
                        break;

                    case 4:
                        Console.Write("Customer ID: ");
                        string customerId = Console.ReadLine();

                        Console.Write("Name: ");
                        string name = Console.ReadLine();

                        Console.Write("Phone Number: ");
                        string phone = Console.ReadLine();

                        Console.Write("Driving License Number: ");
                        string license = Console.ReadLine();

                        Customer customer = new Customer(
                            customerId, name, phone, license, null
                        );

                        rentalService.AddCustomer(customer);
                        break;

                    case 5:
                        rentalService.DisplayAllVechiles();
                        break;

                    case 6:
                        Console.Write("Enter Customer Index: ");
                        int customerIndex = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Vehicle Index: ");
                        int vechileIndex = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter number of days: ");
                        int days = Convert.ToInt32(Console.ReadLine());

                        rentalService.RentVechile(customerIndex, vechileIndex, days);
                        break;

                    case 7:
                        exit = true;
                        Console.WriteLine("Exiting system...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}
