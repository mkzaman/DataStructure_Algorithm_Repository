using System;
using System.Collections.Generic;
using System.Text;

namespace SortThemAll.SortAlgorithms
{
    public class BubbleSort : ISort
    {
        public void Sort<T>(List<T> sortable)
        {
            for(int i=0; i < sortable.Count; i++)
            {
                for(int j=0; j < sortable.Count - 1; j++)
                {
                    if(Comparer<T>.Default.Compare(sortable[j], sortable[j+1]) > 0)
                    {
                        T temp = sortable[j];
                        sortable[j] = sortable[j+1];
                        sortable[j+1] = temp;
                    }
                }
            }
        }
    }
}
