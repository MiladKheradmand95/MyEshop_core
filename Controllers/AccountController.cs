using System;
using Microsoft.AspNetCore.Mvc;
using MyEshop.Data.Repositories;
using MyEshop.Models;

namespace MyEshop.Controllers
{
    public class AccountController : Controller
    {
        IUserRepository _userRepository;

        public AccountController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        #region Register

        [HttpGet]
        public IActionResult Register()
        {
            return View("Register");
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel register)
        {
            if (!ModelState.IsValid)
            {
                return View(register);
            }

            if (_userRepository.IsExistUserByEmail(register.Email.ToLower()))
            {
                ModelState.AddModelError("Email", "کاربری قبلا با این ایمیل ثبت نام کرده است.");
                return View("Register", register);
            }

            Users user = new Users()
            {
                Email = register.Email.ToLower(),
                Password = register.Password,
                IsAdmin = false,
                RegisterDate = DateTime.Now
            };
            _userRepository.AddUser(user);
            return View("SuccessRegister", register);
        }

        #endregion

        #region Login
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel login)
        {
            if (!ModelState.IsValid)
            {
                return View(login);
            }
            var user=_userRepository.GetUserForLogin(login.Email.ToLower(),login.Password);
            if (user == null)
            {
                ModelState.AddModelError("Email", "کاربری با این نام کاربری کلمه عبور پیدا نشد");
                return View(login);
            }

            return View();
        }

        public IActionResult LogOut()
        {

            return Redirect("/Account/Login");
        }
        #endregion

    }
}
