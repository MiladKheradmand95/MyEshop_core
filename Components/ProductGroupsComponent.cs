using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyEshop.Data;
using MyEshop.Models;

namespace MyEshop.Components
{
    public class ProductGroupsComponent:ViewComponent
    {
        private MyEshopContext _context;
        public ProductGroupsComponent(MyEshopContext context)
        {
            this._context=context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categories = _context.Categories
                .Select(c => new ShowGroupViewModel()
                {
                    GroupId = c.Id,
                    GroupName = c.Name,
                    ProductCount = _context.CategoryToProduct.Count(g => g.CategoryId == c.Id)
                }).ToList();
            return View("/Views/Components/ProductGroupsComponents.cshtml", categories);
        }
    }
}
