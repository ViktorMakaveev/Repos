using ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
       
        List<FootballPlayer> players = new List<FootballPlayer>();

        
        players.Add(new Goalkeeper("P1", 1, 25, 180));
        players.Add(new Deffender("P2", 2, 27, 185));
        players.Add(new Deffender("P3", 3, 26, 182));
        players.Add(new Midfield("P4", 4, 24, 178));
        players.Add(new Midfield("P5", 5, 23, 175));
        players.Add(new Midfield("P6", 6, 25, 180));
        players.Add(new Midfield("P7", 7, 26, 182));
        players.Add(new Striker("P8", 8, 28, 185));
        players.Add(new Striker("P9", 9, 24, 178));
        players.Add(new Striker("P10", 10, 25, 180));
        players.Add(new Striker("P11", 11, 23, 175));
        players.Add(new Striker("P12", 12, 26, 182));
        players.Add(new Striker("P13", 13, 24, 178));
        players.Add(new Striker("P14", 14, 27, 185));
        players.Add(new Deffender("P15", 15, 26, 182));
        players.Add(new Midfield("P16", 16, 25, 180));
        players.Add(new Midfield("P17", 17, 24, 178));
        players.Add(new Midfield("P18", 18, 25, 180));
        players.Add(new Midfield("P19", 19, 26, 182));
        players.Add(new Deffender("P20", 20, 27, 185));
        players.Add(new Deffender("P21", 21, 23, 175));
        players.Add(new Goalkeeper("P22", 22, 24, 178));

        
        Team team1 = new Team("Team 1", new Coach("Coach 1", 40), players.GetRange(0, 11));
        Team team2 = new Team("Team 2", new Coach("Coach 2", 45), players.GetRange(11, 11));

        
        Referee referee = new Referee("Referee 1", 35);
        List<AssistantReferee> assistantReferees = new List<AssistantReferee>()
        {
            new AssistantReferee("Assistant Referee 1", 30),
            new AssistantReferee("Assistant Referee 2", 32)
        };

        
        Game game = new Game(team1, team2, referee, assistantReferees);

        
        game.AddGoal(15, players[0]);
        game.AddGoal(30, players[1]);
        game.AddGoal(55, players[11]);
        game.AddGoal(70, players[12]);

        
        game.SetResult("Team 1 - Team 2: 2-2");

        
        game.PrintResult();
    }
}
