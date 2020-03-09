using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class EmployeesController : Controller
    {
        private static readonly ModelEmployees __Employees = new ModelEmployees();

        public IActionResult Index() => View(ModelEmployees._employees);

        [HttpGet]
        public IActionResult Details(int Id) => ModelEmployees._employees.TryGetValue(Id, out var employee) ? View(employee) : (IActionResult)NotFound();


        [HttpPost]
        public IActionResult Details(string surName, string firstName, string patronymic, string age, string telephone,
            string birthDay, string id)
        {
            if (surName is null && firstName is null && patronymic is null && age is null && telephone is null &&
                birthDay is null && id != null && int.TryParse(id, out var _Id))
            {
                ModelEmployees._employees.Remove(_Id);
                return View("Index", ModelEmployees._employees);
            }

            if (int.TryParse(id, out var Id))
            {
                if (ModelEmployees._employees.TryGetValue(Id, out var employee))
                {
                    if (int.TryParse(age, out var age_cheaked))
                        employee.Age = age_cheaked;
                    employee.SurName = surName;
                    employee.FirstName = firstName;
                    employee.Patronymic = patronymic;
                    employee.BirthDay = birthDay;
                    employee.Telephone = telephone;
                }

                return ModelEmployees._employees.TryGetValue(Id, out var employee_)
                    ? View("Index", ModelEmployees._employees)
                    : (IActionResult) NotFound();
            }
            else
                return (IActionResult) NotFound();
        }
    }
}