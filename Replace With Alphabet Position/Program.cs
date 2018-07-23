using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Replace_With_Alphabet_Position
{
    /*Welcome.
    In this kata you are required to, given a string, replace every letter with its position in the alphabet.
    If anything in the text isn't a letter, ignore it and don't return it.
    a being 1, b being 2, etc.
    As an example:*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AlphabetPosition("The sunset sets at twelve o' clock."));
            Console.WriteLine(AlphabetPosition("The narwhal bacons at midnight."));
        }


        public static string AlphabetPosition(string text)
        {
            var newText = Regex.Replace(text, "[^a-zA-Z0-9]", "");

            var charArray = newText.ToCharArray();

            List<int> vs = new List<int>();

            foreach (var item in charArray)
            {
                int index = char.ToUpper(item) - 64;//index == 1
                vs.Add(index);
            }

            string textString = string.Empty;
            foreach (var item in vs)
            {
                textString = textString + item.ToString()+ " ";
            }

            var result = textString.TrimEnd();

            return result;
        }
    }
}
