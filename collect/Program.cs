using System;
using System.Collections.Generic;

namespace collect
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nine = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string[] names = new string[] { "Tim", "Martrin", "Nikki", "Sara" };
            bool[] checkarray = new bool[10];
            for (int i = 0; i < checkarray.Length; i++)
            {
                if (i % 2 == 0)
                {
                    checkarray[i] = true;
                }
                else
                {
                    checkarray[i] = false;
                }
            }

            List<string> icecream = new List<string>();
            icecream.Add("Blueberry");
            icecream.Add("Chocolate");
            icecream.Add("Vanila");
            icecream.Add("redbean");
            icecream.Add("Nutela");

            Console.WriteLine(icecream.Count);
            Console.WriteLine(icecream[2]);

            //icecream.Remove("Vanila");
            Console.WriteLine(icecream.Count);

            Dictionary<string, string> mydict = new Dictionary<string, string>();
            foreach (var name in names)
            {
                mydict[name] = null;
            }

            Random flavor = new Random();
            foreach (var name in names)
            {
                mydict[name] = icecream[flavor.Next(icecream.Count)];
            }

            foreach (var entry in mydict)
            {
                Console.WriteLine(entry.Key + " - " + entry.Value);
            }
        }
    }
}
