using System;

namespace AddressBook.Exceptions
{
  public class ContactNotFoundException : Exception
  {
    public ContactNotFoundException(string message)
        : base(message)
    {
    }
  }
}
