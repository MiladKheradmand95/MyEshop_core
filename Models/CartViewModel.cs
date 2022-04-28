using System.Collections.Generic;
using MyEshop.Models;
namespace MyEshop.Models
{
    public class CartViewModel
    {
        public CartViewModel()
        {
            Cartitem=new List<CartItem>();
        }
        public decimal  OrderTotal { get; set; }
        
        
        public List<CartItem> Cartitem { get; set; }
        
        
    }
}