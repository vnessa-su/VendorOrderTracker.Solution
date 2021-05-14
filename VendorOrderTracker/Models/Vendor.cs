using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Vendor
  {
    public string Name {get; set;}
    public string Description {get; set;}
    public string Address {get; set;}
    public string PhoneNumber {get; set;}
    public int Id {get; private set;}
    private static int CurrentId {get; set;}

    private List<Order> _vendorOrders =  new List<Order>{};

    public Vendor(string name, string description, string address, string phoneNumber)
    {
      Name = name;
      Description = description;
      Address = address;
      PhoneNumber = phoneNumber;
      CurrentId++;
      Id = CurrentId;
    }

    public void ClearOrders()
    {
      _vendorOrders.Clear();
    }

    public List<Order> GetAllOrders()
    {
      return _vendorOrders;
    }

    public void AddOrder(Order newOrder)
    {
      _vendorOrders.Add(newOrder);
    }
  }
}