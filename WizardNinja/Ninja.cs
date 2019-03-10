using System;

namespace WizardNinja
{
    class Ninja: Human
    {
        public Ninja(string name): base(name)
        {
            Dexter = 175;
        }
        //Provide an override Attack method to Ninja, 
        //which reduces the target by 5 * Dexerity and a 20% chance of dealing an additional 10 points of damage.
        public override int Attack(Human target){
            int dmg = 5 * Dexter;
            Random random=new Random();
            int rannum = random.Next(0,5);
            if(rannum == 0){
                dmg += 10;
            }
            base.Attack(target,dmg);
            return target.health;
        }

        public int steal(Human target){
            int dmg = 5;
            base.Attack(target,dmg);
            health += dmg;
            Console.WriteLine($"You are steal successful 5 point from {target.Name}");
            return target.health;
        }
    }
}