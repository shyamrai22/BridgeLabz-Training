namespace HealthClinicApp.Models
{
  public class Doctor
  {
    public int DoctorId { get; set; }
    public string Name { get; set; }
    public string Specialization { get; set; }
    public string Phone { get; set; }
    public decimal ConsultationFee { get; set; }
    public bool IsActive { get; set; }
  }
}
