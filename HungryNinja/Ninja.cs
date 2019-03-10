using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class Ninja
    {
        private int calorieIntake;
        public List<Food> FoodHistory;

        // add a constructor
        public Ninja(){
            calorieIntake = 0;
            FoodHistory = new List<Food>();
        }

        public bool IsFull{
            get {
                if(calorieIntake <= 1200){
                    return false; 
                }
                else{
                    return true;
                }
            }
        }


        // add a public "getter" property called "IsFull"

        // build out the Eat method
        public void Eat(Food item)
        {
            if(this.IsFull== false){
                calorieIntake += item.Calories;
                FoodHistory.Add(item);
                Console.WriteLine(item.Name);
                if(item.isSpicy==true){
                    Console.WriteLine("This food is spicy");
                }
                if(item.isSweet==true){
                    Console.WriteLine("This food is sweet");
                }
            } 
            else{
                Console.WriteLine("Ninja full already, don't eat too much!!!");
            }
        }
    }

}