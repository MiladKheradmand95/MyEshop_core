using System.Linq;
using Microsoft.EntityFrameworkCore.Internal;
using MyEshop.Models;

namespace MyEshop.Data.Repositories
{
    public interface IUserRepository
    {
        bool IsExistUserByEmail(string email);
        void AddUser(Users users);
        Users GetUserForLogin(string email,string password);
    }

    public class UserRepository : IUserRepository
    {
       private MyEshopContext _context;

        public UserRepository(MyEshopContext context)
        {
            _context = context;
        }
        public bool IsExistUserByEmail(string email)
        {
          return  _context.Users.Any(u => u.Email == email);
        }

        public void AddUser(Users users)
        {
            _context.Users.Add(users);
            _context.SaveChanges();
        }

        public Users GetUserForLogin(string email, string password)
        {
           return _context.Users
                .SingleOrDefault(u => u.Email == email && u.Password == password);
        }
    }
}
