using System;

namespace DeckCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck a=new Deck();

        System.Console.WriteLine("/////Before everything/////");
        a.showCard();
        System.Console.WriteLine("///////brand new above//////");
        a.shuffle();
        System.Console.WriteLine("///////After mixed below/////");
        a.showCard();
        System.Console.WriteLine("//show robert see how deal call");
        a.deal();
        a.showCard();
        Player Tom=new Player("Tom");
        Player Robert=new Player("Robot");
        Tom.draw(a);
        // Robert.draw(a);
        Tom.draw(a);
        Tom.draw(a);
        Tom.draw(a);
        System.Console.WriteLine("//below is Tom hand//");
        Tom.showHand();
        System.Console.WriteLine($"Before discard,Tom have {Tom.hand.Count} in hand");
        Tom.discard(4);
        Tom.showHand();
        System.Console.WriteLine($"After discard,Tom have {Tom.hand.Count} in hand");
        }
    }
}
