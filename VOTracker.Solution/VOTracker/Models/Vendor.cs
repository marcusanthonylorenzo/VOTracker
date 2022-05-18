using System;
using System.Collections.Generic;

namespace VOTracker.Models
{
    public class Vendor
    {
        //psuedo-database
        private static List<Vendor> ListTotalVendors = new List<Vendor> {};
        public string Name { get; set; }
        public int Id { get; }
        public List<Vendor> vendorList { get; set; }

        public List<Order> orderList { get; set; }

        public Vendor(string VendorName)
        {
            Name = VendorName;
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
    } 
}
