using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Doctor : Person
    {
        public event EventHandler<PlayerEventArgs> Injured;
        private int expPontis;
        public Doctor(string name, int age, string nationality, int salary, int expPoints) : base(name, age, nationality, salary)
        {
            ExpPontis = expPoints;
        }

        public int ExpPontis { get => expPontis; set => expPontis = value; }

        public void EvaluatePlayer(Player p)
        {
            OnInjured(p);
        }
        public void CurePlayer(Player p)
        {
            Console.WriteLine("Se curó al jugador " + p.Name);
        }
        protected virtual void OnInjured(Player p)
        {
            if (Injured != null)
            {
                Injured(this, new PlayerEventArgs() { player = p} );
            }
            CurePlayer(p);
        }
    }
}
