using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using OrderTracker.Models;

namespace OrderTracker.Controllers
{
  public class OrderController : Controller
  {
    [HttpGet("/order")]
    public ActionResult Index()
    {
      List<Order> ordersList = Order.GetAll();
      return View(ordersList);
    }
  }
}