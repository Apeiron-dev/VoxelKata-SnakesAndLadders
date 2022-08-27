using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SnakesAndLadders;

namespace Test
{
    /*
     * US 1 - Token Can Move Across the Board
     * As a player
     * I want to be able to move my token
     * So that I can get closer to the goal*/

    [TestClass]
    public class US1
    {
        /*
         * Given the game is started
         * When the token is placed on the board
         * Then the token is on square 1*/
        [TestMethod]
        public void UAT1()
        {
            Game game = new Game();
            List<Player> playerList = new List<Player>() {
                new Player{ Name = "PlayerA"},
                new Player{ Name = "PlayerB"}
            };
            game.ToStart(playerList);
            playerList.ForEach(p => p.PlayerStatus());
        }

        /*
         * Given the token is on square 1
         * When the token is moved 3 spaces
         * Then the token is on square 4*/
        [TestMethod]
        public void UAT2()
        {
            Game game = new Game();
            Player player = new Player { Name = "PlayerA" };
            List<Player> playerList = new List<Player>() { player };
            game.ToStart(playerList);
            player.PlayerStatus();
            player.SetToken(player.RollDie(3));
            player.PlayerStatus();
        }
        /*
         * Given the token is on square 1
         * When the token is moved 3 spaces
         * And then it is moved 4 spaces
         * Then the token is on square 8*/
        [TestMethod]
        public void UAT3()
        {
            Game game = new Game();
            Player player = new Player { Name = "PlayerA" };
            List<Player> playerList = new List<Player>() { player };
            game.ToStart(playerList);
            player.PlayerStatus();
            player.SetToken(player.RollDie(3));
            player.PlayerStatus();
            player.SetToken(player.RollDie(4));
            player.PlayerStatus();
        }
    }
}
