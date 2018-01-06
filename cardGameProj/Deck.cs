﻿using System;
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

        public static void Create()
        {
            Deck deck = new Deck();

            for(int i=2; i<15; i++)
            {
                Card CardSpade = new Card(i, CardSuit.Spade);
                deck.Push(CardSpade);

                Card CardDiamond = new Card(i, CardSuit.Diamond);
                deck.Push(CardDiamond);

                Card CardClub = new Card(i, CardSuit.Club);
                deck.Push(CardClub);

                Card CardHeart = new Card(i, CardSuit.Heart);
                deck.Push(CardHeart);
            }
        }

        public void Shuffle(int n)
        {
            //Temporary lists
            List<Card> list = new List<Card>();
            List<Card> list2 = new List<Card>();
            
            //Shuffles n times
            for(int y = 0; y<n; y++)
            {
                //Pops all of the cards to list
                while (Cards != null)
                {
                    list.Add(Cards.Pop());
                }

                //Adds half of the cards from list to list2
                for (int i = 0; i < list.Count / 2; i++)
                {
                    list2.Add(list[i]);
                    list.RemoveAt(i);
                }

                //Pushes the cards from list to the deck
                for (int j = 0; j < list.Count; j++)
                {
                    Cards.Push(list[j]);
                    Cards.Push(list2[j]);
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
