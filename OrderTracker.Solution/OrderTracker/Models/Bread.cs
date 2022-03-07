using System;
using System.Collections.Generic;


namespace OrderTracker.Models
{
  public class Bread
  {
    public int Price{ get; set; }

    public Bread (){ } //overloaded Bread constructor
    public Bread (int price)
    {
      Price = price;
    }

    public static int BreadDiscounter( List<Bread> loafMountain)
    {
      int breadInstance = 1;
      int totalPrice = 0;
      foreach (Bread loaf in loafMountain)
      {
        if( breadInstance % 3 == 0 )
          loaf.Price = 0;

        totalPrice += loaf.Price;
        breadInstance++;
      }
      return totalPrice;
    }
  }
}