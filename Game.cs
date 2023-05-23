using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Game
    {
        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
        public Referee Referee { get; set; }
        public List<AssistantReferee> AssistantReferees { get; set; }
        public List<Goal> Goals { get; set; }
        public string Result { get; set; }

        public Game(Team team1, Team team2, Referee referee, List<AssistantReferee>assistantReferees) 
        {
            Team1 = team1;
            Team2 = team2;
            Referee = referee;
            AssistantReferees=assistantReferees;
            Goals = new List<Goal>();
            Result = string.Empty;
        }
        public void AddGoal(int minute, FootballPlayer player)
        {
            Goal goal = new Goal(minute, player);
            Goals.Add(goal);
        }
        public void SetResult(string result)
        {
            Result = result;
        }

        public void PrintResult()
        {
            Console.WriteLine("Game Result:");
            Console.WriteLine("Team 1: " + Team1.Name);
            Console.WriteLine("Team 2: " + Team2.Name);
            Console.WriteLine("Goals:");
            foreach (Goal goal in Goals)
            {
                Console.WriteLine("Minute: " + goal.Minute + ", Player: " + goal.Player.Name);
            }
            Console.WriteLine("Result: " + Result);
        }
    }
}
