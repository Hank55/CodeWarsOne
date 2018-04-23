using System;

namespace ReversedWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseWords("This is an example!"));  // returns  "sihT si na !elpmaxe"
            Console.WriteLine(ReverseWords("double  spaces"));  // returns  "elbuod  secaps"
        }

        public static string ReverseWords(string str)
        {

            string reversed = string.Empty;
            var stringSplit = str.Split(" ");


            foreach (var item in stringSplit)
            {

                for (int i = item.Length - 1; i >= 0; i--)
                {
                    reversed += item[i];
                }

                if (str.Length != reversed.Length)
                {

                    reversed += " ";
                }
                else
                {
                    return reversed;
                }
            }
            return reversed;
        }
    }
}
