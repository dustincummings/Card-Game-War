using System;
using System.Collections.Generic;
using System.Text;

namespace CardGameWar
{
    public class Card
    {
        public string Kind { get; set; }
        public string Suit { get; set; }

        public Card()
        {

        }
        public int CardValue()
        {
            int value = 0;
            switch (this.Kind)
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
                    value = int.Parse(this.Kind);
                    break;
            }
            return value;
        }

    }
}
