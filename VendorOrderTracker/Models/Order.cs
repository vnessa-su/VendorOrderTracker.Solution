namespace VendorOrderTracker.Models
{
  public class Order
  {
    public string Title {get; set;}
    public string Description {get; set;}
    public string OrderDate {get; set;}
    public string DeliveryDate {get; set;}
    public decimal Price {get; set;}
    public bool IsPaid {get; set;}
    public bool IsFulfilled {get; set;}

    public Order (string title, string description, string orderDate, string deliveryDate, decimal price)
    {
      Title = title;
      Description = description;
      OrderDate = orderDate;
      DeliveryDate = deliveryDate;
      Price = price;
      IsPaid = false;
      IsFulfilled = false;
    }
  }
}