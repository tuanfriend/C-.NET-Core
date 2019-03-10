using System;
using System.Collections.Generic;

namespace DeckCards
{
    class Deck
    {
        public List<Card> cards;

        public Deck()
        {
            cards = new List<Card>();

            //This list have 52 unique card, this is a contructor
            List<string> stringVal = new List<string> { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            List<string> suit = new List<string> { "Clubs", "Spades", "Hearts", "Diamonds" };
            List<int> val = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

            for (int i = 0; i < stringVal.Count; i++)
            {
                for (int j = 0; j < suit.Count; j++)
                {
                    Card newcard = new Card();
                    newcard.stringVal = stringVal[i];
                    newcard.suit = suit[j];
                    newcard.val = i + 1;
                    cards.Add(newcard);
                }
            }

            Console.WriteLine(cards.Count);
        }

        public Card deal()
        {
            Card topcard = new Card();
            topcard = cards[0];
            cards.RemoveAt(0);
            // Console.WriteLine(topcard);
            return topcard;
        }

        public void showCard(){
            foreach(Card each in cards){
                each.saycard();
            }
        }

        public Deck reset(){
            Deck reset=new Deck();
            return reset;
        }

        public void shuffle(){
            for(int i=0;i<cards.Count;i++)
            {
                Random rand=new Random();
                int idx= rand.Next(cards.Count);
                Card temp = cards[i];
                cards[i] = cards[idx];
                cards[idx] = temp;
            }
        }
    }
}
