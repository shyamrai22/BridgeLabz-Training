using System;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.smart_home_automation_system
{
    class Ac : Appliance, IControllable
    {
        private bool isAcOn = false;

        public Ac(string applianceId,
                  string applianceName,
                  string applianceVersion)
            : base(applianceId, applianceName, applianceVersion)
        {
        }

        public void TurnOn()
        {
            if (isAcOn)
            {
                Console.WriteLine("AC is already ON");
                return;
            }

            Console.WriteLine("AC is ON");
            isAcOn = true;
        }

        public void TurnOff()
        {
            if (!isAcOn)
            {
                Console.WriteLine("AC is already OFF");
                return;
            }

            Console.WriteLine("AC is OFF");
            isAcOn = false;
        }
    }
}
