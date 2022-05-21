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
      Order chickenNuggets = new Order("chicken", "nuggets", 15, 051322, 1);
      Assert.AreEqual(chickenNuggets.Price, 15);
    }
    // [TestMethod]
    // public void Constructor_CreatesAnOrder_Order()
    // {
    //   Order chickenNuggets = new Order("chicken", "nuggets", 15, 051322);
    //   Assert.AreEqual(chickenNuggets.price, 15);
    // }
  }
}