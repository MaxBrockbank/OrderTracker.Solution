using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using OrderTracker.Models;
namespace OrderTracker.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet ("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost("/")]
    public ActionResult Create(string name, string description)
    {
      Vendor newVendor = new Vendor(name, description);
      return RedirectToAction("Index");
    }
  }
}