using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VendorOrderTracker.Models;

namespace VendorOrderTracker.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      Dictionary<int, Vendor> allVendors = Vendor.GetAllVendors();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName, string vendorDescription, string vendorAddress, string vendorPhoneNumber)
    {
      Vendor newVendor = new Vendor(vendorName, vendorDescription, vendorAddress, vendorPhoneNumber);
      return RedirectToAction("Index", "Home");
    }

    [HttpGet("/vendors/{vendorId}")]
    public ActionResult Show(int vendorId)
    {
      Dictionary<string, object> vendorInformation =  new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.GetVendor(vendorId);
      List<Order> vendorOrders = selectedVendor.GetAllOrders();
      vendorInformation.Add("vendor", selectedVendor);
      vendorInformation.Add("orders", vendorOrders);
      return View(vendorInformation);
    }
  }
}