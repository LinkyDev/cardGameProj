using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardGameProj
{
    public enum CardSuit { Spade, Diamond, Club, Heart };

    class Card : IComparable<Card>
    {
        public int Order { get; }
        public CardSuit Suit { get; }

        public Card(int order, CardSuit suit)
        {
            if (order < 2 || order > 15)
                throw new ArgumentException("Order must be between 2 and 15");

            this.Order = order;
            this.Suit = suit;
        }

        public int CompareTo(Card other)
        {
            if (other.Order == this.Order)
                return other.Suit - this.Suit;
            return other.Order - this.Order;
        }

        public static bool operator == (Card right, Card left)
        {
            return right.CompareTo(left) == 0;
        }

        public static bool operator != (Card right, Card left)
        {
            return right.CompareTo(left) != 0;
        }

        public static bool operator > (Card right, Card left)
        {
            return right.CompareTo(left) < 0;
        }

        public static bool operator < (Card right, Card left)
        {
            return right.CompareTo(left) > 0;
        }
    }
}