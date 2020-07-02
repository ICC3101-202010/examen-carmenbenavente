using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Team
    {
        private List<Player> teamPlayers;
        private Coach teamCoach;
        private Doctor teamDoctor;
        private bool type; // true es Nacional y false es Liga

        public Team(List<Player> teamPlayers, Coach teamCoach, Doctor teamDoctor, bool type)
        {
            this.teamPlayers = teamPlayers;
            this.teamCoach = teamCoach;
            this.teamDoctor = teamDoctor;
            this.type = type;
        }

        public List<Player> TeamPlayers { get => teamPlayers; set => teamPlayers = value; }
        public Coach TeamCoach { get => teamCoach; set => teamCoach = value; }
        public Doctor TeamDoctor { get => teamDoctor; set => teamDoctor = value; }
        public bool Type { get => type; set => type = value; }

        public void VerifyPlayers()
        {
            string n = this.teamPlayers[0].Nationality;
            foreach (Player pl in this.teamPlayers)
            {
                Console.WriteLine(pl.ShowInfo());
                if (this.type)
                {
                    if (pl.Nationality != n)
                    {
                        Console.WriteLine("Hay un jugador que no puede estar en el equipo, el jugador es:");
                        Console.WriteLine(pl.ShowInfo());
                    }
                }
                
            }
            Console.WriteLine("Se ha verificado correctamente.");
        }
    
        public void AddPlayer(Player p)
        {
            if (this.type)
            {
            string n = this.teamPlayers[0].Nationality;
                if (n == p.Nationality)
                {
                    TeamPlayers.Add(p);
                }
                else
                {
                    Console.WriteLine("No se puede agregar a un equipo nacional un jugador de otro país.");
                }
            }
            else
            {
                TeamPlayers.Add(p);
            }
        }
    }
}
