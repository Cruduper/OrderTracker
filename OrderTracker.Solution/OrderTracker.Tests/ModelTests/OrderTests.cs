using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using OrderTracker.Models;
using System;

namespace OrderTracker.Tests
{
  [TestClass]
  public class OrderTests 
  {

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("Blue Monday", "I'm definitely not the first one to have made this joke", 3.99, "7 March 1983");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void OrderConstructor_CorrectlySetsTitleInConstructor_CorrectTitleValue()
    {
      string titl = "New Order";
      string descr = "A New Order";
      double prc = 9.99;
      string dat = "7 March 1983";

      Order newOrder = new Order(titl, descr, prc, dat);

      Assert.AreEqual( titl, newOrder.Title );
    }

    [TestMethod]
    public void OrderConstructor_CorrectlySetDescriptionInConstructor_CorrectDescriptionValue()
    {
      string titl = "New Order";
      string descr = "A New Order";
      double prc = 9.99;
      string dat = "7 March 1983";

      Order newOrder = new Order(titl, descr, prc, dat);

      Assert.AreEqual( descr, newOrder.Description );
    }

    [TestMethod]
    public void OrderConstructor_CorrectlySetsPriceInConstructor_CorrectPriceValue()
    {
      string titl = "New Order";
      string descr = "A New Order";
      double prc = 9.99;
      string dat = "7 March 1983";

      Order newOrder = new Order(titl, descr, prc, dat);

      Assert.AreEqual( prc, newOrder.Price );
    }

    [TestMethod]
    public void OrderConstructor_CorrectlySetsDateInConstructor_CorrectDateValue()
    {
      string titl = "New Order";
      string descr = "A New Order";
      double prc = 9.99;
      string dat = "7 March 1983";

      Order newOrder = new Order(titl, descr, prc, dat);

      Assert.AreEqual( dat, newOrder.Date );
    }


  }
}