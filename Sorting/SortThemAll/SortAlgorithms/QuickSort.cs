using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortThemAll.SortAlgorithms
{
    public class QuickSort : ISort
    {
        public void Sort<T>(List<T> sortable)
        {
            sortable = QuickSortImplementation(sortable.ToArray()).ToList();
        }

        private T[] QuickSortImplementation<T>(T[] arr)
        {
            if(arr.Length < 2)
            {
                return new T[0];
            }
            int pivot = 
        }


    }
}
