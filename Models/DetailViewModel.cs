using System.Collections.Generic;

namespace MyEshop.Models
{
    public class DetailViewModel
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }
    }
}
