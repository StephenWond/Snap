using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Snap.Test
{
    [TestClass]
    public class GameTest
    {
        [TestMethod]
        public void Game_ContinueGame_GameStopsIfPlayerHasNoCards()
        {
            //arrange
            var players = new List<Player>
            {
                new Player("TestPlayer", new Queue<Card>())
            };

            var game = new Game(players);

            //act
            var result = game.ContinueGame();

            //assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Game_Winner_ReturnsPlayerWithMostCards()
        {
            //arrange
            var players = new List<Player>
            {
                new Player("TestPlayer1", new Queue<Card>()),
                new Player("TestPlayer2", new Queue<Card>())
            };

            var game = new Game(players);

            //act
            var result = game.Winner();

            //assert
            Assert.IsTrue(result.Contains("TestPlayer1"));
            Assert.IsTrue(result.Contains("TestPlayer2"));
        }
    }
}
