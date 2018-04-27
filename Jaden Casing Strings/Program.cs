using System;
using System.Globalization;

namespace Jaden_Casing_Strings
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ToJadenCase("how can mirrors be real if our eyes aren't real"));
        }


        public static string ToJadenCase(this string phrase)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(phrase);
        }
    }
}
