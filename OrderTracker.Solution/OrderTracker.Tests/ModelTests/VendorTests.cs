using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using OrderTracker.Models;
using System;

namespace OrderTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
    }

    [TestMethod]
    public void VendorConstructor_CreatesVendorInstance_Vendor()
    {
      Vendor newVendor = new Vendor("a name", "a description");

      Assert.AreEqual(typeof(int), newVendor.GetType());
    }
  }
}