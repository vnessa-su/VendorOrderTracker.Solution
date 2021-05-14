using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VendorOrderTracker.Models;

namespace VendorOrderTracker.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpGet("/vendors/{vendorId}/orders/{orderIndex}")]
    public ActionResult Show(int vendorId, int orderIndex)
    {
      Dictionary<string, object> vendorInformation =  new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.GetVendor(vendorId);
      List<Order> vendorOrders = selectedVendor.GetAllOrders();
      Order selectedOrder = vendorOrders[orderIndex];
      return View(selectedOrder);
    }
  }
}