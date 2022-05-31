using System.Collections.Generic;
using System.Linq;
using MyEshop.Models;

namespace MyEshop.Data.Repositories
{

    //Interface
    public interface IGroupRepository
    {
        IEnumerable<Category> GetAllCategories();
        IEnumerable<ShowGroupViewModel> GetGroupForShow();
    }

    //Service
    public class GroupRepository : IGroupRepository
    {
        MyEshopContext _context;

        public GroupRepository(MyEshopContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> GetAllCategories()
        {
           return _context.Categories;
        }

        public IEnumerable<ShowGroupViewModel> GetGroupForShow()
        {
            return _context.Categories
                .Select(c => new ShowGroupViewModel()
                {
                    GroupId = c.Id,
                    GroupName = c.Name,
                    ProductCount = _context.CategoryToProduct.Count(g => g.CategoryId == c.Id)
                }).ToList();
        }
    }
}
