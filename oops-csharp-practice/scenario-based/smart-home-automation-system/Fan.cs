using System;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.smart_home_automation_system
{
    class Fan : Appliance, IControllable
    {
        private bool isFanOn = false;
        private int speed;

        public Fan(string applianceId,
                   string applianceName,
                   string applianceVersion)
            : base(applianceId, applianceName, applianceVersion)
        {
            speed = 1;
        }

        public void TurnOn()
        {
            if (isFanOn)
            {
                Console.WriteLine("Fan is already ON");
                return;
            }

            isFanOn = true;
            Console.WriteLine("Fan is ON");
            Console.WriteLine($"Fan speed set to {speed}");
        }

        public void TurnOff()
        {
            if (!isFanOn)
            {
                Console.WriteLine("Fan is already OFF");
                return;
            }

            isFanOn = false;
            Console.WriteLine("Fan is OFF");
        }
    }
}
