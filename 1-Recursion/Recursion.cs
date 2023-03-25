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

        public static int Fibonacci(int n, int type)
        {
            Console.WriteLine("|||||||||||");
            if (n < 0)
                return -1;

            if (n == 0 || n == 1)
                return n;

            Console.WriteLine(type + "-N-" + n);
            int a = Fibonacci(n - 1, 1);
            Console.WriteLine("A-" + a);
            Console.WriteLine("NN-" + n);
            int b = Fibonacci(n - 2, 2);
            Console.WriteLine("B-" + b);
            Console.WriteLine("NNN-" + n);
            int x = a + b;
            Console.WriteLine("X-" + x);
            Console.WriteLine("**********");
            Console.WriteLine();
            return x;
        }

        public static int SumOfDigit(int n)
        {
            Console.WriteLine("**********");
            if (n == 0 || n < 0) return 0;

            Console.WriteLine("N-" + n);
            int a = SumOfDigit(n / 10); // (739 / 10 = 73) | (739 % 10 = 9)
            Console.WriteLine("A-" + a);
            Console.WriteLine("NN-" + n);
            int b = n % 10;
            Console.WriteLine("B-" + b);
            int x = b + a;
            Console.WriteLine("X-" + x);
            
            Console.WriteLine("|||||||||||");
            return x;
        }

        public static int Power(int bas, int exp)
        {
            if(exp < 0) return -1;
            if(exp == 0) return 1;

            return bas * Power(bas, exp-1);
        }        
    }
}
