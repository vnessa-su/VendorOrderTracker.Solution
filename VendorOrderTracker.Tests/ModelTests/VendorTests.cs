using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
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
    public void GetAllOrders_NoOrders_EmptyList()
    {
      List<Order> allVendorOrders = _vendorObject.GetAllOrders();
      Assert.AreEqual(0, allVendorOrders.Count);
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
      List<Order> allVendorOrders = _vendorObject.GetAllOrders();
      Assert.AreEqual(1, allVendorOrders.Count);
    }

    [TestMethod]
    public void DeleteOrder_SecondOrderDeletedOfThreeOrders_TwoOrdersInListWithThirdOrderNowSecond()
    {
      string orderOneTitle = "Regular Croissant Order";
      string orderOneDescription = "20 Croissants - $1.00 each";
      string orderOneDate = "05/04/2021";
      string deliveryDateOne = "05/16/2021";
      decimal priceOne = 20.00m;
      Order orderOne = new Order(orderOneTitle, orderOneDescription, orderOneDate, deliveryDateOne, priceOne);
      _vendorObject.AddOrder(orderOne);

      string orderTwoTitle = "Small Baguette Order";
      string orderTwoDescription = "5 Baguettes - $2.00 each";
      string orderTwoDate = "05/01/2021";
      string deliveryTwoDate = "05/18/2021";
      decimal priceTwo = 10.00m;
      Order orderTwo = new Order(orderTwoTitle, orderTwoDescription, orderTwoDate, deliveryTwoDate, priceTwo);
      _vendorObject.AddOrder(orderTwo);

      string orderThreeTitle = "Large Muffin Order";
      string orderThreeDescription = "50 Muffins - $0.75 each";
      string orderThreeDate = "05/11/2021";
      string deliveryThreeDate = "05/14/2021";
      decimal priceThree = 37.50m;
      Order orderThree = new Order(orderThreeTitle, orderThreeDescription, orderThreeDate, deliveryThreeDate, priceThree);
      _vendorObject.AddOrder(orderThree);

      int indexOfOrderToDelete = 1;
      _vendorObject.DeleteOrder(indexOfOrderToDelete);

      List<Order> allVendorOrders = _vendorObject.GetAllOrders();
      Order secondOrderAfterDelete = allVendorOrders[1];
      Assert.AreEqual(2, allVendorOrders.Count);
      Assert.AreEqual(orderThreeTitle, secondOrderAfterDelete.Title);
    }
  }
}