using System;

namespace Is_n_divisible_by_x_and_y
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isDivisible(3, 1, 3));
            Console.WriteLine(isDivisible(12, 2, 6));
            Console.WriteLine(isDivisible(100, 5, 3));
            Console.WriteLine(isDivisible(12, 7, 5));


        }
        public static bool isDivisible(long n, long x, long y)
        {
            if (n % x == 0 && n % y == 0)
                return true;
            else
                return false;
        }
    }
}
