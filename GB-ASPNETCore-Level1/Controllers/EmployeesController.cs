using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using WebStore.Data;
using WebStore.Infrastructure.Interfaces;
using WebStore.Models;
using WebStore.ViewModels;

namespace WebStore.Controllers
{
    //[Route("users")]
    public class EmployeesController : Controller
    {
        private readonly IEmployeesData _EmployeesData;
        public EmployeesController(IEmployeesData employeesData) => _EmployeesData = employeesData;

        private static readonly ModelEmployees __Employees = new ModelEmployees();

        //[Routing("employees")]
        public IActionResult Index() => View(_EmployeesData.GetAll().Select(x => new EmployeeViewModel()
        {
            Id = x.Id,
            Age = x.Age,
            Telephone = x.Telephone,
            SecondName = x.SurName,
            Name = x.FirstName,
            BirthDay = x.BirthDay, 
            Patronymic = x.Patronymic,
        }));

        [HttpGet]
        public IActionResult Details(Employee _employee)
        {

            var employee = _EmployeesData.GetById(_employee.Id);

            if (employee is null)
                return NotFound();
            return View(new EmployeeViewModel()
            {
                Id = employee.Id,
                Age = employee.Age,
                Telephone = employee.Telephone,
                SecondName = employee.SurName,
                Name = employee.FirstName,
                BirthDay = employee.BirthDay,
                Patronymic = employee.Patronymic,
            });
        } 

        //[Route("employees/{Id}")]
        //[HttpPost]
        //public IActionResult Details(Employee employee)
        //{
        //    if (surName is null && firstName is null && patronymic is null && age is null && telephone is null &&
        //        birthDay is null && id != null && int.TryParse(id, out var _Id))
        //    {
        //        TestData.Employees.Remove(_Id);
        //        return View("Index", TestData.Employees);
        //    }

        //    if (int.TryParse(id, out var Id))
        //    {
        //        if (TestData.Employees.TryGetValue(Id, out var employee))
        //        {
        //            if (int.TryParse(age, out var age_cheaked))
        //                employee.Age = age_cheaked;
        //            employee.SurName = surName;
        //            employee.FirstName = firstName;
        //            employee.Patronymic = patronymic;
        //            employee.BirthDay = birthDay;
        //            employee.Telephone = telephone;
        //        }

        //        return TestData.Employees.TryGetValue(Id, out var employee_)
        //            ? View("Index", TestData.Employees)
        //            : (IActionResult)NotFound();
        //    }
        //    else
        //        return (IActionResult)NotFound();
        //}

        public IActionResult Create()
        {
            return View(new EmployeeViewModel());
        }

        [HttpPost]
        public IActionResult Create(EmployeeViewModel employee)
        {
            if (employee is null)
                throw new ArgumentNullException(nameof(EmployeeViewModel));

            if (!ModelState.IsValid)
                return View(employee);
            _EmployeesData.Add(new Employee()
            {
                Age = employee.Age,
                Telephone = employee.Telephone,
                SurName = employee.SecondName,
                FirstName = employee.Name,
                BirthDay = employee.BirthDay,
                Patronymic = employee.Patronymic,
            });
            _EmployeesData.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            if (id is null) return View(new EmployeeViewModel());

            if (id == 0) return BadRequest();

            var employee = _EmployeesData.GetById(id.Value);

            if (employee is null)
                return NotFound();

            return View(new EmployeeViewModel()
            {
                Id = employee.Id,
                Age = employee.Age,
                Telephone = employee.Telephone,
                SecondName = employee.SurName,
                Name = employee.FirstName,
                BirthDay = employee.BirthDay,
                Patronymic = employee.Patronymic,
            });
        }

        [HttpPost]
        public IActionResult Edit(EmployeeViewModel employee)
        {
            if (employee is null)
                throw new ArgumentNullException(nameof(EmployeeViewModel));

            if(int.TryParse(employee.Name, out var name) || int.TryParse(employee.SecondName, out name) || int.TryParse(employee.Patronymic, out name))
                ModelState.AddModelError(string.Empty, "Число не может быть фамилией, именем или отчеством!");

            if (!ModelState.IsValid)
                return View(employee);

            var id = employee.Id;
            if(id > 0)
                _EmployeesData.Add(new Employee()
                {
                    Age = employee.Age,
                    Telephone = employee.Telephone,
                    SurName = employee.SecondName,
                    FirstName = employee.Name,
                    BirthDay = employee.BirthDay,
                    Patronymic = employee.Patronymic,
                });
            else
                _EmployeesData.Edit(id, new Employee()
                {
                    Age = employee.Age,
                    Telephone = employee.Telephone,
                    SurName = employee.SecondName,
                    FirstName = employee.Name,
                    BirthDay = employee.BirthDay,
                    Patronymic = employee.Patronymic,
                });

            _EmployeesData.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            if (id <= 0)
                return BadRequest();
            var employee = _EmployeesData.GetById(id);
            if (employee is null)
                return NotFound();

            return View(new EmployeeViewModel()
            {
                Id = employee.Id,
                Age = employee.Age,
                Telephone = employee.Telephone,
                SecondName = employee.SurName,
                Name = employee.FirstName,
                BirthDay = employee.BirthDay,
                Patronymic = employee.Patronymic,
            });
        }

        public IActionResult DeteleConfirned(int id)
        {
            _EmployeesData.Delete(id);
            _EmployeesData.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}