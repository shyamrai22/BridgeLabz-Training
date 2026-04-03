using System;

class TripDetails {

    static void Main(string[] args) {
     
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter starting city: ");
        string fromCity = Console.ReadLine();

        Console.Write("Enter via city: ");
        string viaCity = Console.ReadLine();

        Console.Write("Enter destination city: ");
        string toCity = Console.ReadLine();

        Console.Write("Enter distance from start to via city (in miles): ");
        double fromToVia = double.Parse(Console.ReadLine());

        Console.Write("Enter distance from via city to destination (in miles): ");
        double viaToFinalCity = double.Parse(Console.ReadLine());

        Console.Write("Enter time taken for the journey (in hours): ");
        double timeTaken = double.Parse(Console.ReadLine());

        double totalDistance = fromToVia + viaToFinalCity;
        double averageSpeed = totalDistance / timeTaken;

        Console.WriteLine();
        Console.WriteLine($"The results of the trip are:");
        Console.WriteLine($"Traveler Name: {name}");
        Console.WriteLine($"Route: {fromCity} -> {viaCity} -> {toCity}");
        Console.WriteLine($"Total Distance: {totalDistance} miles");
        Console.WriteLine($"Average Speed: {averageSpeed} miles/hour");
    }
}
