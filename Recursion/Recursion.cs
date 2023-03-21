using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Recursion
{
    internal static class Recursion
    {
        public static int Factorial(int n)
        {
            if (n < 0)
                return 0;

            if (n == 0 || n == 1)
                return 1;

            Console.WriteLine("N-" + n);
            int x = n * Factorial(n - 1);
            Console.WriteLine("-0-");
            Console.WriteLine("NN-" + n);
            Console.WriteLine("X-" + x);
            Console.WriteLine("---");
            return x;
        }

        public static int Fibonacci(int n)
        {
            if (n < 0)
                return -1;

            if (n == 0 || n == 1)
                return n;

            Console.WriteLine("N-" + n);
            int x = Fibonacci(n - 1) + Fibonacci(n - 2);
            Console.WriteLine("-0-");
            Console.WriteLine("NN-" + n);
            Console.WriteLine("X-" + x);
            Console.WriteLine("---");
            return x;
        }

        public static int SumOfDigit(int n)
        {
            if (n == 0 || n < 0)
                return 0;

            Console.WriteLine("N-" + n);
            int x = n % 10 + SumOfDigit(n / 10);
            Console.WriteLine("-0-");
            Console.WriteLine("NN-" + n);
            Console.WriteLine("X-" + x);
            Console.WriteLine("---");
            return x;
        }

    }
}
