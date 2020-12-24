using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using OrderTracker.Models;

namespace OrderTracker.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet ("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> vendorList = Vendor.GetAll();
      return View(vendorList);
    }

    [HttpGet ("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor currentVendor = Vendor.Find(id);
      List<Order> vendorOrders = currentVendor.Orders;
      model.Add("vendor", currentVendor);
      model.Add("orders", vendorOrders);
      return View(model);
    }

    [HttpPost ("/vendors/{vendorId}/order")]
    public ActionResult Create (int vendorId, string title, string description, int price, string date)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor currentVendor = Vendor.Find(vendorId);
      Order newOrder = new Order(title, description, price, date);
      currentVendor.AddOrder(newOrder);
      List<Order> vendorOrders = currentVendor.Orders;
      model.Add("vendor", currentVendor);
      model.Add("orders", vendorOrders);
      return View("Show", model);
    }
  }
}