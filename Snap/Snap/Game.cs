using System;
using System.Collections.Generic;
using System.Linq;

namespace Snap
{
    public class Game
    {
        public List<Card> PlayedCards;
        public List<Player> Players;

        private Card prevCard;
        private Card currentCard;
        private bool firstGo;

        public Game(List<Player> players)
        {
            PlayedCards = new List<Card>();
            Players = players;
            firstGo = true; //one turn needs to be played to start game
        }

        public void PlayTurn()
        {
            foreach (var player in Players)
            {
                currentCard = player.PlayTurn();
                PlayedCards.Add(currentCard);
                if (!firstGo)
                {
                    if (prevCard.Rank == currentCard.Rank)
                    {
                        Snap();
                    }
                }
                prevCard = currentCard;
                firstGo = false;
            }
        }

        private void Snap()
        {
            var rnd = new Random();
            var player = Players[rnd.Next(0, Players.Count)];
            player.Win(PlayedCards);
            PlayedCards.Clear();
        }

        public bool ContinueGame()
        {
            foreach (var player in Players)
            {
                if (player.QueueOfCards.Count < 1)
                {
                    return false;
                }
            }
            return true;
        }

        public string Winner()
        {
            var winningScore = Players.OrderByDescending(p => p.QueueOfCards.Count).First().QueueOfCards.Count();
            var winners = "Winner: ";

            foreach (var player in Players)
            {
                if (player.QueueOfCards.Count == winningScore)
                {
                    winners += $"{player.Name},";
                }
            }
            winners += $" with {winningScore} cards.";
            return winners;
        }
    }
}
