using System;

namespace WizardNinja
{
    class Human{
        public string Name;
        public int Strength;
        public int Intell;
        public int Dexter;
        private int Health;

        public int health{
            get { return Health; }
            set { Health = value;}
        }

        public Human(string name){
            Name = name;
            Strength = 3;
            Intell = 3;
            Dexter = 3;
            Health = 100;
        }

        public Human(string name, int stren, int intel, int dex, int health){
            Name = name;
            Strength = stren;
            Intell = intel;
            Dexter = dex;
            Health = health;
        }

        public virtual int Attack(Human target){
            target.health = target.health - Strength*5;
            Console.WriteLine($"{Name} attacked {target.Name} for {Strength*5} damage!");
            return target.health;
        }

        public int Attack(Human target, int dmg){
            target.health -= dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.health;
        }

        public int BeHeal(Human target, int amt){
            target.health += amt;
            Console.WriteLine($"{target.Name} was heal for {amt} point!");
            return target.health;
        }
    }

}