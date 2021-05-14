using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VendorOrderTracker.Models;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    private static string _vendorName = "Explorateur Cafe";
    private static string _description = "Californian French cafe, bar and restaurant";
    private static string _address = "186 Tremont St, Boston, MA 02116";
    private static string _phoneNumber = "617-466-6600";
    private Vendor _vendorObject = new Vendor(_vendorName, _description, _address, _phoneNumber);

    public void Dispose()
    {
      _vendorObject.ClearOrders();
    }

    [TestMethod]
    public void AddOrder_OrderObject_ListWithOneOrder()
    {
      string orderTitle = "Regular Croissant Order";
      string orderDescription = "20 Croissants - $1.00 each";
      string orderDate = "05/04/2021";
      string deliveryDate = "05/16/2021";
      decimal price = 20.00m;
      Order newOrder = new Order(orderTitle, orderDescription, orderDate, deliveryDate, price);
      _vendorObject.AddOrder(newOrder);
    }
  }
}