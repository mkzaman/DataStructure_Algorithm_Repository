using System;
using System.Collections.Generic;
using System.Text;

namespace Factorial
{
    class ClassicRecursiveFibonacci : IFibonacci
    {
        public UInt64 Factorial(UInt64 n)
        {
            if(n == 0 || n == 1)
            {
                return 1;
            }

            return Factorial(n - 1) + Factorial(n - 2);
        }
    }
}
