using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = new System.Diagnostics.Stopwatch();

            watch.Start();

            IFactorial factorial = new ClassicRecursiveFactorial();

            factorial.Factorial(50);

            watch.Stop();

            Console.WriteLine("Classic Recursive Factorial for n = 30 : " + watch.ElapsedTicks);

            watch.Reset();

            watch.Start();

            factorial = new MemoizedFactorial();

            factorial.Factorial(50);

            watch.Stop();

            Console.WriteLine("Classic Memoized Factorial for n = 30 : " + watch.ElapsedTicks);

            watch.Reset();

            watch.Start();

            factorial = new BottomUpFactorial();

            factorial.Factorial(50);

            watch.Stop();

            Console.WriteLine("Classic Bottom Up Factorial for n = 30 : " + watch.ElapsedTicks);

            watch.Reset();
        }
    }
}
