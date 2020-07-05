using System;
using System.Collections.Generic;
using System.Text;

namespace SortThemAll
{
    public interface ISort
    {
        void Sort<T>(List<T> sortable);
    }
}
