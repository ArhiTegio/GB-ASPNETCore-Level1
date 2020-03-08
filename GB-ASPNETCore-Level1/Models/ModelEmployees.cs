using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Models
{
    public static class ModelEmployees
    {
        private static Random random = new Random();
        private static string[] allName;
        private static string[] allSurname;

        public static readonly List<Emploee> _emploees = new List<Emploee>();
        static ModelEmployees()
        {

            _emploees.Clear();
            var year = DateTime.Now.Year;
            var coutEmploee = random.Next(30, 100);
            for (int i = 0; i < coutEmploee; i++)
                _emploees.Add(new Emploee(i, allName[random.Next(0, allName.Length - 1)],
                    allSurname[random.Next(0, allSurname.Length - 1)],
                    $"{allName[random.Next(0, allName.Length - 1)]}ович", 
                    random.Next(18, 65), 
                    $"+79{String.Format("{0:D2}", random.Next(80, 100))}-{String.Format("{0:D3}", random.Next(0, 1000))}-{String.Format("{0:D4}", random.Next(0, 10000))}",
                    $"{random.Next(year - 65, year)}-{String.Format("{0:D2}", random.Next(1, 13))}-{String.Format("{0:D2}", random.Next(1, 32))}"));
        }
    }
}
