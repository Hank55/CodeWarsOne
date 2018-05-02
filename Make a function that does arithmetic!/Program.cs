using System;

namespace Make_a_function_that_does_arithmetic_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Arithmetic(5, 2, "add")); 
            Console.WriteLine(Arithmetic(5, 2, "subtract"));
            Console.WriteLine(Arithmetic(5, 2, "multiply"));
            Console.WriteLine(Arithmetic(5, 2, "divide"));
        }

        public static double Arithmetic(double a, double b, string op)
        {
            if (op == "add")
            {
                return a + b;
            }
            else if (op == "subtract")
            {
                return a - b;
            }
            else if (op == "multiply")
            {
                return a * b;
            }
            else
            {
                return a / b;
            }
        }
    }
}
