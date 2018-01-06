using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardGameProj
{
    class Deck
    {
        public Card[] Cards = new Card[51];
        public Card TopCard;

        public Deck()
        {
            for(int i = 0; i<51; i++)
            {
                for(int j = 2; j<15; j++)
                {
                    Card CardSpade = new Card(j, CardSuit.Spade);
                    Cards[i] = CardSpade;

                    Card CardDiamond = new Card(j, CardSuit.Diamond);
                    Cards[i+13] = CardDiamond;

                    Card CardClub = new Card(j, CardSuit.Club);
                    Cards[i+(13*2)] = CardClub;

                    Card CardHeart = new Card(j, CardSuit.Heart);
                    Cards[i+(13*3)] = CardHeart;
                }
            }
        }

        public void Shuffle()
        {
            Random rnd = new Random();

            Card[] arr = new Card[51];
            int temp;

            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = Cards[i];
                Cards[i] = null;
            }

            for(int j=0; j<arr.Length; j++)
            {
                temp = rnd.Next(Cards.Length+1);
                if(Cards[temp] != null)
                {
                    Cards[temp] = arr[j];
                }
            }

            this.TopCard = Cards[0];
        }

        public Card Draw()
        {
            Card temp = this.TopCard;

            for(int i=0; i<Cards.Length-1; i++)
            {
                Cards[i] = Cards[i + 1];
            }

            return temp;
        }

    }
}
