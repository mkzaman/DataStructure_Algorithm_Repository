using System;
using System.Collections.Generic;
using System.Text;

namespace Factorial
{
    class ClassicRecursiveFibonacci : IFibonacci
    {
        public UInt64 Fibonacci(UInt64 n)
        {
            if(n == 0 || n == 1)
            {
                return 1;
            }

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
