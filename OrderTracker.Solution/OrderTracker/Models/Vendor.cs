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
      _vendors.Add(this);
      Orders = new List<Order>{};
    }

    public static void ClearAll()
    {
      _vendors.Clear();
    }

    public static List<Vendor> GetAll()
    {
      return _vendors;
    }
  }
}