namespace HealthClinicApp.Models
{
  public class AuditLog
  {
    public int AuditId { get; set; }
    public string TableName { get; set; }
    public string Operation { get; set; }
    public int RecordId { get; set; }
    public DateTime PerformedAt { get; set; }
    public string PerformedBy { get; set; }
  }
}
