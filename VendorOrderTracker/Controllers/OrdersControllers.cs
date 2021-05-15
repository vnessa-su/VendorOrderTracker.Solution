using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VendorOrderTracker.Models;

namespace VendorOrderTracker.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor selectedVendor = Vendor.GetVendor(vendorId);
      return View(selectedVendor);
    }

    [HttpGet("/vendors/{vendorId}/orders/{orderIndex}")]
    public ActionResult Show(int vendorId, int orderIndex)
    {
      Dictionary<string, object> orderInformation =  new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.GetVendor(vendorId);
      List<Order> vendorOrders = selectedVendor.GetAllOrders();
      Order selectedOrder = vendorOrders[orderIndex];
      orderInformation.Add("order", selectedOrder);
      orderInformation.Add("vendor", selectedVendor);
      return View(orderInformation);
    }
  }
}