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
      Vendor newVendor = new Vendor("Maki", "cups", "cups");
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
      Vendor maki = new Vendor("Maki", "beer", "craft beer");
      Vendor naomes = new Vendor("Naomi", "plants", "");
      List<Vendor> newList = new List<Vendor> {maki, naomes};

      List<Vendor> listSummary = Vendor.GetAll();
      //will count test instances above so 1+2;
      Assert.AreEqual(listSummary.Count,3);
    }

    //     [TestMethod]
    // public void Constructor_CreateNewVendor_Vendor()
    // {
    //   Vendor newVendor = new Vendor("Maki", "cups");
    //   Assert.AreEqual(newVendor.Name, "Maki");
    // }
  }
}