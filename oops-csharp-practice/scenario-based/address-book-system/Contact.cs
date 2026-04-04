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

        public Contact(
            string firstName,
            string lastName,
            string address,
            string city,
            string state,
            string zip,
            string phoneNumber,
            string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            City = city;
            State = state;
            Zip = zip;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        // Update methods (UC-03)
        public void UpdateAddress(string value) => Address = value;
        public void UpdateCity(string value) => City = value;
        public void UpdateState(string value) => State = value;
        public void UpdateZip(string value) => Zip = value;
        public void UpdatePhone(string value) => PhoneNumber = value;
        public void UpdateEmail(string value) => Email = value;

        public override string ToString()
        {
            return $"{FirstName} {LastName} | {City}, {State}, {Zip} | {PhoneNumber} | {Email}";
        }

        // UC-07 Duplicate check
        public override bool Equals(object obj)
        {
            if (this == obj) return true;
            if (obj == null || GetType() != obj.GetType()) return false;

            Contact other = (Contact)obj;
            return FirstName.Equals(other.FirstName, StringComparison.OrdinalIgnoreCase)
                && LastName.Equals(other.LastName, StringComparison.OrdinalIgnoreCase);
        }
    }
}
