using System;

namespace basic13
{
    class Program
    {

        public static void PrintNumbers(){
            for(int i=1;i<=255;i++){
                Console.WriteLine(i);
            }
        }

        public static void PrintOdds(){
            for(int i=1;i<=255;i+=2){
                Console.WriteLine(i);
            }
        }

        public static void PrintSum(){
            int sum=0;
            for(int i=0;i<=255;i++){
                sum = sum+i;
                Console.WriteLine($"New number: {i} Sum: {sum}");
            }
        }

        public static void LoopArray(int[] numbers){
            foreach(int each in numbers){
                Console.WriteLine(each);
            }
        }

        public static int FindMax(int[] numbers){
            int max=numbers[0];
            foreach(int each in numbers){
                if(max<each){
                    max=each;
                }
            }
            return max;
        }

        public static double Average(int[] numbers){
            int sum=0;
            double avg;
            for(int i=0;i<numbers.Length;i++){
                sum += numbers[i];
            }
            avg = (double)sum/numbers.Length;
            return avg;
        }

        public static int[] OddArray(){
            int[] array=new int[128];
            int idx = 0;
            for(int i=1;i<=255;i+=2){
                array[idx]=i;
                idx++;
            }
            Console.WriteLine(array);
            return array;
        }

        public static int GreaterThanY(int[] arr, int y){
            int count=0;
            foreach(int num in arr){
                if(num>y){
                    count++;
                }
            }
            return count;
        }

        public static void SquareValues(int[] arr){
            foreach(int num in arr){
                num *= num;
            }
            Console.WriteLine(arr);
        }
        static void Main(string[] args)
        {
            int[] num=new int[] {1,2,3,5};
            // Console.WriteLine(Average(num));
            // Console.WriteLine(OddArray());
            // Console.WriteLine(GreaterThanY(num,2));
            Console.WriteLine("[{0}]", string.Join(", ", OddArray()));
        }
    }
}
