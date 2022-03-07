using System.Collections.Generic;

namespace OrderTracker.Models
{
  public class Order
  {
    public string Title {get; set;}
    public string Description { get; set;}

    public List<Pastry> Pastries = new List<Pastry>{};

    public List<Bread> Breads = new List<Bread>{};
    public double Price { get; }
    public string Date { get; }

    public Order(string title, string descrip, int pastryNum, int breadNum, string date)
    {
      Title = title;
      Description = descrip;
      Pastries = PastryBaker(pastryNum);
      Breads = BreadBaker(breadNum);
      Price = Bread.BreadDiscounter( Breads ) + Pastry.PastryDiscounter( Pastries );
      Date = date;
    }

    public static List<Bread> BreadBaker( int nBreads)
    {
      List<Bread> breadList = new List<Bread>();

      for( int i = 0; i < nBreads; i++)
      {
        breadList.Add(new Bread(5));
      }

      return breadList;
    }

    public static List<Pastry> PastryBaker( int nPastries)
    {
      List<Pastry> PastryList = new List<Pastry>();

      for( int i = 0; i < nPastries; i++)
      {
        PastryList.Add(new Pastry(2));
      }

      return PastryList;
    }
  }
}