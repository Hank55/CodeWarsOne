using System;

namespace Round_to_the_next_multiple_of_5
{
    class Program
    {
        //Given an integer as input, can you round it to the next (meaning, "higher") 5?
        static void Main(string[] args)
        {

            //UseParams("HellO", 1, 'a');


            Console.WriteLine(RoundToNext5(2));
            Console.WriteLine(RoundToNext5(8));
            Console.WriteLine(RoundToNext5(-18));
        }

        //public static void UseParams(params object[] list)
        //{

        //    for (int i = 0; i < list.Length; i++)
        //    {
        //       Console.Write(list[i] + " ");
        //    }
        //    Console.WriteLine();

        //}


        public static int RoundToNext5(int n)
        {
            return (n % 5 == 0) ? n : RoundToNext5(n + 1);
        }
    }
}
