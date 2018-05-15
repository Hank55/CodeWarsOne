using System;
using System.Linq;

namespace The_highest_profit_wins_
{
    class Program
    {
        //Write a function that returns both the minimum and maximum number of the given list/array.
        static void Main(string[] args)
        {
            var list = minMax(new int[] { 1, 2, 3, 4, 5 });

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }



            Console.WriteLine(minMax(new int[] { 2334454, 5 }));
            Console.WriteLine(minMax(new int[] { 1 }));
        }
        public static int[] minMax(int[] array)
        {

            var min = array.Min();
            var max = array.Max();

            var listMaxMin = new int[]{ min , max };


            return listMaxMin;
        }
    }
}
