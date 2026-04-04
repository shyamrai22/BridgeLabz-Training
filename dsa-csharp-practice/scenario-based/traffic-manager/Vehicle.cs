namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.traffic_manager
{
    class Vehicle
    {
        public string VehicleId { get; set; }
        public Vehicle Next { get; set; }

        public Vehicle(string vehicleId)
        {
            VehicleId = vehicleId;
            Next = null;
        }
    }
}
