using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodServiceAPI.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FoodServiceAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class FoodServiceController : ControllerBase
    {
        private List<Product> _Products
        {
            get
            {
                var products = new List<Product>();
                products.Add(new Product() { ID= 1, ProductName = "Chicken Fillets", QuantityInPackage = "6 x 100g" ,Category = Category.MeatAndPoultry, Price = 4.50, QuantityAvailable = 12});
                products.Add(new Product() { ID = 2, ProductName = "Sirloin Steaks", QuantityInPackage = "4 x 6-8oz",Category = Category.MeatAndPoultry, Price = 45.70, QuantityAvailable = 6 });
                products.Add(new Product() { ID = 3, ProductName = "Whole Free-Range Turkey", QuantityInPackage = "1 x 16-18lbs",Category = Category.MeatAndPoultry, Price = 43.20, QuantityAvailable = 8 });
                products.Add(new Product() { ID = 4, ProductName = "Granny Smith Apples", QuantityInPackage = "4 x 16 each",Category = Category.FruitAndVegetables, Price = 3.75, QuantityAvailable = 0 });
                products.Add(new Product() { ID = 5, ProductName = "Loose Carrots", QuantityInPackage = "4 x 20 each",Category = Category.FruitAndVegetables, Price = 2.67, QuantityAvailable = 2 });
                products.Add(new Product() { ID = 6, ProductName = "Mandarin Oranges", QuantityInPackage = "6 x 10 x 12",Category = Category.FruitAndVegetables, Price = 12.23, QuantityAvailable = 8});
                products.Add(new Product() { ID = 7, ProductName = "Cauliflower Florets", QuantityInPackage = "10 x 500g",Category = Category.FruitAndVegetables, Price = 5.00, QuantityAvailable = 5 });
                products.Add(new Product() { ID = 8, ProductName = "Coca-Cola", QuantityInPackage = "6 x 2L",Category = Category.Drinks, Price = 8.30, QuantityAvailable = 6 });
                products.Add(new Product() { ID = 9, ProductName = "Still Mineral Water", QuantityInPackage = "6 x 24 x 500ml",Category = Category.Drinks, Price = 21.75, QuantityAvailable = 9 });
                products.Add(new Product() { ID = 10, ProductName = "Sparkling Mineral Water", QuantityInPackage = "6 x 24 x 500ml",Category = Category.Drinks, Price = 25.83, QuantityAvailable = 16 });
                products.Add(new Product() { ID = 11, ProductName = "Mars Bar", QuantityInPackage = "6 x 24 x 50g",Category = Category.ConfectionaryAndDesserts, Price = 42.82, QuantityAvailable = 4 });
                products.Add(new Product() { ID = 12, ProductName = "Peppermint Chewing Gum",  QuantityInPackage = "6 x 50 x 30g",Category = Category.ConfectionaryAndDesserts, Price = 35.70, QuantityAvailable = 6 });
                products.Add(new Product() { ID = 13, ProductName = "Strawberry Cheesecake", QuantityInPackage = "4 x 12 portions",Category = Category.ConfectionaryAndDesserts, Price = 8.52, QuantityAvailable = 0 });
                products.Add(new Product() { ID = 14, ProductName = "Vanilla Ice Cream", QuantityInPackage = "6 x 4L", Category = Category.ConfectionaryAndDesserts, Price = 3.80, QuantityAvailable = 2 });
                products.Add(new Product() { ID = 15, ProductName = "Plain Flower", QuantityInPackage = "10 x 1kg", Category = Category.BakingOrCookingIngredients, Price = 6.21, QuantityAvailable = 4 });
                products.Add(new Product() { ID = 16, ProductName = "Icing Sugar", QuantityInPackage = "12 x 500g", Category = Category.BakingOrCookingIngredients, Price = 9.38, QuantityAvailable = 6 });
                products.Add(new Product() { ID = 17, ProductName = "Free-Range Eggs", QuantityInPackage = "10 x 12 each", Category = Category.BakingOrCookingIngredients, Price = 9.52, QuantityAvailable = 9 });
                products.Add(new Product() { ID = 18, ProductName = "Caster Sugar", QuantityInPackage = "16 x 750g", Category = Category.BakingOrCookingIngredients, Price = 12.76, QuantityAvailable = 13 });
                products.Add(new Product() { ID = 19, ProductName = "Kitchen Roll", QuantityInPackage = "100 x 300 sheets", Category = Category.MiscellaneousItems, Price = 43.92, QuantityAvailable = 19});
                products.Add(new Product() { ID = 20, ProductName = "Paper Plates", QuantityInPackage = "10 x 200 each", Category = Category.MiscellaneousItems, Price = 16.19, QuantityAvailable = 7 });
                return products;
            }
        }


        private ShoppingCart _ShoppingCart
        {
            get
            {
                var shoppingCart = new ShoppingCart() {
                    ID = 1, ShoppingCartData = new List<ShoppingCartData>()
            };
                return shoppingCart;
            }
        }



        // GET: api/Product
        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            return _Products;
        }

        [HttpGet]
        public ShoppingCart GetShoppingCart()
        {
            return _ShoppingCart;
        }

        // GET: api/Product/5
        [HttpGet("{id}", Name = "Get")]
        public Product Get(int id)
        {
            var product = _Products.FirstOrDefault(p => p.ID == id);

            return product != null ? product : new Product();
        }

        // POST: api/Product
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Product/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
