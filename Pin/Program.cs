using System;

namespace Pin
{
    class Program
    {
        static void Main(string[] args)
        {


            while (true)
            {
                Console.WriteLine("Enter pin");
                string pin = Console.ReadLine();
                Console.WriteLine("----------");
                if (ValidatePin(pin))
                {
                    Console.WriteLine("Valied!");
                    Console.WriteLine("----------");
                }

                else
                {
                    Console.WriteLine("Invalid");
                    Console.WriteLine("----------");
                }

            }
        }

        public static bool ValidatePin(string pin)
        {
            if (pin.Length == 4 || pin.Length == 6)
            {
                try
                {
                    var s = int.Parse(pin);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
                return false;
        }
    }
}
