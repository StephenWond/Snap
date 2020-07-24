using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Snap.Test
{
    [TestClass]
    public class DeckTest
    {
        [TestMethod]
        public void Deck_New_NumberOfCards()
        {
            //arrange
            var newDeck = new Deck();

            //act
            var numberofCards = newDeck.arrayOfCards.Length;

            //assert
            Assert.AreEqual(52, numberofCards);
        }

        [TestMethod]
        public void Deck_New_UniqueCards()
        {
            //arrange
            var newDeck = new Deck();

            //act
            var distinctSuitsCount = newDeck.arrayOfCards.Select(s => s.Suit).Distinct().Count();
            var distinctRankCount = newDeck.arrayOfCards.Select(r => r.Rank).Distinct().Count();

            //assert
            Assert.AreEqual(4, distinctSuitsCount);
            Assert.AreEqual(13, distinctRankCount);
        }

        [TestMethod]
        public void Deck_Shuffle_ArrayOrderNotEqual()
        {
            //arrange
            var firstDeck = new Deck();
            var secondDeck = new Deck();

            //act
            firstDeck.ShuffleDeck();
            secondDeck.ShuffleDeck();
            var isSequenceEqual = firstDeck.arrayOfCards.SequenceEqual(secondDeck.arrayOfCards);

            //assert
            Assert.IsFalse(isSequenceEqual);
        }
    }
}
