using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Models
{
    public class Emploee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string Patronymic { get; set; }
        public int Age { get; set; }

        public string Telephone { get; set; }
        public string BirthDay { get; set; }

        public Emploee(int id, string firstName, string surName, string patronymic, int age, string telephone, string birthDay)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.SurName = surName;
            this.Patronymic = patronymic;
            this.Age = age;
            this.Telephone = telephone;
            this.BirthDay = birthDay;
        }
    }
}
