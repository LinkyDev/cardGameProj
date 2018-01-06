using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardGameProj
{
    public enum CardSuit { Spade, Diamond, Club, Heart };

    class Card
    {
        public int Order { get; set; }
        public CardSuit Suit { get; set; }

        public Card(int order, CardSuit suit)
        {
            this.Order = order;
            this.Suit = suit;
        }
    }
}
