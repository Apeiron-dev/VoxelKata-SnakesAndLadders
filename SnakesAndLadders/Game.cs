using SnakesAndLadders;
using System;
using System.Collections.Generic;
using System.Linq;

public class Game
{
    public bool Start { get; set; }
    public bool Finish { get; set; }

    public Game()
    {
        Start = false;
        Finish = false;
    }

    public void ToStart(List<Player> players)
    {
        Start = true;
        players.ForEach(p => p.Token = 1);
        Console.WriteLine("The game has STARTED with " + players.Count + " players");
    }
    public void GameRun(List<Player> players)
    {
        Board board = new Board();
        int round = 1;
        while (players.All(p => p.Token >= 1 && p.Token < 100))
        {
            Console.WriteLine("* Round " + round);
            foreach (var player in players)
            {
                Console.WriteLine(string.Format("* {0} it's your turn. Press any key to roll the die!", player.Name));
                Console.ReadKey(true);
                int box = player.RollDie();
                Console.WriteLine(String.Format("\t{0} is on box {1} and {2} box {3}", 
                    player.Name, 
                    player.Token, 
                    player.Token == box ? "stay in" : "moves to",
                    box));
                player.SetToken(board.MoveToken(box));

                if (player.IsWinner)
                    break;
            }
            round++;
        }
    }

    public void ToFinish()
    {
        Finish = true;
        Console.WriteLine("The game is END!");
    }

}