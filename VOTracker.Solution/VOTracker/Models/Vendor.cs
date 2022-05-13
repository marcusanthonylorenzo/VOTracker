using System;
using System.Collections.Generic;

namespace VOTracker.Models
{
    public class Vendor
    {
        public static List<Vendor> _instances = new List<Vendor> {};
        public string Name { get; set; }
        public int Id { get; }
        public List<Vendor> vendorList { get; set; }

        public Vendor(string VendorName)
        {
            Name = VendorName;
            _instances.Add(this);
            Id = _instances.Count;
            List<Vendor> vendorList = new List<Vendor>{};
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
            return _instances[searchId];
        }

            public void AddItem(Vendor business)
        {
            vendorList.Add(business);
        }
    } 
}
