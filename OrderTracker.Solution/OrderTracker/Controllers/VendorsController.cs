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
  }
}
