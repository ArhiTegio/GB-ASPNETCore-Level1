using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebStore.ViewModels
{
    public class LoginViewModel
    {

        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [Display(Name = "Логин")]
        public string UserName { get; set; }

        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [Display(Name = "Запомнить меня")]
        public bool RememberMe { get; set; }
        public string ReturnUrl { get; internal set; }
    }
}
