using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderTracker.Models;
using System.Collections.Generic;

namespace OrderTracker.Tests
{
  [TestClass]
  public class OrderTests 
  {

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("Blue Monday", "I'm definitely not the first one to have made this joke", 0, 0, "7 March 1983");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void OrderConstructor_CorrectlySetsTitleInConstructor_CorrectTitleValue()
    {
      string titl = "New Order";
      string descr = "A New Order";
      int pstryN = 0;
      int breadN = 0;
      string dat = "7 March 1983";

      Order newOrder = new Order(titl, descr, pstryN, breadN, dat);

      Assert.AreEqual( titl, newOrder.Title );
    }

    [TestMethod]
    public void OrderConstructor_CorrectlySetDescriptionInConstructor_CorrectDescriptionValue()
    {
      string titl = "New Order";
      string descr = "A New Order";
      int pstryN = 0;
      int breadN = 0;
      string dat = "7 March 1983";

      Order newOrder = new Order(titl, descr, pstryN, breadN, dat);

      Assert.AreEqual( descr, newOrder.Description );
    }

    [TestMethod]
    public void BreadBaker_CorrectlyReturnsListOfBreads_Breads()
    {
      List<Bread> breadz = Order.BreadBaker(3);
      Bread.BreadDiscounter(breadz);

      Assert.AreEqual(typeof(List<Bread>), breadz.GetType() );
      Assert.AreEqual(3, breadz.Count);
      Assert.AreEqual(5, breadz[0].Price);
      Assert.AreEqual(5, breadz[1].Price);
      Assert.AreEqual(0, breadz[2].Price);
    }

    [TestMethod]
    public void PastryBaker_CorrectlyReturnsListOfPatries_Pastries()
    {
      List<Pastry> pastryz = Order.PastryBaker(3);
      Pastry.PastryDiscounter(pastryz);

      Assert.AreEqual(typeof(List<Pastry>), pastryz.GetType() );
      Assert.AreEqual(3, pastryz.Count);
      Assert.AreEqual(2, pastryz[0].Price);
      Assert.AreEqual(2, pastryz[1].Price);
      Assert.AreEqual(1, pastryz[2].Price);
    }



    [TestMethod]
    public void OrderConstructor_CorrectlySetsPriceInConstructor_CorrectPriceValue()
    {
      string titl = "New Order";
      string descr = "A New Order";
      string dat = "7 March 1983";

      Order newOrder = new Order(titl, descr, 0, 0, dat);
      Order newOrder2 = new Order(titl, descr, 0, 1, dat);
      Order newOrder3 = new Order(titl, descr, 0, 3, dat);
      Order newOrder4 = new Order(titl, descr, 0, 4, dat);
      Order newOrder5 = new Order(titl, descr, 1, 0, dat);
      Order newOrder6 = new Order(titl, descr, 2, 0, dat);
      Order newOrder7 = new Order(titl, descr, 3, 0, dat);
      Order newOrder8 = new Order(titl, descr, 4, 0, dat);
      Order newOrder9 = new Order(titl, descr, 5, 0, dat);
      Order newOrder10 = new Order(titl, descr, 6, 0, dat);
      Order newOrder11 = new Order(titl, descr, 7, 0, dat);
      Order newOrder12 = new Order(titl, descr, 3, 3, dat);
      Order newOrder13 = new Order(titl, descr, 4, 4, dat);
      Order newOrder14 = new Order(titl, descr, 5, 5, dat);
      Order newOrder15 = new Order(titl, descr, 6, 6, dat);

      Assert.AreEqual( 0, newOrder.Price );
      Assert.AreEqual( 5, newOrder2.Price );
      Assert.AreEqual( 10, newOrder3.Price );
      Assert.AreEqual( 15, newOrder4.Price );
      Assert.AreEqual( 2, newOrder5.Price );
      Assert.AreEqual( 4, newOrder6.Price );
      Assert.AreEqual( 5, newOrder7.Price );
      Assert.AreEqual( 7, newOrder8.Price );
      Assert.AreEqual( 9, newOrder9.Price );
      Assert.AreEqual( 10, newOrder10.Price );
      Assert.AreEqual( 12, newOrder11.Price );
      Assert.AreEqual( 15, newOrder12.Price );
      Assert.AreEqual( 22, newOrder13.Price );
      Assert.AreEqual( 29, newOrder14.Price );
      Assert.AreEqual( 30, newOrder15.Price );
    }

    [TestMethod]
    public void OrderConstructor_CorrectlySetsDateInConstructor_CorrectDateValue()
    {
      string titl = "New Order";
      string descr = "A New Order";
      int pstryN = 0;
      int breadN = 0;
      string dat = "7 March 1983";

      Order newOrder = new Order(titl, descr, pstryN, breadN, dat);

      Assert.AreEqual( dat, newOrder.Date );
    }
  }
}