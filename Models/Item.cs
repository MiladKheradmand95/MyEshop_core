using MyEshop.Models;

namespace MyEshop.Models
{
    public class Item
    {
        public int Id   { get; set; } 
        public Product product  { get; set; }
        public decimal Price { get; set; }
        
        public int QuantityInStock { get; set; }
        
        
    }
}