using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Doctor : Person
    {
        private int expPontis;
        public Doctor(string name, int age, string nationality, int salary, int expPoints) : base(name, age, nationality, salary)
        {
            ExpPontis = expPoints;
        }

        public int ExpPontis { get => expPontis; set => expPontis = value; }

        public void EvaluatePlayer(Player p)
        {
            //Not Implemented Yet
        }
        public void CurePlayer(Player p)
        {
            //Not Implemented Yet
        }
    }
}
