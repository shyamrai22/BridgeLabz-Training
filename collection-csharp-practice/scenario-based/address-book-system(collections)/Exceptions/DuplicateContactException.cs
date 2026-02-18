using System;

namespace AddressBook.Exceptions
{
  public class DuplicateContactException : Exception
  {
    public DuplicateContactException(string message)
        : base(message)
    {
    }
  }
}
