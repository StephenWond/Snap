using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Snap.Test
{
    [TestClass]
    public class CardTest
    {
        [DataTestMethod]
        [DataRow("13", Suit.Diamonds, "King", "Diamonds")]
        [DataRow("12", Suit.Spades, "Queen", "Spades")]
        [DataRow("11", Suit.Clubs, "Jack", "Clubs")]
        [DataRow("10", Suit.Hearts, "10", "Hearts")]
        [DataRow("1", Suit.Spades, "Ace", "Spades")]
        [DataRow("-1", Suit.Clubs, "-1", "Clubs")]
        public void Card_ToString(string rank, Suit suit, string outputRank, string outputSuit)
        {
            //arrange
            var pictureCard = new Card(rank, suit);

            //act
            var cardString = pictureCard.ToString();

            //assert
            Assert.IsTrue(cardString.Contains(outputRank));
            Assert.IsTrue(cardString.Contains(outputSuit));
        }
    }
}

