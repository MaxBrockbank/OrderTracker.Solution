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
    public void GetAll_RetreiveStaticListOfAllOrderInstances_OrderList()
    {
      Order newOrder = new Order("The Usual", "Local Coffee's usual order of day old croissant and Marionberry Danishes.", 100, "1/1/2020");
      List<Order> newList = new List<Order> {newOrder};
      List<Order> result = Order.GetAll();
      List<string> stringresult = new List<string>{};
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void Find_RetrieveOrderFromListById_Order()
    {
      Order newOrder = new Order("The Usual", "Local Coffee's usual order of day old croissant and Marionberry Danishes.", 100, "1/1/2020");
      Order newOrder2 = new Order("The Unusual", "Something different", 101, "1/2/2020");
      Order newOrder3 = new Order("The Usual", "Something else different", 102, "1/3/2020");
      Order result = Order.Find(2);
      Assert.AreEqual(newOrder2, result);
    }
  }

  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }
    [TestMethod]
    public void VendorConstructor_CreateNewInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Local Coffee", "Serves local coffee");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetAll_RetreiveStaticListOfAllVendors_VendorList()
    {
      Vendor newVendor = new Vendor("Local Coffee", "Serves local coffee");
      List<Vendor> result = Vendor.GetAll();
      List<Vendor> newList = new List<Vendor> {newVendor};
      List<string> testList = new List<string>{};
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_RetriveVendorFromListById_Vendor()
    {
      Vendor newVendor = new Vendor("Local Coffee", "Serves local coffee");
      Vendor newVendor2 = new Vendor("Localized Coffee", "Serves localized coffee");
      Vendor newVendor3 = new Vendor("Localish Coffee", "Serves localish coffee");
      Vendor result = Vendor.Find(1);
      Assert.AreEqual(newVendor, result);
    }

    [TestMethod]
    public void AddOrder_AddAnOrderObjectToVendorOrderList_OrderList()
    {
      Order newOrder = new Order("The Usual", "Local Coffee's usual order of day old croissant and Marionberry Danishes.", 100, "1/1/2020");
      List<Order> newList = new List<Order>{newOrder};
      Vendor newVendor = new Vendor("Local Coffee", "Serves local coffee");
      newVendor.AddOrder(newOrder);
      List<Order> result = newVendor.Orders;
      CollectionAssert.AreEqual(newList, result);
    }
  }
}
