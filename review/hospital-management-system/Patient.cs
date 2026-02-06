class Patient
{
  public string PatientId { get; set; }
  public string PatientName { get; set; }
  public double Bill { get; set; }


  public Patient(string patientId, string patientName)
  {
    PatientId = patientId;
    PatientName = patientName;
  }

  public override string ToString()
  {
    return $"{PatientName} || {Bill}";
  }
}