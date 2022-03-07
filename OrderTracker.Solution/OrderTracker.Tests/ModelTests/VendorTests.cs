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
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesVendorInstance_Vendor()
    {
      Vendor newVendor = new Vendor("a name0", "a description0");

      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void VendorConstructor_SetsNamePropertyCorrectly_CorrectNameText()
    {
      string nam = "a name1";
      string descr = "a description1";

      Vendor newVendor = new Vendor(nam, descr);

      Assert.AreEqual(nam, newVendor.Name);
    }

    [TestMethod]
    public void VendorConstructor_SetsDescriptionPropertyCorrectly_CorrectDescriptionText()
    {
      string nam = "a name2";
      string descr = "a description2";

      Vendor newVendor = new Vendor(nam, descr);

      Assert.AreEqual(descr, newVendor.Description);
    }

    // ClearAll() and GetAll() as outlined in the weekly lessons have a circular
    // dependency. You cannot test one without the other, because we do not have public
    // access to the private field named "_vendors" (I renamed this, it was
    // "_instances" in the lesson).
    // For this test I enabled Dispose (which uses ClearAll), without having first tested ClearAll, as per the lesson.
    // This dependency could be broken by having testing variables scoped outside
    // of specific tests, so they could be reused, or by making _vendors public
    // which is probably a bad idea.
    [TestMethod]
    public void GetAll_ReturnsVendorsField_Vendors()
    {
      Vendor newVendor0 = new Vendor("a name0", "a description0");
      Vendor newVendor1 = new Vendor("a name1", "a description1");

      List<Vendor> vendList = new List<Vendor>{newVendor0, newVendor1};

      CollectionAssert.AreEqual(vendList, Vendor.GetAll());
    }

    [TestMethod]
    public void ClearAll_ClearsAllVendorInstancesInVendorsField_0()
    {
      Vendor newVendor0 = new Vendor("a name0", "a description0");
      Vendor newVendor1 = new Vendor("a name1", "a description1");

      List<Vendor> emptyList = new List<Vendor>{};
      Vendor.ClearAll();

      CollectionAssert.AreEqual(emptyList, Vendor.GetAll());
    }
  }
}