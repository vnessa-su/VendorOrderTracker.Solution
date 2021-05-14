using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using VendorOrderTracker.Models;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class VendorTests
  {
    private Vendor vendor;

    [TestCleanup]
    public void Cleanup()
    {
      Vendor.ClearVendors();
    }

    [TestInitialize]
    public void Initialize()
    {
      string vendorName = "Explorateur Cafe";
      string description = "Californian French cafe, bar and restaurant";
      string address = "186 Tremont St, Boston, MA 02116";
      string phoneNumber = "617-466-6600";
      vendor = new Vendor(vendorName, description, address, phoneNumber);
    }

    [TestMethod]
    public void GetAllOrders_NoOrders_EmptyList()
    {
      List<Order> allVendorOrders = vendor.GetAllOrders();
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
      vendor.AddOrder(newOrder);
      List<Order> allVendorOrders = vendor.GetAllOrders();
      Assert.AreEqual(1, allVendorOrders.Count);
    }

    [TestMethod]
    public void ClearOrders_OneOrder_EmptyList()
    {
      string orderTitle = "Regular Croissant Order";
      string orderDescription = "20 Croissants - $1.00 each";
      string orderDate = "05/04/2021";
      string deliveryDate = "05/16/2021";
      decimal price = 20.00m;
      Order newOrder = new Order(orderTitle, orderDescription, orderDate, deliveryDate, price);
      vendor.AddOrder(newOrder);
      vendor.ClearOrders();
      List<Order> allVendorOrders = vendor.GetAllOrders();
      Assert.AreEqual(0, allVendorOrders.Count);
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
      vendor.AddOrder(orderOne);

      string orderTwoTitle = "Small Baguette Order";
      string orderTwoDescription = "5 Baguettes - $2.00 each";
      string orderTwoDate = "05/01/2021";
      string deliveryTwoDate = "05/18/2021";
      decimal priceTwo = 10.00m;
      Order orderTwo = new Order(orderTwoTitle, orderTwoDescription, orderTwoDate, deliveryTwoDate, priceTwo);
      vendor.AddOrder(orderTwo);

      string orderThreeTitle = "Large Muffin Order";
      string orderThreeDescription = "50 Muffins - $0.75 each";
      string orderThreeDate = "05/11/2021";
      string deliveryThreeDate = "05/14/2021";
      decimal priceThree = 37.50m;
      Order orderThree = new Order(orderThreeTitle, orderThreeDescription, orderThreeDate, deliveryThreeDate, priceThree);
      vendor.AddOrder(orderThree);

      int indexOfOrderToDelete = 1;
      vendor.DeleteOrder(indexOfOrderToDelete);

      List<Order> allVendorOrders = vendor.GetAllOrders();
      Order secondOrderAfterDelete = allVendorOrders[1];
      Assert.AreEqual(2, allVendorOrders.Count);
      Assert.AreEqual(orderThreeTitle, secondOrderAfterDelete.Title);
    }

    [TestMethod]
    public void GetAllVendors_TwoVendors_TwoVendorDictionary()
    {
      string vendorTwoName = "Bikeeny Caffe";
      string descriptionTwo = "Coffee shop serving coffee, sandwiches, and European style pastries, called bikeenies";
      string addressTwo = "62 Summer Street, Malden, MA 02148";
      string phoneNumberTwo = "781-480-4020";
      Vendor vendorTwoObject = new Vendor(vendorTwoName, descriptionTwo, addressTwo, phoneNumberTwo);
      Dictionary<int, Vendor> currentVendors = Vendor.GetAllVendors();
      Assert.AreEqual(2, currentVendors.Count);
    }
  }
}