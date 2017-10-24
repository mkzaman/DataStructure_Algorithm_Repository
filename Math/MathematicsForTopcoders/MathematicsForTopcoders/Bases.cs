using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicsForTopcoders
{
    public class Bases
    {
        /// <summary>
        /// 2<=b<10
        /// </summary>
        /// <param name="n"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int FrombBaseToDecimal(int n, int b)
        {
            int result = 0;
            int multiplier = 1;

            while(n > 0)
            {
                result += n % 10 * multiplier;
                multiplier *= b;
                n /= 10;
            }
            return result;
        }

        public int FromDecimaltobBase(int n, int b)
        {
            int result = 0;
            int multiplier = 1;

            while(n>10)
            {
                result += n % b * multiplier;
                multiplier *= 10;
                n /= b;
            }
            return result;
        }

        public string FromDecimaltobBaseRange10to20(int n, int b)
        {
            string chars = "0123456789ABCDEFGHIJ";
            string result = "";

            while(n>0)
            {
                result = chars.ElementAt(n % b) + result;
                n /= b;
            }
            return result;
        }
    }
}
