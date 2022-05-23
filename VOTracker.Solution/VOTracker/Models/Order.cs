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
        public string Date { get; set; }

        public int Id { get; set; }

        public int VendorId { get; set; }
        public static List<Order> AllOrders = new List<Order> {};
        public Order(string OrderName, string OrderDescription, int orderPrice, string orderDate, int vendId)
        {
            Name = OrderName;
            Description = OrderDescription;
            Price = orderPrice;
            Date = orderDate;
            VendorId = vendId;
            AllOrders.Add(this);
            Vendor.AddProduct(this);
            Id = AllOrders.Count;
        }
        public static List<Order> GetOrders()
        {
            return AllOrders;
        }

        public static Order SelectOrder(int idOf)
        {
            int IdToIndex = idOf - 1;
            return AllOrders[IdToIndex];
        }
    }
}
