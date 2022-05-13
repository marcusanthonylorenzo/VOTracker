using System;
using System.Collections.Generic;

namespace VOTracker.Models
{
    public class Vendor
    {
        public static List<Vendor> _instances = new List<Vendor> {};
        public string Name { get; set; }
        public int Id { get; }
        public List<Order> Orders { get; set; }

        public Vendor(string VendorName)
        {
            Name = VendorName;
            _instances.Add(this);
            Orders = new List<Order>{};
        }

            public static void ClearAll()
        {
            _instances.Clear();
        }

            public static List<Vendor> GetAll()
        {
            return _instances;
        }

            public static Vendor Find(int searchId)
        {
            return _instances[searchId-1];
        }

            public void AddItem(Order item)
        {
            Orders.Add(item);
        }
    } 
}