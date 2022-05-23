using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VOTracker.Models;
using System;

namespace VOTracker.Controllers
{
  public class OrdersController : Controller
  {

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
    public ActionResult New(string orderName, string orderDescription, int price, string date, int vendorNum)
    {
      Order myOrder = new Order(orderName, orderDescription, price, date, vendorNum);
      return RedirectToAction("Index");
    }

    [HttpGet("/orders/show/{id}")]
    public ActionResult Show(int id)
    {
      Order getAnOrder = Order.SelectOrder(id);
      return View(getAnOrder);
    }
  }

}