using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class EmployeesController : Controller
    {
        private static readonly ModelEmployees __Employees = new ModelEmployees();

        public IActionResult Index() => View(ModelEmployees._employees);

        public IActionResult Details(int Id) => ModelEmployees._employees.TryGetValue(Id, out var employee) ? View(employee) : (IActionResult)NotFound();
    }
}