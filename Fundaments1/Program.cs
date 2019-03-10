using System;

namespace Fundaments1
{
    class Program
    {
        static void Main(string[] args)
        {
            //PRINT VALUES FROM 1 TO 255
            // for(int i=1; i<=255;i++){
            //     Console.WriteLine(i);
            // }
            //PRINT VALUE DIVISBLE BY 3 OR 5 NOT BOTH
            // for(int i=1;i<=100;i++){
            //     if(i%3==0 && i%5==0){

            //     }
            //     else if(i%3==0 || i%5==0){
            //         Console.WriteLine(i);
            //     }
            // }
            //Fizz" for multiples of 3, "Buzz" for multiples of 5
            // for(int i=1;i<=100;i++){
            //     if(i%3==0 && i%5==0){
            //     Console.WriteLine("FizzBuzz");
            //     }
            //     else if(i%3==0){
            //         Console.WriteLine("Fizz");
            //     }
            //     else if(i%5==0){
            //         Console.WriteLine("Buzz");
            //     }
            // }
            //While loop
            int i = 1;
            while (i <= 100)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                i++;
            }



        }
    }
}
