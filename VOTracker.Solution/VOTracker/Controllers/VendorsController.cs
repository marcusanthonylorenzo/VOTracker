using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VOTracker.Models;

namespace VOTracker.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> ListTotalVendors = Vendor.GetAll();
      return View(ListTotalVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors/new")]
    public ActionResult Add(string VendorName, string VendorDescription)
    {
      Vendor newVendor = new Vendor(VendorName, VendorDescription);
      return RedirectToAction("Index");
    }

    // [HttpGet("/vendors/show")]
    // public ActionResult Show()
    // {
    //   //the arguement passed through is used on the Views pages
    //   List<Vendor> ListTotalVendors = Vendor.GetAll();
    //   return View(ListTotalVendors);
    // }
  }
}