using System;
using System.Collections.Generic;

namespace testLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myBike = new List<string>();

            myBike.Add("Kawasaki");
            myBike.Add("Bmw");
            myBike.Add("SH");
            myBike.Add("Suzuki");

            Console.WriteLine(myBike[2]);
            Console.WriteLine($"I currently use {myBike[2]} ");
            Console.WriteLine($"I have total {myBike.Count} bikes in garage");

            Console.WriteLine("The current manufacturers we have seen are:");
            for (var idx = 0; idx < myBike.Count; idx++)
            {
                Console.WriteLine("-" + myBike[idx]);
            }
            // Insert a new item between a specific index
            myBike.Insert(2, "Yamaha");
            //Removal from Generic List
            //Remove is a lot like Javascript array pop, but searches for a specified value
            //In this case we are removing all manufacturers located in Japan
            myBike.Remove("Suzuki");
            myBike.Remove("Yamaha");
            myBike.RemoveAt(0); //RemoveAt has no return value however
                                //The updated list can then be iterated through using a foreach loop
            Console.WriteLine("List of Non-Japanese Manufacturers:");
            foreach (string manu in myBike)
            {
                Console.WriteLine("-" + manu);
            }

            Dictionary<string, string> profile = new Dictionary<string, string>();
            profile.Add("name", "Tom");
            profile.Add("age", "30");
            Console.WriteLine("My profile:");
            Console.WriteLine("My name is: " + profile["name"]);
            Console.WriteLine("my age is: " + profile["age"]);

            foreach (KeyValuePair<string, string> entry in profile)
            {
                Console.WriteLine(entry.Key + " - " + entry.Value);
            }

            foreach (var entry in profile)
            {
                Console.WriteLine(entry.Key + " - " + entry.Value);
            }
        }
    }
}
