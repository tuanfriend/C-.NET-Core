using System;
using System.Collections.Generic;
namespace DeckCards
{
    class Player{
        public string name;
        public List<Card> hand;

        public Player(string Name){
            name = Name;
            hand = new List<Card>();
        }

        public Card draw(Deck fromdeck){
            Card thiscard = new Card();
            thiscard = fromdeck.cards[0];
            fromdeck.cards.RemoveAt(0);
            hand.Add(thiscard);
            return thiscard;
        }

        public void showHand(){
            foreach(Card each in hand){
                each.saycard();
            }
        }

        public Card discard(int idx){
            if(idx>0 && idx<= hand.Count){
                Card temp = hand[idx-1];
            hand.RemoveAt(idx-1);
            return temp;
            }
            else 
            System.Console.WriteLine("Null");
            return null;
        }
    }
}