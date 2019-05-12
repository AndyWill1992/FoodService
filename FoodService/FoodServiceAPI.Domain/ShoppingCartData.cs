using System;
using System.Collections.Generic;
using System.Text;

namespace FoodServiceAPI.Domain
{
    public class ShoppingCartData
    {
        public int TempOrderID { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
