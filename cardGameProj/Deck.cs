using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardGameProj
{
    class Deck
    {
        private Stack<Card> Cards;

        public Deck()
        {
            Cards = new Stack<Card>();
        }

        public static Deck CreateNewDeck()
        {
            Deck deck = new Deck();

            for (int i = 2; i < 15; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    deck.Push(new Card(i, (CardSuit)j));
                }
            }

            return deck;
        }

        public void Shuffle(int n)
        {
            Random random = new Random();

            //Temporary lists
            Stack<Card> s1 = new Stack<Card>();
            Stack<Card> s2 = new Stack<Card>();

            //Pops half of the cards to s1
            for (int i = 0; i < Cards.Count() / 2; i++)
            {
                s1.Push(Cards.Pop());
            }

            //Pops the rest of the cards to s2
            for (int j = 0; j < Cards.Count; j++)
            {
                s2.Push(Cards.Pop());
            }

            //Pushes randomly the cards back to the deck
            while (s1.Count() > 0)
            {
                for (int x = 0; x < random.Next(s1.Count()); x++)
                {
                    Cards.Push(s1.Pop());
                }
            }

            //Pushes the rest of the cards back to the deck
            while (s2.Count() > 0)
            {
                for (int x = 0; x < random.Next(s2.Count()); x++)
                {
                    Cards.Push(s2.Pop());
                }
            }


        }

        /// <summary>
        /// 
        /// </summary>
        public void RealisticShuffle()
        { 
            Stack<Card> s1 = new Stack<Card>();
            Stack<Card> s2 = new Stack<Card>();
            Random rnd = new Random();

            int rand = rnd.Next(Cards.Count());

            for(int i = 0; i < rand; i++)
            {
                s1.Push(Cards.Pop());
            }

            for(int j = 0; j < Cards.Count(); j++)
            {
                s2.Push(Cards.Pop());
            }

            while(s1.Count() > 0 && s2.Count() > 0)
            {
                Cards.Push(s1.Pop());
                Cards.Push(s2.Pop());
            }

            if(s1.Count() != 0)
            {
                while(s1.Count() > 0)
                {
                    Cards.Push(s1.Pop());
                }
            }

            if (s2.Count() != 0)
            {
                while (s2.Count() > 0)
                {
                    Cards.Push(s2.Pop());
                }
            }

        }

        public Card Draw()
        {
            return Cards.Pop();
        }

        public void Push(Card card)
        {
            this.Cards.Push(card);
        }

        public Card Pop()
        {
            return this.Cards.Pop();
        }

        public Card Peek()
        {
            return this.Cards.Peek();
        }
    }
}
