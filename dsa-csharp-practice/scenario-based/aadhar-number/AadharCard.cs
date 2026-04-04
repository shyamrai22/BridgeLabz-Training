/// <summary>
/// Represents an Aadhaar card entity that stores and manages Aadhaar details,
/// including the unique Aadhaar number, cardholder name, and registered phone number.
/// Provides initialization through a constructor and a formatted string output
/// for displaying Aadhaar information.
/// </summary>


class AadharCard
{
  public string AadharNumber { get; set; }
  private string AadharName;
  private string PhoneNumber;

  public AadharCard(string aadharNumber, string aadharName, string phoneNumber)
  {
    AadharNumber = aadharNumber;
    AadharName = aadharName;
    PhoneNumber = phoneNumber;
  }

  public override string ToString()
  {
    return $"{AadharNumber} || {AadharName} || {PhoneNumber}";
  }
}