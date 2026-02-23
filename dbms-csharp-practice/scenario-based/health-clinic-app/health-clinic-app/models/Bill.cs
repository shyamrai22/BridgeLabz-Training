namespace HealthClinicApp.Models
{
  public class Bill
  {
    public int BillId { get; set; }
    public int VisitId { get; set; }
    public decimal Amount { get; set; }
    public string PaymentStatus { get; set; }
    public string PaymentMode { get; set; }
    public DateTime? PaymentDate { get; set; }
  }
}
