using SnakesAndLadders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesNLadders
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            List<Player> playerList = new List<Player>();
            Console.WriteLine("Welcome to Snakes And Ladders");
            var addPlayer = "y";
            while (!string.IsNullOrEmpty(addPlayer) && (addPlayer!= "n" && addPlayer != "N"))
            {
                if (addPlayer == "y" || addPlayer == "Y")
                {
                    Console.WriteLine("Enter new player's name: ");
                    Player nplayer = new Player();
                    nplayer.Name = Console.ReadLine();
                    Console.WriteLine("New player: " + nplayer.Name);
                    playerList.Add(nplayer);
                }
                Console.WriteLine("Add more players? y/n");
                addPlayer = Console.ReadLine();
            }
            game.ToStart(playerList);
            game.GameRun(playerList);
            game.ToFinish();
            Console.ReadKey();
        }
    }
}
