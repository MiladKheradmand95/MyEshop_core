using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.Extensions.Logging;
using MyEshop.Data;
using MyEshop.Models;

namespace MyEshop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger; 
        private MyEshopContext _context;
        private static Cart _cart = new Cart();
        public HomeController(ILogger<HomeController> logger,MyEshopContext context)
        {
            _logger = logger;
            _context= context;
        }

        public IActionResult Index()
        {
            var product = _context.Products.ToList();
            return View(product);
        }
        [Route("ContactUs")]
        public IActionResult ContactUs()
        {
            return View();
        }

        public IActionResult Detail(int id)
        {
            var product = _context.Products
                .Include(p => p.item)
                .SingleOrDefault(p => p.Id == id);
            if (product==null)
            {
                return NotFound();
            }

            var categories = _context.Products
                .Where(p => p.Id == id)
                .SelectMany(c => c.CategoryToProducts)
                .Select(ca => ca.Category)
                .ToList();
            var vm = new DetailViewModel()
            {
                Product = product,
                Categories = categories
            };
            return View(vm);
        }

        public IActionResult AddToCart(int ItemId)
        {
            var product = _context.Products.Include(p=>p.item).SingleOrDefault(p => p.ItemId == ItemId);
            if (product!=null)
            {
                var cartItem = new CartItem()
                {
                    Item = product.item,
                    Quantity = 1
                };
                _cart.addItem(cartItem);
            }

            return RedirectToAction("ShowCart");
        }

        public IActionResult ShowCart()
        {
            var CartVM = new CartViewModel()
            {
                Cartitem = _cart.CartItem,
                OrderTotal = _cart.CartItem.Sum(c=>c.getTotalPrice())
            };
            return View(CartVM);
        }

        public IActionResult RemoveFromCart(int itemId)
        {
            _cart.removeItem(itemId);
            return RedirectToAction("ShowCart");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
