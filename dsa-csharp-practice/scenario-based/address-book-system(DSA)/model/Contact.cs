using System;

namespace AddressBookSystem.model
{
  public class Contact
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Zip { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }

    public override string ToString()
    {
      return $"{FirstName} {LastName}, {City}, {State}";
    }

    public override bool Equals(object obj)
    {
      if (obj == null || GetType() != obj.GetType())
        return false;

      Contact other = (Contact)obj;

      return string.Equals(FirstName, other.FirstName, StringComparison.OrdinalIgnoreCase)
          && string.Equals(LastName, other.LastName, StringComparison.OrdinalIgnoreCase);
    }

    public override int GetHashCode()
    {
      return (FirstName?.ToLower() + LastName?.ToLower()).GetHashCode();
    }
  }
}
