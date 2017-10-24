using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    public class Program
    {
        public static object BinarySearch<T>(List<T> arrayElements, T elementToFind, bool isPositionRequired)
        {
            int low, mid, high;
            low = 0;
            high = arrayElements.Count;
            object returnObject;
            while(low <= high)
            {
                mid = low + (high - low) / 2;
                if(EqualityComparer<T>.Default.Equals(arrayElements[mid], elementToFind))
                {
                    returnObject = isPositionRequired ? (object)mid : true;
                    return returnObject;
                }
            }
            returnObject = isPositionRequired ? (object)-1 : false;
            return returnObject;
        }

        static void Main(string[] args)
        {
            List<int> array = new List<int>();
            array.Add(2);
            array.Add(2);
            array.Sort();
            bool isSearchSuccess;
            int searchPosition;
            isSearchSuccess = (bool)BinarySearch(array, 2, false);
            searchPosition = (int)BinarySearch(array, 2, true);
        }
    }
}
