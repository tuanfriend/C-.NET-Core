using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lunch time ready for ninja");
            Buffet item=new Buffet();
            Ninja Denis = new Ninja();
            Denis.Eat(item.Serve());
            Denis.Eat(item.Serve());

        }
    }
}
