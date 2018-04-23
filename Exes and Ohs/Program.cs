using System;

namespace Exes_and_Ohs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(XO("ooxx")); 
            //Console.WriteLine(XO("xooxx"));
            Console.WriteLine(XO("ooxXm"));
            //Console.WriteLine(XO("zpzpzpp"));
            //Console.WriteLine(XO("zzoo"));
        }

        public static bool XO(string input)
            {
            string x = string.Empty;
            string o = string.Empty;
            string other = string.Empty;


            var inputLowerCase = input.ToLower();

            var charArray = inputLowerCase.ToCharArray();


            foreach (var item in charArray)
            {

                if (item.ToString() == "x")
                {
                    x = x + item;
                }
                else if (item.ToString() == "o")
                {
                    o = o + item;
                }
                else
                {
                    other = other + item;
                }
            }

            if (x.Length == o.Length)
                return true;
            else
                return false;
        }
    }
}
