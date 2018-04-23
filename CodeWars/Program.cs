using System;
using System.Linq;

namespace CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[4] { 5, 3, 2, 8 };


            Console.WriteLine(sumTwoSmallestNumbers(numbers));
        }


        public static int sumTwoSmallestNumbers(int[] numbers) => numbers.OrderBy(i => i).Take(2).Sum();

        #region Another way of getting the two smallest numbers in an array of int[]
        //        {

        //            int smallest = int.MaxValue;
        //        int secondSmallest = int.MaxValue;

        //            foreach (int i in numbers)
        //            {
        //                if (i<smallest)
        //                {
        //                    secondSmallest = smallest;
        //                    smallest = i;
        //                }
        //                else if (i<secondSmallest)
        //                    secondSmallest = i;
        //            }

        //int sum = secondSmallest + smallest;

        //            return sum;
        //        }

        #endregion
    }
}
