using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Person
    {
        private string name;
        private int age;
        private string nationality; // Se pone el pais en español. Ej. Chile, España, EEUU
        private int salary;

        public Person(string name, int age, string nationality, int salary)
        {
            Name = name;
            Age = age;
            Nationality = nationality;
            Salary = salary;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Nationality { get => nationality; set => nationality = value; }
        public int Salary { get => salary; set => salary = value; }

        public string ShowInfo()
        {
            string s = this.name + " tiene "+ this.age.ToString()+ " años, es de  "+this.nationality+" y tiene un sueldo de "+ this.salary.ToString() +".";
            return s;
        }
    }
}
