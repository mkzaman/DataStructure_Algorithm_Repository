using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = new System.Diagnostics.Stopwatch();

            watch.Start();

            IFibonacci factorial = new ClassicRecursiveFibonacci();

            factorial.Fibonacci(30);

            watch.Stop();

            Console.WriteLine("Classic Recursive Fibonacci for n = 30 : " + watch.ElapsedTicks);

            watch.Reset();

            watch.Start();

            factorial = new MemoizedFibonacci();

            factorial.Fibonacci(30);

            watch.Stop();

            Console.WriteLine("Classic Memoized Fibonacci for n = 30 : " + watch.ElapsedTicks);

            watch.Reset();

            watch.Start();

            factorial = new BottomUpFibonacci();

            factorial.Fibonacci(30);

            watch.Stop();

            Console.WriteLine("Classic Bottom Up Fibonacci for n = 30 : " + watch.ElapsedTicks);

            watch.Reset();
        }
    }
}
