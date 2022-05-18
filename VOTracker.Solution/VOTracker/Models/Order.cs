using System;
using System.Collections.Generic;
using VOTracker.Models;

namespace VOTracker.Models
{
    public class Order
    {
        public string name { get; set; }
        public string description { get; set; }
        public int price { get; set; }
        public int date { get; set; }

        public int Id { get; set; }

        public static List<Order> _instances = new List<Order> {};
        public Order(string OrderName, string OrderDescription, int Price, int Date)
        {
            name = OrderName;
            description = OrderDescription;
            price = Price;
            date = Date;
            _instances.Add(this);
            Id = _instances.Count;
        }
    }
}
