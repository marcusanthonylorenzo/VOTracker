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

        public static List<Order> orderList = new List<Order>{};

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
            public static Vendor Find(int searchId)
        {
            return ListTotalVendors[searchId];
        }

        public void AddOrder(Order newOrd)
        {
            orderList.Add(newOrd);
            newOrd.Id = orderList.Count;
        }
        
        public static List<Order> GetOrders()
        {   
            return orderList;
        }

    } 
}
