using System;
using System.Collections.Generic;
using System.Text;

namespace SortThemAll.SortAlgorithms
{
    public class MergeSort : ISort
    {
        public void Sort<T>(List<T> sortable)
        {
            MergeSortImplementation(sortable, 0, sortable.Count-1);
        }

        private void MergeSortImplementation<T>(List<T> sortable, int low, int high)
        {
            if (low == high)
            {
                return;
            }

            int mid = (low + high) / 2;

            MergeSortImplementation(sortable, low, mid);
            MergeSortImplementation(sortable, mid + 1, high);

            Merge(sortable, low, mid, high);
        }

        private void Merge<T>(List<T> sortable, int low, int mid, int high)
        {
            T[] arr = new T[high - low + 1];

            int i=low, j = mid+1;

            for (int k =0; k < arr.Length; k++)
            {
                if (i > mid)
                {
                    arr[k] = sortable[j++];
                }
                else if (j > high)
                {
                    arr[k] = sortable[i++];
                }
                else if (Comparer<T>.Default.Compare(sortable[i], sortable[j]) < 0)
                {
                    arr[k] = sortable[i++];
                }
                else
                {
                    arr[k] = sortable[j++];
                }
            }

            for (int x = low, y =0; x <= high; x++, y++)
            {
                sortable[x] = arr[y];
            }
        }
    }
}
