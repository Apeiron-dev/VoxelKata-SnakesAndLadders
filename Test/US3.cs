using Microsoft.VisualStudio.TestTools.UnitTesting;
using SnakesAndLadders;
using System.Collections.Generic;

namespace Test
{
    /*
     * As a player
     * I want to move my token based on the roll of a die
     * So that there is an element of chance in the game*/
    [TestClass]
    public class US3
    {
        /*
         * Given the game is started
         * When the player rolls a die
         * Then the result should be between 1-6 inclusive*/
        [TestMethod]
        public void UAT1()
        {
            Game game = new Game();
            List<Player> playerList = new List<Player>() {
                new Player{ Name = "PlayerA"},
                new Player{ Name = "PlayerB"},
                new Player{ Name = "PlayerC"},
                new Player{ Name = "PlayerD"},
                new Player{ Name = "PlayerE"},
                new Player{ Name = "PlayerF"}
            };
            game.ToStart(playerList);
            playerList.ForEach(p => p.PlayerStatus());
            playerList.ForEach(p => p.RollDie());
        }

        /*
         * Given the player rolls a 4
         * When they move their token
         * Then the token should move 4 spaces*/
        [TestMethod]
        public void UAT2()
        {
            Game game = new Game();
            List<Player> playerList = new List<Player>() {
                new Player{ Name = "PlayerA"},
                new Player{ Name = "PlayerB"}
            };
            game.ToStart(playerList);
            playerList.ForEach(p => p.PlayerStatus());
            playerList.ForEach(p => p.SetToken(p.RollDie(4)));
            playerList.ForEach(p => p.PlayerStatus());
        }
    }
}
