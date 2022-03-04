using System.Collections.Generic;

namespace OrderTracker.Models
{
  public class Order
  {
    public string Title {get; set;}
    public string Description { get; set;}
    public int Price { get; set; }
    public string Date { get; }

    public Order(string title, string descrip, int price, string date)
    {
      Title = title;
      Description = descrip;
      Price = price;
      Date = date;
    }
  }
}