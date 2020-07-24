namespace Snap
{
    public class Card
    {
        public string Rank;
        public Suit Suit;

        public Card(string rank, Suit suit)
        {
            Rank = rank;
            Suit = suit;
        }

        public override string ToString()
        {
            switch (Rank)
            {
                case "1":
                    Rank = "Ace";
                    break;
                case "11":
                    Rank = "Jack";
                    break;
                case "12":
                    Rank = "Queen";
                    break;
                case "13":
                    Rank = "King";
                    break;
                default:
                    break;
            }

            return $"{this.Rank} of {this.Suit}";
        }
    }
}
