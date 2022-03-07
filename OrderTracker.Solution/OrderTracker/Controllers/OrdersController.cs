using OrderTracker.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

namespace OrderTracker.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      return View(vendorId);
    }

    // [HttpPost("/orders")]
    // public ActionResult Create()
    // {
    //   return View("index");
    // }

    [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Dictionary<string, int> model = new Dictionary<string, int>(){};
      model.Add("vendorId", vendorId);
      model.Add("orderId", orderId);
      return View(model);
    }
  }
}