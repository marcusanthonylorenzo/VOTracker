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
        public string Description { get; set; }
        public List<Vendor> vendorList { get; set; }

        public static List<Order> Products = new List<Order>{};

        public Vendor(string VendorName, string VendorDescription)
        {
            Name = VendorName;
            Description = VendorDescription;
            ListTotalVendors.Add(this);
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
        public static void AddProduct(Order orderProduct)
        {
            Products.Add(orderProduct);
        }   
        public static List<Order> GetHeroProducts()
        {
            return Products;
        }

    } 
}
