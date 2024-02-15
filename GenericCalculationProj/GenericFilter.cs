using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCalculationProj
{
    public static class GenericFilter
    {
        public static List<T> Filter<T>(List<T> l, Predicate<T> match)
        {
            List<T> filteredList = new List<T>();
            foreach (T item in l)
            {
                if (match(item))
                {
                    filteredList.Add(item);
                }
            }
            return filteredList;
        }
    }
}
