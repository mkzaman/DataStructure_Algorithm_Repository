using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BinarySearch;
using System.Collections.Generic;

namespace BinarySearchTest
{
    [ ]
    public class BinarySearchTest
    {
        [TestMethod]
        public void IsSearchResultCorrect()
        {
            bool result;
            List<int> intList = new List<int>();
            intList.Add(1);
            intList.Add(4);
            intList.Add(3);
            intList.Add(5);
            intList.Add(2);
            //result = (bool)Program.BinarySearch(intList, 5, false);
            //Assert.Equals(result, true);
            result = (bool)Program.BinarySearch(intList, 8, false);
            Assert.AreEqual(result, true);
        }
    }
}
