using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class Buffet
    {
        public List<Food> Menu;
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Hotdog", 1000, false, false),
                new Food("Pizza", 2000, true, false),
                new Food("Pho", 1500, true, true),
                new Food("Burger", 3000, true, false),
                new Food("DogMeat", 800, true, false),
                new Food("CatMeat", 900, false, true),
                new Food("Soup", 950, true, true)
            };
        }

        public Food Serve()
        {
            Random rand = new Random();
            return Menu[rand.Next(Menu.Count)];
        }

    }
}