using System;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.traffic_manager
{
    class RoundaboutUtility: ITrafficRoundabout 
    {
        private Vehicle head;
        private Vehicle tail;
        private int count;

        public void AddVehicle(string vehicleId)
        {
            Vehicle newVehicle = new Vehicle(vehicleId);

            if(head == null)
            {
                head = tail = newVehicle;
                tail.Next = head;
            }
            else
            {
                tail.Next = newVehicle;
                tail = newVehicle;
                tail.Next = head;
            }
            count++;
        }

        public void RemoveVehicle()
        {
            if(head == null)
            {
                Console.WriteLine("Roundabout is empty");
                return;
            }

            Console.WriteLine($"Vehicle {head.VehicleId} has exited the roundabout");
            
            if(head == tail)
            {
                head = tail = null;
            }
            else
            {
                head = head.Next;
                tail.Next = head;
            }
            count--;
        }

        public void DisplayRoundabout()
        {
            if(head == null)
            {
                Console.WriteLine("Roundabout is empty");
                return;
            }

            int tempCount = count;
            Console.WriteLine("Roundabout vehicles: ");
            Vehicle temp = head;
            while (tempCount > 0)
            {
                Console.Write($"{temp.VehicleId} --> ");
                temp = temp.Next;
                tempCount--;
            }
        }
    }
}
