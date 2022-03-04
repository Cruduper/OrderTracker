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

      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void VendorConstructor_SetsNamePropertyCorrectly_CorrectNameText()
    {
      string nam = "a name";
      string descr = "a description";

      Vendor newVendor = new Vendor(nam, descr);

      Assert.AreEqual(nam, newVendor.Name);
    }

        [TestMethod]
    public void VendorConstructor_SetsDescriptionPropertyCorrectly_CorrectDescriptionText()
    {
      string nam = "a name";
      string descr = "a description";

      Vendor newVendor = new Vendor(nam, descr);

      Assert.AreEqual("descr", newVendor.Description);
    }
  }
}