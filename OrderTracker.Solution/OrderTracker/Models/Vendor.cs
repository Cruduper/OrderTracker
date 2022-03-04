using System.Collections.Generic;

namespace OrderTracker.Models
{
  public class Vendor
  {
    public string Name {set; get;}
    public string Description {set; get;}
    public List<Order> Orders {get; set;}
    private static List<Vendor> _vendors = new List<Vendor> {};

    public Vendor(string name, string descr )
    {
      Name = name;
      Description = descr;
      Orders = new List<Order>{};
    }

    public ClearAll()
    {
      _vendors.Clear();
    }
  }
}