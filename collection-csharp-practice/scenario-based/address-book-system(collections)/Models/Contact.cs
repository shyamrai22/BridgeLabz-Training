using System;

namespace AddressBook.Models
{
  public class Contact
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Zip { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }

    public Contact(
    string firstName,
    string lastName,
    string address,
    string city,
    string state,
    string zip,
    string phone,
    string email)
    {
      FirstName = firstName;
      LastName = lastName;
      Address = address;
      City = city;
      State = state;
      Zip = zip;
      Phone = phone;
      Email = email;
    }


    // For Duplicate Check (UC7)
    public override bool Equals(object? obj)
    {
      if (obj is Contact other)
      {
        return FirstName.Equals(other.FirstName, StringComparison.OrdinalIgnoreCase)
            && LastName.Equals(other.LastName, StringComparison.OrdinalIgnoreCase);
      }

      return false;
    }

    public override int GetHashCode()
    {
      return (FirstName + LastName)
          .ToLower()
          .GetHashCode();
    }

    // For Display (UC11)
    public override string ToString()
    {
      return $"{FirstName} {LastName} | {City} | {State} | {Phone}";
    }
  }
}
