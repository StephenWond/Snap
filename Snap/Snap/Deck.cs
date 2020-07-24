using System;

namespace Snap
{
    public class Deck
    {
        public Card[] arrayOfCards;
        private readonly int sizeOfDeck = 52;

        public Deck()
        {
            arrayOfCards = CreateDeck();
        }

        private Card[] CreateDeck()
        {
            var newDeck = new Card[sizeOfDeck];
            var j = 0;

            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                for (int i = 1; i < 14; i++)
                {
                    var card = new Card(i.ToString(), suit);
                    newDeck[j] = card;
                    j++;
                }
            }

            return newDeck;
        }

        public void ShuffleDeck()
        {
            var rnd = new Random();

            for (int i = 0; i < arrayOfCards.Length - 1; i++)
            {
                int j = rnd.Next(i, arrayOfCards.Length);
                Card card = arrayOfCards[i];
                arrayOfCards[i] = arrayOfCards[j];
                arrayOfCards[j] = card;
            }
        }
    }
}
