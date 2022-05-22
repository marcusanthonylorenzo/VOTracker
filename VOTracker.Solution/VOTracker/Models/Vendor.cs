using System;
using System.Collections.Generic;

namespace VOTracker.Models
{
    public class Vendor
    {
        //psuedo-database
        public static List<Vendor> ListTotalVendors = new List<Vendor> {};
        public string Name { get; set; }
        public int Id { get; }

        public string HeroProduct { get; set; }
        public string Description { get; set; }
        public List<Vendor> vendorList { get; set; }

        public static List<string> HeroProducts = new List<string>{};

        public Vendor(string VendorName, string VendorDescription, string HeroProductName)
        {
            Name = VendorName;
            Description = VendorDescription;
            HeroProduct = HeroProductName;
            ListTotalVendors.Add(this);
            HeroProducts.Add(HeroProductName);
            Id = ListTotalVendors.Count;
        }
        public static void ClearAll()
        {
            ListTotalVendors.Clear();
        }

        public static List<Vendor> GetAll()
        {   
            return ListTotalVendors;
        }

            public void Add(Vendor business)
        {
            ListTotalVendors.Add(business);
        }
        public static Vendor SelectVendor(int idOfVend)
        {
            int IdToIndexVendor= idOfVend - 1;
            return ListTotalVendors[IdToIndexVendor];
        }


        //Get list of string name products, match with Order.Name, if match, print option values in Orders/New
        public static List<string> GetHeroProducts()
        {
            return HeroProducts;
        }

        // public static string CheckNames(Order passedOrder)
        // {
        //     if (passedOrder.Name == .Name)
        // }

    } 
}
