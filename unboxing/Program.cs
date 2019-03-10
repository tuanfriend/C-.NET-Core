using System;
using System.Collections.Generic;

namespace unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> unbox=new List<object>();
            unbox.Add(7);
            unbox.Add(28);
            unbox.Add(-1);
            unbox.Add(true);
            unbox.Add("chair");

            for(int i=0;i<unbox.Count;i++){
                Console.WriteLine(unbox[i]);
            }

            int sum=0;
            for(int j=0;j<unbox.Count;j++){
                if(unbox[j] is int){
                    int newnumber = (int)unbox[j];
                    sum += newnumber;

                }
                // int newnumber = unbox[j] as int;
                // sum = sum + newnumber;
            }
            System.Console.WriteLine(sum);
        }
    }
}
