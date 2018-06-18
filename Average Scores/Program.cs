using System;
using System.Linq;

namespace Average_Scores
{
    class Program
    {
        static void Main(string[] args)
        {
            var scores = new int[] { 49, 3, 5, 300, 7 };
            Console.WriteLine(Average(scores));
        }


        public static int Average(int[] scores)
        {
            var result = scores.Sum();
            var result1 = ((decimal)result / (decimal)scores.Length);
            Math.Round(result1);

            var result2 = Convert.ToInt32(result1);

            return result2;
        }
    }
}
