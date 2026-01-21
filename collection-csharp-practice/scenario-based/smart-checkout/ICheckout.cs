/// <summary>
/// Defines a contract for a checkout system that supports adding customers to a queue,
/// removing customers after billing, and displaying available item prices.
/// </summary>


interface ICheckout
{
    void AddACustomer();

    void RemoveCustomer();

    void FetchItemPrice();
}

