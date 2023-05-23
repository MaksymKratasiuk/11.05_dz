using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._05_dz
{
    public class FootballPlayer
    {
        public string Name { get; set; }
        public int Number { get; set; }
    }

    public class FootballTeam : IEnumerable<FootballPlayer>
    {
        private List<FootballPlayer> players;

        public FootballTeam()
        {
            players = new List<FootballPlayer>();
        }

        public void AddPlayer(FootballPlayer player)
        {
            players.Add(player);
        }

        public IEnumerator<FootballPlayer> GetEnumerator()
        {
            return players.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    internal class Task2
    {
        public static void task2()
        {
            FootballTeam team = new FootballTeam();
            team.AddPlayer(new FootballPlayer { Name = "John", Number = 10 });
            team.AddPlayer(new FootballPlayer { Name = "Mike", Number = 7 });
            team.AddPlayer(new FootballPlayer { Name = "Sarah", Number = 3 });

            foreach (FootballPlayer player in team)
            {
                Console.WriteLine("Name: " + player.Name + ", Number: " + player.Number);
            }
        }
    }
}
