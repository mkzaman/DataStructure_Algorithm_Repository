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
                for(int j=i; j>=0; j--)
                {
                    if (Comparer<T>.Default.Compare(sortable[i], sortable[j]) < 0)
                    {
                        T temp = sortable[i];
                        sortable[i] = sortable[j];
                        sortable[j] = temp;
                    }
                }
            }
        }
    }
}
