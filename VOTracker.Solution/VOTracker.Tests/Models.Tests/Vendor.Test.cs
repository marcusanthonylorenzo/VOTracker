using Microsoft.VisualStudio.TestTools.UnitTesting;
using VOTracker.Models;
using System;
using System.Collections.Generic;

namespace VOTracker.Tests
{
  [TestClass]
  public class VendorTests
  {  
    [TestMethod]
    public void Constructor_CreateNewVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Maki");
      Assert.AreEqual(newVendor.Name, "Maki");
    }
    [TestMethod]
    public void GetAll_ListHasNoValues_List()
    {
      List<Vendor> listCount = Vendor.GetAll();
      Assert.AreEqual(listCount.Count, 1);
    }
    [TestMethod]
    public void GetAll_ListCountEqualsTwo_List()
    {
      Vendor maki = new Vendor("Maki");
      Vendor naomes = new Vendor("Naomi");
      List<Vendor> newList = new List<Vendor> {maki, naomes};

      List<Vendor> listSummary = Vendor.GetAll();
      //will count test instances above so 1+2;
      Assert.AreEqual(listSummary.Count,3);
    }
  }
}