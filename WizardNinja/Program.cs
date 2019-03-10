using System;

namespace WizardNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Human Tom=new Human("Tom");
            Human Anne=new Human("Anne");
            System.Console.WriteLine("Anne before attack health is "+Anne.health);
            Wizard Alena = new Wizard("Alena");
            Alena.Attack(Anne);
            System.Console.WriteLine("Anne AFTER attack health is "+Anne.health);
            System.Console.WriteLine("Alena AFTER attack health is "+Alena.health);
        }
    }
}
