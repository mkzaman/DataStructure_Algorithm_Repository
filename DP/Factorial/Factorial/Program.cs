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

            factorial.Factorial(50);

            watch.Stop();

            Console.WriteLine("Classic Recursive Factorial for n = 30 : " + watch.ElapsedTicks);

            watch.Reset();

            watch.Start();

            factorial = new MemoizedFibonacci();

            factorial.Factorial(50);

            watch.Stop();

            Console.WriteLine("Classic Memoized Factorial for n = 30 : " + watch.ElapsedTicks);

            watch.Reset();

            watch.Start();

            factorial = new BottomUpFibonacci();

            factorial.Factorial(50);

            watch.Stop();

            Console.WriteLine("Classic Bottom Up Factorial for n = 30 : " + watch.ElapsedTicks);

            watch.Reset();
        }
    }
}
