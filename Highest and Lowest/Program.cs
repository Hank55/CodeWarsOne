using System;
using System.Linq;

namespace Highest_and_Lowest
{
    class Program
    {
        //In this little assignment you are given a string of space separated numbers, and have to return the highest and lowest number.
        static void Main(string[] args)
        {
            Console.WriteLine(HighAndLow("1 2 3 4 5") ); 
            Console.WriteLine(HighAndLow("1 2 -3 4 5"));  
            Console.WriteLine(HighAndLow("1 9 3 4 -5"));
        }

        public static string HighAndLow(string numbers)
        {
            var numbersList = numbers.Split(' ').Select(x => Convert.ToInt32(x));

            return $"{numbersList.Max()} {numbersList.Min()}";
        }
    }
}
