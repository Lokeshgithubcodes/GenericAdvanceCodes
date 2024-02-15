using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCalculationProj
{
    public static class GenericSort<T>
    {
        public static void Sort(List<T> list, Comparison<T> comparison)
        {
            list.Sort(comparison);
        }
    }
}
