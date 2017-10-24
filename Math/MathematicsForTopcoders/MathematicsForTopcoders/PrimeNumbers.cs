using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicsForTopcoders
{
    public class PrimeNumbers
    {
        public bool NaiveIsPrime(int n)
        {
            for(int i=2; i<n; i++)
            {
                if(n%i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public bool IsPrime(int n)
        {
            if(n <= 1 || n%2 == 0)
            {
                return false; 
            }
            if(n==2)
            {
                return true;
            }
            int m = (int)Math.Sqrt(n);
            for(int i=3; i<=m; i +=2 )
            {
                if(n%i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public bool[] Seive(int n)
        {
            bool[] primeElements = Enumerable.Repeat(true, (n + 1)).ToArray();
            primeElements[0] = false;
            primeElements[1] = false;

            int m = (int)Math.Sqrt(n);
            for(int i = 2; i<=m; i++)
            {
                if(primeElements[i])
                {
                    for(int k = i*i; k<=n; k += i)
                    {
                        primeElements[k] = false; ;
                    }
                }
            }
            return primeElements;
        }
    }
}
