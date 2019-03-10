using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class Food
    {
        public string Name;
        public int Calories;
        public bool isSpicy;
        public bool isSweet;

        public Food(string name,int calo,bool spicy,bool sweet){
            Name = name;
            Calories = calo;
            isSpicy = spicy;
            isSweet = sweet;
        }
    }

}