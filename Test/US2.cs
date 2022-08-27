using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SnakesAndLadders;


namespace Test
{   /*
    * As a player
    * I want to be able to win the game
    * So that I can gloat to everyone around*/
    [TestClass]
    public class US2
    {
        /*
         * Given the token is on square 97
         * When the token is moved 3 spaces
         * Then the token is on square 100
         * And the player has won the game*/
        [TestMethod]
        public void UAT1()
        {
            Player player = new Player { Name = "PlayerA", Token = 97 };
            player.PlayerStatus();
            player.SetToken(player.RollDie(3));
            player.PlayerStatus();
        }
        /*
         * Given the token is on square 97
         * When the token is moved 4 spaces
         * Then the token is on square 97
         * And the player has not won the game*/
        [TestMethod]
        public void UAT2()
        {
            Player player = new Player { Name = "PlayerA", Token = 97 };
            player.PlayerStatus();
            player.SetToken(player.RollDie(4));
            player.PlayerStatus();

        }

    }
}
