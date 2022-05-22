using Microsoft.VisualStudio.TestTools.UnitTesting;
using VOTracker.Models;
using System;
using System.Collections.Generic;

namespace VOTracker.Tests
{
  [TestClass]
  public class OrderTests
  {  
    [TestMethod]
    public void Constructor_CreatesAnOrder_Order()
    {
      Order chickenNuggets = new Order("Maki", "nuggets", 15, 051322, 1);
      Assert.AreEqual(chickenNuggets.Price, 15);
    }
    [TestMethod]
    public void GetOrders_FetchesACountOfTwo_Order()
    {
      Order chickenNuggets = new Order("chicken", "nuggets again", 15, 051322, 2);
      Assert.AreEqual(Order.AllOrders.Count, 2);
    }

    [TestMethod]
    public void SelectOrder_PicksOrderById_Order()
    {
      Order selectedOrder = Order.SelectOrder(2);
      Assert.AreEqual(selectedOrder.Name, "chicken");
    }
  }
}