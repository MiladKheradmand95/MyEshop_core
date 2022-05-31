using System.ComponentModel.DataAnnotations;

namespace MyEshop.Models
{
    public class RegisterViewModel
    {
        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "{0} نباید خالی باشد")]
        [MaxLength(300)]
        [EmailAddress]
        public string Email { get; set; }


        [Display(Name = "کلمه عبور")]
        [Required(ErrorMessage = "{0} نباید خالی باشد")]
        [MaxLength(50)]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Display(Name = "تکرار کلمه عبور")]
        [Required(ErrorMessage = "{0} نباید خالی باشد")]
        [MaxLength(50)]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage = "کلمه عبور هم خوانی ندارد")]
        public string RePassword { get; set; }
    }

    public class LoginViewModel
    {
        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "{0} نباید خالی باشد")]
        [MaxLength(300)]
        [EmailAddress]
        public string Email { get; set; }


        [Display(Name = "کلمه عبور")]
        [Required(ErrorMessage = "{0} نباید خالی باشد")]
        [MaxLength(50)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "مرا بخاطر بسپار")]
        public bool RememberMe { get; set; }
    }
}
