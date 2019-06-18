using System;

/** Playing with Delegates */
// Sean Phillips 6/17/2019

namespace DelegateExample
{

    class MathOperations
    {
        public static double MultiplyByTwo(double value) => value * 2;
        public static double Square(double value) => value * value;
    }

    delegate double DoubleOp(double x);
    class Program
    {
        static void Main()
        {
            DoubleOp[] operations =
            {
                MathOperations.MultiplyByTwo,
                MathOperations.Square
            };

            for( int i = 0; i < operations.Length; i++)
            {
                Console.WriteLine($"Using operations[{i}] :");
                ProcessAndDisplayNumber(operations[i], 2.0);
                ProcessAndDisplayNumber(operations[i], 7.94);
                ProcessAndDisplayNumber(operations[i], 1.414);
                Console.WriteLine();
                
            }
            Console.ReadLine();
        }

        static void ProcessAndDisplayNumber(DoubleOp action, double value)
        {
            double result = action(value);
            Console.WriteLine($"Value is {value}, result of operation is {result}");
        }
    }
}
