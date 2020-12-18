using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using OrderTracker.Models;

namespace OrderTracker.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet ("/vendor")]
    public ActionResult Index()
    {
      List<Vendor> vendorList = Vendor.GetAll();
      return View(vendorList);
    }

    [HttpGet ("/vendor/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendor")]
    public ActionResult Create(string name, string description)
    {
      Vendor newVendor = new Vendor(name, description);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendor/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor currentVendor = Vendor.Find(id);
      List<Order> vendorOrders = currentVendor.Orders;
      model.Add("vendor", currentVendor);
      model.Add("orders", vendorOrders);
      return View(model);
    }
  }
}