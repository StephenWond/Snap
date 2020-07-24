using System;
using System.Collections.Generic;
using System.Linq;

namespace Snap
{
    class Program
    {
        static void Main(string[] args)
        {
            //set up and shuffle the deck
            var deckOfCards = new Deck();
            deckOfCards.ShuffleDeck();

            //setup Players - adapt to handle spare cards if (52%noOfPlayers != 0)
            var players = new List<Player>
            {
                new Player($"Stephen", new Queue<Card>(deckOfCards.arrayOfCards.Skip(0).Take(26))),
                new Player($"Nehpets", new Queue<Card>(deckOfCards.arrayOfCards.Skip(26).Take(26)))
            };

            //play game
            var game = new Game(players);
            while (game.ContinueGame())
            {
                game.PlayTurn();
            }

            //report winner
            Console.WriteLine(game.Winner());
            Console.ReadKey();
        }
    }
}
