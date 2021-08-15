using System;
using System.Collections.Generic;
using System.Text;

namespace Factorial
{
    public class MemoizedFactorial : IFactorial
    {
        Dictionary<UInt64, UInt64> factorialMemoization = new Dictionary<UInt64, UInt64>();
        public UInt64 Factorial(UInt64 n)
        {
            if(n == 0 || n == 1)
            {
                return 1;
            }

            if(factorialMemoization.ContainsKey(n))
            {
                return factorialMemoization[n];
            }

            UInt64 temp = Factorial(n - 1) + Factorial(n - 2);

            factorialMemoization.Add(n, temp);

            return temp;
        }
    }
}
