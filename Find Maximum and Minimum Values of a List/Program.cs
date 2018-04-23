using System;
using System.Linq;

namespace Find_Maximum_and_Minimum_Values_of_a_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Max(new int[] { 4, 6, 2, 1, 9, 63, -134, 566 }));
            Console.WriteLine(Min(new int[] { -52, 56, 30, 29, -54, 0, -110 }));
            Console.WriteLine(Max(new int[] { 5 }));
            Console.WriteLine(Min(new int[] { 42, 54, 65, 87, 0 }));
        }

        public static int Min(int[] list)
        {
            int minNumber = list.Min();

            return minNumber;
        }

        public static int Max(int[] list)
        {
            int maxNumber = list.Max();

            return maxNumber;
        }
    }
}
