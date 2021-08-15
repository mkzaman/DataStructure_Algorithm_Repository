using System;
using System.Collections.Generic;
using System.Text;

namespace Factorial
{
    class BottomUpFibonacci : IFibonacci
    {
        public ulong Factorial(ulong n)
        {
            ulong a = 1, b = 1;

            for(ulong i =2; i<=n; i++)
            {
                ulong temp = a;
                a = b;
                b = temp + b;
            }

            return b;
        }
    }
}
