using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicsForTopcoders
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.checkPrimeNumberFunctions();
            program.checkGCDAndLCMFunctions();
        }

        private void checkPrimeNumberFunctions()
        {
            PrimeNumbers primeNumbers = new PrimeNumbers();
            int x = 5;
            Console.WriteLine(x.ToString() + " is " + (primeNumbers.NaiveIsPrime(x) ? "prime" : "not prime"));
            x = 10;
            Console.WriteLine(x.ToString() + " is " + (primeNumbers.NaiveIsPrime(x) ? "prime" : "not prime"));
            x = 5;
            Console.WriteLine(x.ToString() + " is " + (primeNumbers.IsPrime(x) ? "prime" : "not prime"));
            x = 10;
            Console.WriteLine(x.ToString() + " is " + (primeNumbers.IsPrime(x) ? "prime" : "not prime"));
            x = 16;
            bool[] array = primeNumbers.Seive(x);
            Console.WriteLine("Prime numbers between 1 and " + x.ToString() + " : ");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i])
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }

        private void checkGCDAndLCMFunctions()
        {
            GCDandLCM gCDandLCM = new GCDandLCM();
            int a = 2336;
            int b = 1314;
            Console.WriteLine($"GCD of {a} and {b} is {gCDandLCM.NaiveGreatestCommongDivisor(a, b)}");
            a = 15;
            b = 125;
            Console.WriteLine($"GCD of {a} and {b} is {gCDandLCM.EuclidGreatestCommonDivisor(a, b)}");
            Console.WriteLine($"LCM of {a} and {b} is {gCDandLCM.LeastCommonMultiple(a, b)}");
            List<int> elements = new List<int>();
            elements.Add(2);
            elements.Add(3);
            elements.Add(12);
            Console.WriteLine($"GCD of the lists is {gCDandLCM.GCDOfListofIntergers(elements)}");
            Console.WriteLine($"LCM of the lists is {gCDandLCM.LCMOfListOfIntegers(elements)}");
        }

        private void checkGeometryFunctions()
        {
            //TODO
        }

        private void checkBasesFunctions()
        {
            //TODO
        }

        private void checkFrationsAndComplexNumberFunctions()
        {
            //TODO
        }
    }
}
