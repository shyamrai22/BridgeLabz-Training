/// <summary>
/// Implements core Aadhaar management operations using an array-based approach.
/// Supports adding Aadhaar records with validation, sorting records using
/// radix sort for efficient searching, and performing binary search to
/// locate Aadhaar numbers. Ensures data integrity through capacity checks
/// and digit-length validation.
/// </summary>


using System;

class AadharUtilityImpl : IAadhar
{
  private AadharCard[] aadharCards;
  private int capacity;
  private int size;

  public AadharUtilityImpl(int capacity)
  {
    this.capacity = capacity;
    aadharCards = new AadharCard[capacity];
    size = 0;
  }

  public void AddAadharCard()
  {
    if (size >= capacity)
    {
      Console.WriteLine("Already full");
      return;
    }

    Console.Write("Enter a aadhar card number --> ");
    string aadharCardNumber = Console.ReadLine().Trim();
    if (aadharCardNumber.Length != 12)
    {
      Console.WriteLine("Invalid Entry.");
      return;
    }

    Console.Write("Enter a aadhar card recipient name --> ");
    string aadharName = Console.ReadLine().Trim();

    Console.Write("Enter a phone number to be linked with aadhar card --> ");
    string phoneNumber = Console.ReadLine().Trim();
    if (phoneNumber.Length != 10)
    {
      Console.WriteLine("Invalid Entry.");
      return;
    }

    AadharCard newAadharCard = new AadharCard(aadharCardNumber, aadharName, phoneNumber);
    aadharCards[size++] = newAadharCard;
    RadixSort();
    Console.WriteLine("Aadhar added successfully.");
  }

  public void SearchNumber()
  {
    Console.Write("Enter a number --> ");
    string target = Console.ReadLine().Trim();
    if (target.Length != 12)
    {
      Console.WriteLine("Invalid Entry");
      return;
    }
    int left = 0;
    int right = size - 1;
    while (left <= right)
    {
      int mid = left + (right - left) / 2;
      int com = string.Compare(aadharCards[mid].AadharNumber.Trim(), target);
      if (com == 0)
      {
        Console.WriteLine(aadharCards[mid]);
        return;
      }
      else if (com > 0)
      {
        right = mid - 1;
      }
      else
      {
        left = mid + 1;
      }
    }
    Console.WriteLine("No match found.");
  }

  private void RadixSort()
  {
    int digits = 12;

    for (int pos = digits - 1; pos >= 0; pos--)
    {
      CountingSortByDigit(pos);
    }
  }

  private void CountingSortByDigit(int pos)
  {
    AadharCard[] output = new AadharCard[size];
    int[] count = new int[10];

    for (int i = 0; i < size; i++)
    {
      int digit = aadharCards[i].AadharNumber[pos] - '0';
      count[digit]++;
    }

    for (int i = 1; i < 10; i++)
    {
      count[i] += count[i - 1];
    }

    for (int i = size - 1; i >= 0; i--)
    {
      int digit = aadharCards[i].AadharNumber[pos] - '0';
      output[--count[digit]] = aadharCards[i];
    }

    for (int i = 0; i < size; i++)
    {
      aadharCards[i] = output[i];
    }
  }

}