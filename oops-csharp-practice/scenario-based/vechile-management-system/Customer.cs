using System;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.vechile_management_system
{
    class Customer
    {
        protected string customerId;
        protected string name;
        protected string phoneNumber;
        protected string drivingLicenseNumber;
        protected Vechile vechile;

        public Customer(string customerId, string name, string phoneNumber, string drivingLicenseNumber, Vechile vechile)
        {
            this.customerId = customerId;
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.drivingLicenseNumber = drivingLicenseNumber;
            this.vechile = vechile;
        }
    }
}
