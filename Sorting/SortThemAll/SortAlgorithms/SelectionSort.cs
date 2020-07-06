using System;
using System.Collections.Generic;
using System.Text;

namespace SortThemAll.SortAlgorithms
{
    public class SelectionSort : ISort
    {
        public void Sort<T>(List<T> sortable)
        {
            for(int i = 0; i < sortable.Count; i++)
            {
                for(int j = i+1; j<sortable.Count; j++)
                {
                    if (Comparer<T>.Default.Compare(sortable[i], sortable[j]) > 0)
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
