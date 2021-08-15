using System;
using System.Collections.Generic;
using System.Text;

namespace Factorial
{
    public class MemoizedFibonacci : IFibonacci
    {
        Dictionary<UInt64, UInt64> fibonacciMemoization = new Dictionary<UInt64, UInt64>();
        public UInt64 Fibonacci(UInt64 n)
        {
            if(n == 0 || n == 1)
            {
                return 1;
            }

            if(fibonacciMemoization.ContainsKey(n))
            {
                return fibonacciMemoization[n];
            }

            UInt64 temp = Fibonacci(n - 1) + Fibonacci(n - 2);

            fibonacciMemoization.Add(n, temp);

            return temp;
        }
    }
}
