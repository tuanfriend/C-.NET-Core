using System;

namespace WizardNinja
{
    class Samurai: Human
    {
        private int basehealth = 200;
        public Samurai(string name): base(name)
        {
            health = basehealth;
        }

        public override int Attack(Human target){
            if(target.health<50){
                int dmg= target.health;
                base.Attack(target,dmg);
            }else{
                Console.WriteLine("You are lucky, i don't want to attack you now!");
            }
            return target.health;
        }

        public int Meditae(){
            this.health = basehealth;
            Console.WriteLine("You have full health again!!!");
            return health;
        }
    }
}