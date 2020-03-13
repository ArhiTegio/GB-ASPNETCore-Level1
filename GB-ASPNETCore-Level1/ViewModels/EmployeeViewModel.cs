using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebStore.ViewModels
{
    public class EmployeeViewModel
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [Display(Name = "Имя")]
        [Required(ErrorMessage = "Имя является обязательным")]
        [MinLength(3, ErrorMessage = "Должно быть более 3 символов")]
        public string Name { get; set; }

        [Display(Name = "Фамилия")]
        [Required(ErrorMessage = "Фамилия является обязательным")]
        public string SecondName { get; set; }

        [Display(Name = "Отчество")]
        public string Patronymic { get; set; }

        [Display(Name = "Возрост")]
        public int Age { get; set; }

        [Display(Name = "Телефон")]
        [Required(ErrorMessage = "Телефон обязателено заполнить")]
        [MinLength(11, ErrorMessage = "Цифор должно быть не менее 11")]
        public string Telephone { get; set; }

        [Display(Name = "День рождения")]
        [Required(ErrorMessage = "День рождение является обязательным")]
        public string BirthDay { get; set; }
    }
}
