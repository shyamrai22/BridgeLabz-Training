using System;

namespace BridgeLabzTraining.oops_csharp_buddy.scenario_based.address_book_system
{
    class Contact
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Address { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string Zip { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Email { get; private set; }

        public Contact(string FirstName, string Lastname, string Address, string City,
                       string State, string Zip, string PhoneNumber, string Email)
        {
            this.FirstName = FirstName;
            this.LastName = Lastname;
            this.Address = Address;
            this.City = City;
            this.State = State;
            this.Zip = Zip;
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;
        }

        // update methods
        public void UpdateAddress(string address)
        {
            Address = address;
        }
        public void UpdateCity(string city)
        {
            City = city;
        }
        public void UpdateState(string state)
        {
            State = state;
        }
        public void UpdateZip(string zip)
        {
            Zip = zip;
        }
        public void UpdatePhoneNumber(string phone)
        {
            PhoneNumber = phone;
        }
        public void UpdateEmail(string email)
        {
            Email = email;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} | {City}, {State}, {Zip} | {PhoneNumber} | {Email}";
        }
    }
}
