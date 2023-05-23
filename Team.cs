using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Team
    {
        public string Name { get; set; }
        public Coach Coach { get; set; }
        public List<FootballPlayer> Players { get; set; }

        public Team(string name, Coach coach, List<FootballPlayer> players)
        {
            Name = name;
            Coach = coach;
            Players = players;
        }

        public double AvgAge()
        {
            if (Players.Count == 0)
            return 0;

            int totalAge = 0;
            foreach (FootballPlayer player in Players)
            {
                totalAge += player.Age;
            }

            double AvgAge=(double)totalAge/Players.Count;
            return AvgAge;
        }
    }
}
