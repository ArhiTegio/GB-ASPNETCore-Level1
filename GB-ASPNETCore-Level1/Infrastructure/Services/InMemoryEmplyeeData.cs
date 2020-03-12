using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Data;
using WebStore.Infrastructure.Interfaces;
using WebStore.Models;

namespace WebStore.Infrastructure.Services
{
    public class InMemoryEmplyeeData : IEmployeesData
    {
        private readonly List<Employee> _Employees = TestData.LEmployees;
        public IEnumerable<Employee> GetAll() => _Employees;

        public Employee GetById(int id) => _Employees.FirstOrDefault(x => x.Id == id);

        public void Add(Employee employee)
        {
            if (employee is null)
                throw new ArgumentException(nameof(Employee));
            if (_Employees.Contains(employee)) return;
            employee.Id = _Employees.Count == 0 ? 1 : _Employees.Max(e => e.Id) + 1;
            _Employees.Add(employee);
        }

        public void Edit(int id, Employee employee)
        {
            if(employee is null)
                throw new ArgumentException(nameof(Employee));

            if (_Employees.Contains(employee)) return;

            var db_employee = GetById(id);
            if (db_employee is null)
                return;

            db_employee.SurName = employee.SurName;
            db_employee.FirstName = employee.FirstName;
            db_employee.Patronymic = employee.Patronymic;
            db_employee.Age = employee.Age;
            db_employee.BirthDay = employee.BirthDay;
            db_employee.Telephone = employee.Telephone;
        }

        public bool Delete(int id)
        {

            var db_employee = GetById(id);
            if (db_employee is null)
                return false;

            return _Employees.Remove(db_employee);


        }

        public void SaveChanges()
        {
        }
    }
}
