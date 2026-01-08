using System;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.smart_home_automation_system
{
    class Appliance 
    {
        private string applianceId;
        private string applianceName;
        private string applianceVersion;

        public Appliance(string applianceId, string applianceName, string applianceVersion)
        {
            this.applianceId = applianceId;
            this.applianceName = applianceName;
            this.applianceVersion = applianceVersion;
        }

        public string GetApplianceId ()
        {
            return applianceId;
        }
        public string GetApplianceName()
        {
            return applianceName;
        }
        public string GetApplianceVersion()
        {
            return applianceVersion;
        }
    }
}
