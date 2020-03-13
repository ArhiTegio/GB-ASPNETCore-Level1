using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Models;
using static AllRussianName.Russian;

namespace WebStore.Data
{
    public class TestData
    {
        private static Dictionary<int, Employee> _employees = new Dictionary<int, Employee>();
        private static HashSet<Employee> _hashSetEmployees = new HashSet<Employee>();
        public static Random FactoryRandom { get; } = new Random();
        public static string[] AllName { get; } = GetManNames();
        public static string[] AllSurname { get; } = GetManSurname();

        public static Dictionary<int, Employee> Employees
        {
            get => _employees;
            set => _employees = value;
        }

        public static HashSet<Employee> HashSetEmployees

        {
            get => _hashSetEmployees;
            set => _hashSetEmployees = value;
        }

        private static List<Employee> lEmployees = new List<Employee>();
        public static List<Employee> LEmployees
        {
            get
            {
                if (lEmployees.Count == 0)
                {
                    var year = DateTime.Now.Year;
                    var coutEmploee = FactoryRandom.Next(30, 100);
                    for (int i = 1; i < coutEmploee; i++)
                        lEmployees.Add(new Employee(i, AllName[FactoryRandom.Next(0, AllName.Length - 1)],
                            AllSurname[FactoryRandom.Next(0, AllSurname.Length - 1)],
                            $"{AllName[FactoryRandom.Next(0, AllName.Length - 1)]}ович",
                            FactoryRandom.Next(18, 65),
                            $"+79{String.Format("{0:D2}", FactoryRandom.Next(80, 100))}-{String.Format("{0:D3}", FactoryRandom.Next(0, 1000))}-{String.Format("{0:D4}", FactoryRandom.Next(0, 10000))}",
                            $"{FactoryRandom.Next(year - 65, year)}-{String.Format("{0:D2}", FactoryRandom.Next(1, 13))}-{String.Format("{0:D2}", FactoryRandom.Next(1, 32))}"));
                }

                return lEmployees;
            }

        }


        public TestData()
        {
            Employees.Clear();
            var year = DateTime.Now.Year;
            var coutEmploee = FactoryRandom.Next(30, 100);
            for (int i = 0; i < coutEmploee; i++)
                LEmployees.Add(new Employee(i, AllName[FactoryRandom.Next(0, AllName.Length - 1)],
                    AllSurname[FactoryRandom.Next(0, AllSurname.Length - 1)],
                    $"{AllName[FactoryRandom.Next(0, AllName.Length - 1)]}ович",
                    FactoryRandom.Next(18, 65),
                    $"+79{String.Format("{0:D2}", FactoryRandom.Next(80, 100))}-{String.Format("{0:D3}", FactoryRandom.Next(0, 1000))}-{String.Format("{0:D4}", FactoryRandom.Next(0, 10000))}",
                    $"{FactoryRandom.Next(year - 65, year)}-{String.Format("{0:D2}", FactoryRandom.Next(1, 13))}-{String.Format("{0:D2}", FactoryRandom.Next(1, 32))}"));
        }
    }
}
