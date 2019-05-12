using System;

namespace FoodServiceAPI.Domain
{
    public class Product
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public string QuantityInPackage { get; set; }
        public Category Category { get; set; }
        public double Price { get; set; }
        public int QuantityAvailable { get; set; }

    }
}
