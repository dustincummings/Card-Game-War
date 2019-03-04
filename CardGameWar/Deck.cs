using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardGameWar
{
    public class Deck
    {
        public List<Card> _deck;
        private StringBuilder _sb;
        private Random _random;
        public Deck()
        {
            _deck = new List<Card>();
            _sb = new StringBuilder();
            _random = new Random();

            string[] suits = new string[] { "Clubs", "Diamonds", "Hearts", "Spades" };
            string[] kinds = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace", };

            foreach (var suit in suits)
            {
                foreach (var kind in kinds)
                {
                    _deck.Add(new Card() { Suit = suit, Kind = kind });
                }
            }
        }
            public string Deal(Player player1, Player player2)
            {
                while (_deck.Count > 0)
                {
                    dealCard(player1);
                    dealCard(player2);
                }
                return _sb.ToString();
            }
            public void dealCard(Player player)
            {
                Card card = _deck.ElementAt(_random.Next(_deck.Count));
                player.Cards.Add(card);
                _deck.Remove(card);

                _sb.Append($"\n{player.Name} is dealt the {card.Kind} of {card.Suit}");
            }
    }
}
