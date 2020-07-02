using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Examen
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Crear
            List<Player> players = new List<Player>();
            List<Player> players1 = new List<Player>();
            List<Player> field = new List<Player>();
            List<Player> field1 = new List<Player>();
            Player p1 = new Player("A A", 23, "Chile", 5000, 350, 200, 1, false); players.Add(p1);
            Player p2 = new Player("B B", 23, "Chile", 5000, 350, 200, 2, true); players.Add(p2);
            Player p3 = new Player("C C", 23, "Chile", 5000, 350, 200, 3, false); players.Add(p3);
            Player p4 = new Player("D D", 23, "Chile", 5000, 350, 200, 4, false); players.Add(p4);
            Player p5 = new Player("E E", 23, "Chile", 5000, 350, 200, 5, false); players.Add(p5);
            Player p6 = new Player("F F", 23, "Chile", 5000, 350, 200, 6, false); players.Add(p6);
            Player p7 = new Player("G G", 23, "Chile", 5000, 350, 200, 7, false); players.Add(p7);
            Player p8 = new Player("H H", 23, "Chile", 5000, 350, 200, 8, false); players.Add(p8);
            Player p9 = new Player("I I", 23, "Chile", 5000, 350, 200, 9, false); players.Add(p9);
            Player p10 = new Player("J J", 23, "Chile", 5000, 350, 200, 10, false); players.Add(p10);
            Player p11 = new Player("K K", 23, "Chile", 5000, 350, 200, 11, false); players.Add(p11);
            Player p12 = new Player("L L", 23, "Chile", 5000, 350, 200, 12, false); players.Add(p12);
            Player p13 = new Player("M M", 23, "Chile", 5000, 350, 200, 13, false); players.Add(p13);
            Player p14 = new Player("N N", 23, "Chile", 5000, 350, 200, 14, false); players.Add(p14);
            Player p15 = new Player("O O", 23, "Chile", 5000, 350, 200, 15, false); players.Add(p15);
            Player p16 = new Player("P P", 23, "Irlanda", 5000, 350, 200, 1, false); players1.Add(p16);
            Player p17 = new Player("A A", 23, "Irlanda", 5000, 350, 200, 2, false); players1.Add(p17);
            Player p18 = new Player("B B", 23, "Irlanda", 5000, 350, 200, 3, false); players1.Add(p18);
            Player p19 = new Player("C C", 23, "Irlanda", 5000, 350, 200, 4, false); players1.Add(p19);
            Player p20 = new Player("D D", 23, "Irlanda", 5000, 350, 200, 5, false); players1.Add(p20);
            Player p21 = new Player("E E", 23, "Irlanda", 5000, 350, 200, 6, false); players1.Add(p21);
            Player p22 = new Player("F F", 23, "Irlanda", 5000, 350, 200, 7, false); players1.Add(p22);
            Player p23 = new Player("G G", 23, "Irlanda", 5000, 350, 200, 8, false); players1.Add(p23);
            Player p24 = new Player("H H", 23, "Irlanda", 5000, 350, 200, 9, false); players1.Add(p24);
            Player p25 = new Player("I I", 23, "Irlanda", 5000, 350, 200, 10, true); players1.Add(p25);
            Player p26 = new Player("J J", 23, "Irlanda", 5000, 350, 200, 11, false); players1.Add(p26);
            Player p27 = new Player("K K", 23, "Irlanda", 5000, 350, 200, 12, false); players1.Add(p27);
            Player p28 = new Player("L L", 23, "Irlanda", 5000, 350, 200, 13, false); players1.Add(p28);
            Player p29 = new Player("M M", 23, "Irlanda", 5000, 350, 200, 14, false); players1.Add(p29);
            Player p30 = new Player("N N", 23, "Irlanda", 5000, 350, 200, 15, false); players1.Add(p30);
            Coach c1 = new Coach("Q Q", 42, "Chile", 10000, 570);
            Coach c2 = new Coach("R R", 42, "Irlanda", 10000, 570);
            Doctor d1 = new Doctor("S S", 42, "Chile", 15000, 500);
            Doctor d2 = new Doctor("T T", 42, "Irlanda", 15000, 500);
            int i = 11;
            while (i>= 0)
            {
                field.Add(players[i]);
                field1.Add(players1[i]);
                i--;
            }
            Team chile = new Team(players, c1, d1, true,"Chile",field);
            Team irlanda = new Team(players1, c2, d2, true, "Irlanda",field1);
            Team ligac = new Team(players, c2, d2, false, "Liga Chilena", field);
            Team ligai = new Team(players1, c1, d1, false, "Liga Irlandesa", field1);
            #endregion

            d1.Injured += c1.OnInjured;
            d2.Injured += c2.OnInjured;

            #region Consola

            chile.ShowInfo();
            Thread.Sleep(3000);
            Console.WriteLine();
            irlanda.ShowInfo();
            Thread.Sleep(3000);
            Console.WriteLine();
            Partido(chile, irlanda);
            Thread.Sleep(3000);
            Console.WriteLine();
            Partido(ligac, ligai);
            Thread.Sleep(3000);
            Console.WriteLine();
            Partido(chile, ligac);
            Thread.Sleep(3000);
            Console.WriteLine();
            Console.WriteLine("Se intenta de agregar un jugador a un equipo nacional.");
            Thread.Sleep(3000);
            chile.AddPlayer(p16);
            Thread.Sleep(3000);
            Console.WriteLine();
            ligai.ShowInfo();
            Thread.Sleep(3000);
            Console.WriteLine();
            Console.WriteLine("Se intenta de agregar un jugador a un equipo de liga.");
            Thread.Sleep(3000);
            ligac.AddPlayer(p23);
            ligac.ShowInfo();
            Console.ReadKey();

            #endregion
        }
        static public void Partido(Team a, Team b)
        {
            if (a.Type == b.Type)
            {
                Console.WriteLine("Se jugó un partido, los equipos que se enfrentaron son:");
                Console.WriteLine(a.Name + " v/s " + b.Name);
                Random rnd = new Random();
                int minutos = rnd.Next(90, 100);
                Console.WriteLine("El partido duró {0} minutos", minutos.ToString());
                int marcadorA = rnd.Next(5);
                int marcadorB = rnd.Next(5);
                Console.WriteLine("El marcador finalizó: " + a.Name + ":" + marcadorA.ToString() +" - "+ b.Name + ":" + marcadorB.ToString());
                string str;
                if (a.Type)
                {
                    str = "Nacional";
                }
                else
                {
                    str = "Liga";
                }
                Console.WriteLine("El tipo de partido es {0}", str);
                int lesion = rnd.Next(3);
                if (lesion == 0)
                {
                    int i = rnd.Next(12);
                    Console.WriteLine("El jugador {0} de {1} se lesionó", a.FieldPlayers[i].Name, a.Name);
                    a.TeamDoctor.EvaluatePlayer(a.FieldPlayers[i]);
                }
                else if (lesion == 1)
                {
                    int i = rnd.Next(12);
                    Console.WriteLine("El jugador {0} de {1} se lesionó", b.FieldPlayers[i].Name, b.Name);
                    b.TeamDoctor.EvaluatePlayer(b.FieldPlayers[i]);
                }
            }
            else
            {
                Console.WriteLine("No se pueden jugar el partido:");
                Console.WriteLine(a.Name + " v/s " + b.Name);
                Console.WriteLine("Ambos equipos no son del mismo tipo (Liga o Nacional)");
            }
        }
    }
}
