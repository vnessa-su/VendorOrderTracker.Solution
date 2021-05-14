using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Vendor
  {
    public string Name {get; set;}
    public string Description {get; set;}
    public string Address {get; set;}
    public string PhoneNumber {get; set;}
    public static int Id {get; private set;}

    private List<Order> _vendorOrders =  new List<Order>{};

    public Vendor(string name, string description, string address, string phoneNumber)
    {
      Name = name;
      Description = description;
      Address = address;
      PhoneNumber = phoneNumber;
      Id = 0;
    }

    public void ClearOrders()
    {
      _vendorOrders.Clear();
    }

    public void AddOrder(Order newOrder)
    {

    }
  }
}