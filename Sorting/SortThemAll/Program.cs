using SortThemAll.SortAlgorithms;
using System;
using System.Collections.Generic;

namespace SortThemAll
{
    class Program
    {
        static void Main(string[] args) 
        {
            ISort sort = new BubbleSort();
            List<int> x = new List<int>{ 5, 8, 6, 1, 7, 9 };
            sort.Sort(x);
            for(int i=0; i<x.Count; i++)
            {
                Console.WriteLine(x[i]);
            }
        }
    }
}
