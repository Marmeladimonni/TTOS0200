using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class Lab5
    {
        public static void Teht4()
        {
           
        }

        public class Employee
        {
            public string Name { get; set; }
            public string Profession { get; set; }
            public double Salary { get; set; }

            void PrintEmployee(string Name, string Profession, double Salary)
            {
                Name = "Kirsi Kernel";
                Profession = "Teacher";
                Salary = 1200;
            }
        }

        public class Boss : Employee
        {
            public string Car { get; set; }
            public double Bonus { get; set; }

            void PrintBoss()
            {
                Name = "Jussi Jurkka";
                Profession = "Head of Institute";
                Salary = 9000;
                Car = "Audi";
                Bonus = 5000;
            }
        }
    }
}
