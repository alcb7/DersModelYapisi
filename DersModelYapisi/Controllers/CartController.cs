using DersModelYapisi.Models;
using Microsoft.AspNetCore.Mvc;

namespace DersModelYapisi.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {


            var product1 = new Product { Id = 1, Name = "Laptop", Price = 5000 };
            var product2 = new Product { Id = 2, Name = "Mouse", Price = 50 };
            var product3 = new Product { Id = 3, Name = "Keyboard", Price = 100 };

            var cartProduct1 = new CartProduct { Id = 1, Product = product1, Quantity = 2, Price = 10000 };
            var cartProduct2 = new CartProduct { Id = 2, Product = product2, Quantity = 3, Price = 150 };
            var cartProduct3 = new CartProduct { Id = 3, Product = product3, Quantity = 1, Price = 100 };

            var cartProducts = new List<CartProduct> { cartProduct1, cartProduct2, cartProduct3 };

            return View(cartProducts);




        }
    }
}
