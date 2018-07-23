using System;
using System.Linq;

namespace Summing_a_number_s_digits
{
    //Write a function named sumDigits which takes a number as input and returns the sum of the absolute value of each of the number's decimal digits
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumDigits(-12));
        }


        public static int SumDigits(int number)
        {
            var numbers = Math.Abs(number);

            var sum = 0;

            int[] outarry = Array.ConvertAll(numbers.ToString().ToArray(), x => (int)x - 48);

            foreach (var item in outarry)
            {
                sum = sum + item;
            }

            return sum;
        }
    }
}
