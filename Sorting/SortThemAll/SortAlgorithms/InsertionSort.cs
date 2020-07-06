using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace SortThemAll.SortAlgorithms
{
    public class InsertionSort : ISort
    {
        public void Sort<T>(List<T> sortable)
        {
            for(int i=0; i<sortable.Count; i++)
            {
                T current = sortable[i];
                int currentPosition = i;
                for(int j=i-1; j>=0; j--)
                {
                    if (Comparer<T>.Default.Compare(current, sortable[j]) < 0)
                    {
                        sortable[currentPosition] = sortable[j];
                        sortable[j] = current;
                        currentPosition = j;
                    }
                }
            }
        }
    }
}
