using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Player : Person
    {
        private int atackPoints;
        private int defensePoints;
        private int number;
        private bool goalkeeper; // true si es arquero
        public Player(string name, int age, string nationality, int salary, int atackPoints, int defensePoints, int number, bool goalkeeper) : base(name, age, nationality, salary)
        {
            AtackPoints = atackPoints;
            DefensePoints = defensePoints;
            Number = number;
            Goalkeeper = goalkeeper;
        }

        public int AtackPoints { get => atackPoints; set => atackPoints = value; }
        public int DefensePoints { get => defensePoints; set => defensePoints = value; }
        public int Number { get => number; set => number = value; }
        public bool Goalkeeper { get => goalkeeper; set => goalkeeper = value; }
    }
}
