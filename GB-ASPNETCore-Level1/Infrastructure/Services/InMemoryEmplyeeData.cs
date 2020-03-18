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
        //класс-репозиторий напрямую обращается к контексту базы данных
        private readonly AppDbContext context;
        public InMemoryEmplyeeData(AppDbContext context)
        {
            this.context = context;
        }
        public IEnumerable<Employee> GetAll() => context.Employees;

        public Employee GetById(int id) => context.Employees.FirstOrDefault(x => x.Id == id);

        public void Add(Employee employee)
        {
            if (employee is null)
                throw new ArgumentException(nameof(Employee));
            if (context.Employees.Contains(employee)) return;
            employee.Id = context.Employees.Count() == 0 ? 1 : context.Employees.Max(e => e.Id) + 1;
            context.Employees.Add(employee);
        }

        public void Edit(int id, Employee employee)
        {
            if(employee is null)
                throw new ArgumentException(nameof(Employee));

            if (context.Employees.Contains(employee)) return;

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

            context.Employees.Remove(db_employee);
            return true;
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
