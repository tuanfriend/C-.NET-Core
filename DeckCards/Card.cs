using System;
using System.Collections.Generic;
namespace DeckCards
{
    class Card{
        public string stringVal{get;set;}

        public string suit{get;set;}

        public int val{get;set;}

        public void saycard(){
            Console.WriteLine($"This card is {stringVal} with Suit is {suit}");
        }

        // public Card(string StringVal, string Suit){
        //     stringVal = StringVal;
        //     suit = Suit;
        // }
    }
}