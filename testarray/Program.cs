using System;

namespace testarray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray=new int[5];
            int[] numArray2 = {1,2,3,4,5};
            int[] array3;
            array3 = new int[] {1,2,3,4};
            // Console.WriteLine($"Hello number {array3[2]} " + numArray2[1]);
            string[] mycar=new string[] {"Honda","BMW","Lexus"};
            // for(int i=0;i<mycar.Length; i++){
            //     Console.WriteLine($"I have owned this kind of car {mycar[i]}");
            // }
            foreach(string car in mycar){
                Console.WriteLine($"I have own this car {car}");
            }
        }
    }
}
