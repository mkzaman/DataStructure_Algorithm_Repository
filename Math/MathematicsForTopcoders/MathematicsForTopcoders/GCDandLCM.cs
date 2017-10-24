using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicsForTopcoders
{
    public class GCDandLCM
    {
        public int NaiveGreatestCommongDivisor(int a, int b)
        {
            for (int i = Math.Min(a, b); i >= 1; i--)
            {
                if (a % i == 0 && b % i == 0)
                {
                    return i;
                }
            }
            return 1;
        }

        //assuming a and b both can't be 0
        public int EuclidGreatestCommonDivisor(int a, int b)
        {
            if(b == 0)
            {
                return a;
            }
            return EuclidGreatestCommonDivisor(b, a % b);
        }

        public int LeastCommonMultiple(int a, int b)
        {
            return (a * b) / EuclidGreatestCommonDivisor(a, b);
        }

        public int GCDOfListofIntergers(List<int> elements)
        {
            int ans = elements[0];
            for(int i=1; i<elements.Count-1; i++)
            {
                ans = EuclidGreatestCommonDivisor(ans, elements[i]);
            }
            return ans;
        }

        public int LCMOfListOfIntegers(List<int> elements)
        {
            int ans = elements[0];
            for(int i=1; i<elements.Count; i++)
            {
                ans = (ans * elements[i]) / (EuclidGreatestCommonDivisor(ans, elements[i]));
            }
            return ans;
        }

        private int x;
        private int y;
        private int gcd;

        public int X
        {
            get
            {
                return x;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }
        }

        public int GCD
        {
            get
            {
                return gcd;
            }
        }

        public void ExtendedEuclideanMethod(int a, int b)
        {
            if(b == 0)
            {
                x = 0;
                y = 1;
                gcd = a;
                return;
            }
            ExtendedEuclideanMethod(b, a % b);
            int x1 = y;
            int y1 = x - (a / b) * y;
            x = x1;
            y = y1;
        }

        public List<int> LinearDiophantineEquationSolutionForN(int a, int b, int x0, int y0, int gcd, int n)
        {
            List<int> resultElements = new List<int>();
            resultElements.Add(x0 + (b / gcd) * n);
            resultElements.Add(y0 - (a / gcd) * n);
            return resultElements;
        }
    }
}
