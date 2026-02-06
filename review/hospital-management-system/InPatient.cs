class InPatient : Patient
{
  private double NumberOfDays { get; set; }
  private double RoomCharge { get; set; }

  public InPatient(string patientId, string patientName, double numberOfDays, double roomCharge) : base(patientId, patientName)
  {
    NumberOfDays = numberOfDays;
    RoomCharge = roomCharge;
    Bill = RoomCharge * NumberOfDays;
  }
}