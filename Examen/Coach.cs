using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Coach : Person
    {
        private int tacticPoints;

        public Coach(string name, int age, string nationality, int salary, int tacticPoints) : base(name, age, nationality, salary)
        {
            TacticPoints = tacticPoints;
        }

        public int TacticPoints { get => tacticPoints; set => tacticPoints = value; }

        public void ChangePlayer()
        {
            // Not Implemented Yet
        }
    }
}
