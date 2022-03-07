using OrderTracker.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

namespace OrderTracker.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName, string vendorDescr)
    {
      Vendor newVendor = new Vendor(vendorName, vendorDescr);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpGet("/vendors/{Id}")]
    public ActionResult Show(int vendorId)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor currVendor = (Vendor.GetAll())[vendorId]; 
      List<Order> vendorsOrders = currVendor.Orders;
      model.Add("vendor", currVendor);
      model.Add("orders", vendorsOrders);
      model.Add("id", vendorId);
      return View(model);
    }

    [HttpPost("vendors/{vendorId}/orders")]
    public ActionResult Create(int vendorId, string orderTitle, string orderDescr, double orderPrice, string orderDate)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor currVendor = (Vendor.GetAll())[vendorId];
      List<Order> vendorsOrders = currVendor.Orders;
      model.Add("vendor", currVendor);
      model.Add("orders", vendorsOrders);
      model.Add("id", vendorId);
      Order newOrder = new Order(orderTitle, orderDescr, orderPrice, orderDate);
      currVendor.Orders.Add(newOrder);
      return View("Show", model);
    }
  }
}
