using System;

namespace human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human Peyton = new Human("Peyton");
            Human Tom= new Human("Tom");
            Console.WriteLine($"Peyton health before attack {Peyton.health}");
            Console.WriteLine($"Tom power is {Tom.Strength}");
            Tom.Attack(Peyton);
            Console.WriteLine("//////////////////////");
            Console.WriteLine($"Peyton health after attacked {Peyton.health}");
        }
    }
}
