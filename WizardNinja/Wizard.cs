using System;

namespace WizardNinja
{
    class Wizard: Human
    {
        public Wizard(string name): base(name)
        {
            health = 50;
            Intell = 25;
        }

        public override int Attack(Human target){
            int dmg = Intell*5;
            base.Attack(target,dmg);
            health += dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            Console.WriteLine($"{Name} healed for {dmg} point!");
            return target.health;
        }

        public int Heal(Human target){
            int amt=10*Intell;
            base.BeHeal(target,amt);
            return target.health;
        }
    }
}