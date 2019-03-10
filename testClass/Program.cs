using System;

namespace testClass
{
    // class Vehicle{

    //     private int MaxnumPass;
    //     private string color;
    //      public Vehicle(int maxnum, string col){
    //         MaxnumPass = maxnum;
    //         color = col;
    //     }
    //     public int maxNumpass{
    //         get{ return MaxnumPass; }
    //     }
    //     public string COLOR{
    //         get{ return color; }
    //     }
       
    // }
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle a = new Vehicle(5, "Green");
            a.fixcar(5,"blah");
            Console.WriteLine(a.maxNumpass);
            Console.WriteLine(a.COLOR);
        }
    }
}
