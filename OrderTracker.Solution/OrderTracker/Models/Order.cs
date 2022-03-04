using System.Collections.Generic;

namespace OrderTracker.Models
{
  public class Order
  {
    public string Title {get; set;}
    public string Description { get; set;}
    public double Price { get; set; }
    public string Date { get; }

    public Order(string title, string descrip, double price, string date)
    {
      Title = title;
      Description = descrip;
      Price = price;
      Date = date;
    }
  }
}