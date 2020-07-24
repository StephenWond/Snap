using System.Collections.Generic;

namespace Snap
{
    public class Player
    {
        public string Name;
        public Queue<Card> QueueOfCards;

        public Player(string name, Queue<Card> queueOfCards)
        {
            Name = name;
            QueueOfCards = queueOfCards;
        }

        public Card PlayTurn()
        {
            return QueueOfCards.Dequeue();
        }

        public void Win(List<Card> winningCards)
        {
            foreach (var card in winningCards)
            {
                QueueOfCards.Enqueue(card);
            }
        }
    }
}