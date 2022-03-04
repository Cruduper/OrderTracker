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
      Assert.AreEqual(typeof(int), newOrder.GetType());
    }


  }
}