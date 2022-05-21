using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VOTracker.Models;

namespace VOTracker.Controllers
{
  public class OrdersController : Controller
  {
    // Vendor currentVendor = new Vendor();

    [HttpGet("/orders")]
    public ActionResult Index()
    {
      List<Order> ListOfOrders = Order.GetOrders();
      return View(ListOfOrders);
    }

    [HttpGet("/orders/new")]
    public ActionResult New()
    {
      return View("New");
    }

    [HttpPost("/orders/new")]
    public ActionResult Show(string orderName, string orderDescription, int price, int date)
    {
      Order myOrder = new Order(orderName, orderDescription, price, date);
      return RedirectToAction("Index");
    }
  }
}