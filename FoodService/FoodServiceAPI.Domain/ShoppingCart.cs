using System;
using System.Collections.Generic;
using System.Text;

namespace FoodServiceAPI.Domain
{
    public class ShoppingCart
    {
        public int ID { get; set; }
        public List<ShoppingCartData> ShoppingCartData { get; set; }
        public double TotalCartPrice { get; set; }
        public double TotalCartPriceAfterDiscounts { get; set; }
    }
}
