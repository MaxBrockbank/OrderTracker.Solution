using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using OrderTracker.Models;

namespace OrderTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreateNewInstanceOfOrder_Order()
    {
      Order newOrder = new Order("The Usual", "Local Coffee's usual order of day old croissant and Marionberry Danishes.", 100, "1/1/2020");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetAll_RetriveStaticListOfAllOrderInstances_OrderList()
    {
      Order newOrder = new Order("The Usual", "Local Coffee's usual order of day old croissant and Marionberry Danishes.", 100, "1/1/2020");
      List<Order> newList = new List<Order> {newOrder};
      List<Order> result = Order.GetAll();
      List<string> stringresult = new List<string>{};
      CollectionAssert.AreEqual(newList, result);
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
