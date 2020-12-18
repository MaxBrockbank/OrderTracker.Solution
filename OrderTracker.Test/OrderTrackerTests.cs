using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using OrderTracker.Models;

namespace OrderTracker.Tests
{
  // [TestClass]
  // public class OrderTests
  // {
  //   [TestMethod]

  // }

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
