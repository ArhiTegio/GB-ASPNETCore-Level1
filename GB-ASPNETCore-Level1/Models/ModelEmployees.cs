using System;
using System.Collections.Generic;
using static AllRussianName.Russian;

namespace WebStore.Models
{
    public class ModelEmployees
    {
        public static Random FactoryRandom { get; } = new Random();
        public static string[] AllName { get; } = GetManNames();
        public static string[] AllSurname { get; } = GetManSurname();

        public static readonly Dictionary<int, Employee> _employees = new Dictionary<int, Employee>();

        static ModelEmployees()
        {
            _employees.Clear();
            var year = DateTime.Now.Year;
            var coutEmploee = FactoryRandom.Next(30, 100);
            for (int i = 0; i < coutEmploee; i++)
                _employees.Add(i, new Employee(i, AllName[FactoryRandom.Next(0, AllName.Length - 1)],
                    AllSurname[FactoryRandom.Next(0, AllSurname.Length - 1)],
                    $"{AllName[FactoryRandom.Next(0, AllName.Length - 1)]}ович", 
                    FactoryRandom.Next(18, 65), 
                    $"+79{String.Format("{0:D2}", FactoryRandom.Next(80, 100))}-{String.Format("{0:D3}", FactoryRandom.Next(0, 1000))}-{String.Format("{0:D4}", FactoryRandom.Next(0, 10000))}",
                    $"{FactoryRandom.Next(year - 65, year)}-{String.Format("{0:D2}", FactoryRandom.Next(1, 13))}-{String.Format("{0:D2}", FactoryRandom.Next(1, 32))}"));
        }
    }
}
