using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Snap.Test
{
    [TestClass]
    public class PlayerTest
    {
        private List<Card> cardList;

        public PlayerTest()
        {
            cardList = new List<Card>
            {
                new Card("Ace", Suit.Clubs),
                new Card("King", Suit.Diamonds),
                new Card("2", Suit.Spades)
            };

        }

        [TestMethod]
        public void Player_PlayTurn_RemovesTopCard()
        {
            //arrange
            var player = new Player("TestPlayer", new Queue<Card>(cardList));

            //act
            var topCard = player.PlayTurn();

            //assert
            Assert.IsTrue(topCard.Rank.Contains("Ace"));
            Assert.AreEqual(cardList.Count - 1, player.QueueOfCards.Count);
        }

        [TestMethod]
        public void Player_Win_AddsCardsToPlayerPile()
        {
            //arrange
            var player = new Player("TestPlayer", new Queue<Card>(cardList));

            //act
            player.Win(cardList);

            //assert
            Assert.AreEqual(cardList.Count * 2, player.QueueOfCards.Count);
        }
    }
}
