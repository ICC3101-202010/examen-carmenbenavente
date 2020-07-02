using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Crear
            List<Player> players = new List<Player>();
            List<Player> players1 = new List<Player>();
            Player p1 = new Player("A A", 23, "Chile", 5000, 350, 200, 1, false); players.Add(p1); players1.Add(p1);
            Player p2 = new Player("B B", 23, "Chile", 5000, 350, 200, 2, true); players.Add(p2); players1.Add(p2);
            Player p3 = new Player("C C", 23, "Chile", 5000, 350, 200, 3, false); players.Add(p3);
            Player p4 = new Player("D D", 23, "Chile", 5000, 350, 200, 4, false); players.Add(p4); players1.Add(p4);
            Player p5 = new Player("E E", 23, "Chile", 5000, 350, 200, 5, false); players.Add(p5);
            Player p6 = new Player("F F", 23, "Chile", 5000, 350, 200, 6, false); players.Add(p6);
            Player p7 = new Player("G G", 23, "Chile", 5000, 350, 200, 7, false); players.Add(p7); players1.Add(p7);
            Player p8 = new Player("H H", 23, "Chile", 5000, 350, 200, 8, false); players.Add(p8);
            Player p9 = new Player("I I", 23, "Chile", 5000, 350, 200, 9, false); players.Add(p9);
            Player p10 = new Player("J J", 23, "Chile", 5000, 350, 200, 10, false); players.Add(p10); players1.Add(p10);
            Player p11 = new Player("K K", 23, "Chile", 5000, 350, 200, 11, false); players.Add(p11);
            Player p12 = new Player("L L", 23, "Chile", 5000, 350, 200, 12, false); players.Add(p12);
            Player p13 = new Player("M M", 23, "Chile", 5000, 350, 200, 13, false); players1.Add(p13);
            Player p14 = new Player("N N", 23, "Chile", 5000, 350, 200, 14, false); players1.Add(p14);
            Player p15 = new Player("O O", 23, "Chile", 5000, 350, 200, 15, false); players.Add(p15);
            Player p16 = new Player("P P", 23, "Irlanda", 5000, 350, 200, 16, false); players1.Add(p16);
            Coach c1 = new Coach("Q Q", 42, "Chile", 10000, 570);
            Coach c2 = new Coach("R R", 42, "Irlanda", 10000, 570);
            Doctor d1 = new Doctor("S S", 42, "Chile", 15000, 500);
            Doctor d2 = new Doctor("T T", 42, "Irlanda", 15000, 500);
            Team chile = new Team(players, c1, d1, true);
            Team liga = new Team(players1, c2, d2, false);
            #endregion
            //chile.VerifyPlayers();
            //chile.AddPlayer(p16);
            //liga.VerifyPlayers();
            //liga.AddPlayer(p3);
            //liga.VerifyPlayers();
            Console.ReadKey();
        }
    }
}
