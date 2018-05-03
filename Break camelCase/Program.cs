using System;
using System.Text.RegularExpressions;


namespace Break_camelCase
{    //Complete the solution so that the function will break up camel casing, using a space between words.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BreakCamelCase("camelCasing"));
        }

        public static string BreakCamelCase(string str)
        {
           return Regex.Replace(str, "([A-Z])", " $1");
        }
    }
}
