class OutPatient : Patient
{

  public OutPatient(string patientId, string patientName, double consultationFee) : base(patientId, patientName)
  {
    Bill = consultationFee;
  }
}