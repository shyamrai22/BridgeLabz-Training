using System;

namespace BridgeLabzTraining.oops_csharp_practice.inheritance
{
    // Superclass
    class Device
    {
        public int DeviceId;
        public string Status;  

        public Device(int deviceId, string status)
        {
            DeviceId = deviceId;
            Status = status;
        }

        // Virtual method
        public virtual void DisplayStatus()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine($"Device ID --> {DeviceId}");
            Console.WriteLine($"Status    --> {Status}");
        }
    }

    // Thermostat Subclass
    class Thermostat : Device
    {
        public double TemperatureSetting;

        public Thermostat(int deviceId, string status, double temperatureSetting) : base(deviceId, status)
        {
            TemperatureSetting = temperatureSetting;
        }

        // Overriding
        public override void DisplayStatus()
        {
            Console.WriteLine("Thermostat Status");
            base.DisplayStatus();
            Console.WriteLine($"Temperature (in Celsius) --> {TemperatureSetting}");
            Console.WriteLine("---------------------------");
        }
    }

    // Caller class
    class Caller
    {
        public static void Main(string[] args)
        {
            Device device1 = new Thermostat(101, "ON", 26.5);
            device1.DisplayStatus();
        }
    }
}
