using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_OrderParameters_OrderObject()
    {
      string orderTitle = "Regular Croissant Order";
      string orderDescription = "20 Croissants - $1.00 each";
      string orderDate = "05/04/2021";
      string deliveryDate = "05/16/2021";
      decimal price = 20.00m;

      Order orderObject = new Order(orderTitle, orderDescription, orderDate, deliveryDate, price);
      Assert.AreEqual(typeof(Order), orderObject.GetType());
    }
  }
}