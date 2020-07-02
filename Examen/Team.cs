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
        private string name;
        private List<Player> fieldPlayers;

        public Team(List<Player> teamPlayers, Coach teamCoach, Doctor teamDoctor, bool type, string name, List<Player> fieldPlayers)
        {
            this.teamPlayers = teamPlayers;
            this.teamCoach = teamCoach;
            this.teamDoctor = teamDoctor;
            this.type = type;
            this.name = name;
            this.FieldPlayers = fieldPlayers;
        }

        public List<Player> TeamPlayers { get => teamPlayers; set => teamPlayers = value; }
        public Coach TeamCoach { get => teamCoach; set => teamCoach = value; }
        public Doctor TeamDoctor { get => teamDoctor; set => teamDoctor = value; }
        public bool Type { get => type; set => type = value; }
        public string Name { get => name; set => name = value; }
        public List<Player> FieldPlayers { get => fieldPlayers; set => fieldPlayers = value; }

        public void ShowInfo()
        {
            Console.WriteLine(this.name);
            if (this.type)
            {
                Console.WriteLine("Este equipo es Nacional");
            }
            else
            {
                Console.WriteLine("Este equipo es de Liga");
            }
            string n = this.teamPlayers[0].Nationality;
            Console.WriteLine("Sus jugadores son:");
            foreach (Player pl in this.teamPlayers)
            {
                if (pl.Goalkeeper)
                {
                    Console.WriteLine(pl.ShowInfo() + " Su número es el " + pl.Number.ToString() + "." +" Es arquero en el equipo.");
                }
                else
                {
                    Console.WriteLine(pl.ShowInfo() + " Su número es el " + pl.Number.ToString() + ".");
                }
                
                if (this.type)
                {
                    if (pl.Nationality != n)
                    {
                        Console.WriteLine("Hay un jugador que no puede estar en el equipo, el jugador es:");
                        Console.WriteLine(pl.ShowInfo());
                    }
                }
                
            }
            Console.WriteLine("El entrenador es:");
            Console.WriteLine(this.teamCoach.ShowInfo());
            Console.WriteLine("El médico es:");
            Console.WriteLine(this.teamDoctor.ShowInfo());
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
