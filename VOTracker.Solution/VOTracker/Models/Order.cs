using System;
using System.Collections.Generic;
using VOTracker.Models;

namespace VOTracker.Models
{
    public class Order
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Date { get; set; }

        public int Id { get; set; }

        public static List<Order> _instances = new List<Order> {};
        public Order(string OrderName, string OrderDescription, int orderPrice, int orderDate)
        {
            Name = OrderName;
            Description = OrderDescription;
            Price = orderPrice;
            Date = orderDate;
            _instances.Add(this);
            Id = _instances.Count;
        }

        public static List<Order> GetOrders()
        {
            return _instances;
        }
    }
}
