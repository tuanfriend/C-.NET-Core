using System;

namespace human
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

        public int Attack(Human target){
            target.health = target.health - Strength*5;
            return target.health;
        }
    }
}