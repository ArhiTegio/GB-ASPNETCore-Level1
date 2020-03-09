using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static AllRussianName.Russian;

namespace WebStore.Models
{
    public class ModelEmployees
    {
        private static Random random = new Random();
        private static string[] allName = GetManNames();
        private static string[] allSurname = GetManSurname();

        public static readonly Dictionary<int, Employee> _employees = new Dictionary<int, Employee>();

        static ModelEmployees()
        {
            _employees.Clear();
            var year = DateTime.Now.Year;
            var coutEmploee = random.Next(30, 100);
            for (int i = 0; i < coutEmploee; i++)
                _employees.Add(i, new Employee(i, allName[random.Next(0, allName.Length - 1)],
                    allSurname[random.Next(0, allSurname.Length - 1)],
                    $"{allName[random.Next(0, allName.Length - 1)]}ович", 
                    random.Next(18, 65), 
                    $"+79{String.Format("{0:D2}", random.Next(80, 100))}-{String.Format("{0:D3}", random.Next(0, 1000))}-{String.Format("{0:D4}", random.Next(0, 10000))}",
                    $"{random.Next(year - 65, year)}-{String.Format("{0:D2}", random.Next(1, 13))}-{String.Format("{0:D2}", random.Next(1, 32))}"));
        }
    }
}
