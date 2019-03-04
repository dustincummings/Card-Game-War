using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardGameWar
{
    class GameRepo
    {
        public List<Card> _deck = new List<Card>();
        private Random _random = new Random();
        public Card card = new Card();

        public int CardValue()
        {
            int value = 0;
            switch (card.Kind)
            {
                case "Jack":
                    value = 11;
                    break;
                case "Queen":
                    value = 12;
                    break;
                case "King":
                    value = 13;
                    break;
                case "Ace":
                    value = 14;
                    break;
                default:
                    value = int.Parse(card.Kind);
                    break;
            }
            return value;
        }


    }
}
