using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            //return Content("Home controllers - action Index");
            return View();
        }

        public IActionResult SomeAction()
        {
            //return Content("Home controllers - action SomeAction");
            return View();
        }

        public IActionResult Emploees()
        {
            return View(ModelEmployees._emploees);
        }

        public IActionResult Employee(int id)
        {
            var employee = ModelEmployees._emploees.FirstOrDefault(e => e.Id == id);
            return employee is null? (IActionResult)NotFound() : View(employee);
        }
    }
}