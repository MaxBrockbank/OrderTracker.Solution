using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using OrderTracker.Models;

namespace OrderTracker.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreateNewInstanceOfOrder_Order()
    {
      Order newOrder = new Order("The Usual", "Local Coffee's usual order of day old croissant and Marionberry Danishes.", 100, "1/1/2020");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetAll_RetriveStaticListOfAllOrderInstances_List()
    {
        Order newOrder = new Order("The Usual", "Local Coffee's usual order of day old croissant and Marionberry Danishes.", 100, "1/1/2020");
        Assert.AreEqual(typeof(List<Order>), Order.GetAll());
    }
  }

  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void VendorConstructor_CreateNewInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Local Coffee", "Serves local coffee");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
  }
}
