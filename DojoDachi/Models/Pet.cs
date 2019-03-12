using System;

namespace DojoDachi.Models
{
    public class Pet
    {
       public int Fullness {get; set;}
       public int Happiness {get; set;}
       public int Meals {get; set;}
       public int Energy {get; set;}

       public Pet(){
           Fullness = 20;
           Happiness = 20;
           Meals = 3;
           Energy = 50;

       }

       public int Feed(){
           if(Meals == 0){
               return Fullness;
           }
           else{
               Meals = Meals - 1;
               Random rand=new Random();
               Fullness = Fullness + rand.Next(5,10);
               return Fullness;
           }
       }

    }
}