using System;

class HospitalManagementUtilityImpl : IHospital
{
  private Patient[] patients;
  private int count;
  private int capacity;

  public HospitalManagementUtilityImpl(int capacity)
  {
    this.capacity = capacity;
    patients = new Patient[capacity];
    count = 0;
  }
  public void AddPatient(Patient patient)
  {
    if (count >= capacity)
    {
      Console.WriteLine("List is already full.");
      return;
    }
    patients[count++] = patient;
    Console.WriteLine("Patient added successfully");
  }
  public void DisplayHighestBills()
  {
    BubbleSort();
    Console.Write("Enter the number of patients you want to see --> ");
    int n = int.Parse(Console.ReadLine());
    int limit = Math.Min(n, count);
    for (int i = 0; i < limit; i++)
    {
      Console.WriteLine($"{i + 1}.{patients[i].PatientName} || {patients[i].Bill}");
    }
  }
  private void BubbleSort()
  {
    for (int i = 0; i < count - 1; i++)
    {
      bool swapped = false;
      for (int j = 0; j < count - i - 1; j++)
      {
        if (patients[j].Bill < patients[j + 1].Bill)
        {
          Patient temp = patients[j];
          patients[j] = patients[j + 1];
          patients[j + 1] = temp;

          swapped = true;
        }
      }
      if (!swapped)
      {
        break;
      }
    }
  }
}