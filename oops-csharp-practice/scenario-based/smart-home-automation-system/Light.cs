using System;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.smart_home_automation_system
{
    class Light : Appliance, IControllable
    {
        private bool isLightOn = false;

        public Light(string applianceId,
                     string applianceName,
                     string applianceVersion)
            : base(applianceId, applianceName, applianceVersion)
        {
        }

        public void TurnOn()
        {
            if (isLightOn)
            {
                Console.WriteLine("Light is already ON");
                return;
            }

            Console.WriteLine("Light is ON");
            isLightOn = true;
        }

        public void TurnOff()
        {
            if (!isLightOn)
            {
                Console.WriteLine("Light is already OFF");
                return;
            }

            Console.WriteLine("Light is OFF");
            isLightOn = false;
        }
    }
}
