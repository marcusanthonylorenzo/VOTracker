using System;
using System.Collections.Generic;
using VOTracker.Models;

namespace VOTracker.Models
{
    public class Order
    {
        public string orderName { get; set; }
        public string orderDescription { get; set; }
        public int price { get; set; }
        public int date { get; set; }
        private static List<Order> _instances = new List<Order> { };
        public Order(string orderName, string orderDescription, int price, int date)
        {
            this.orderName = orderName;
            this.orderDescription = orderDescription;
            this.price = price;
            this.date = date;
        }
        
        public static List<Order> GetAll()
        {
            return _instances;
        }

    }
}
