namespace HealthClinicApp.Interfaces
{
  public interface IBillingService
  {
    int GenerateBill(int visitId, decimal amount);
    int MarkBillAsPaid(int billId, string paymentMode);
  }
}
