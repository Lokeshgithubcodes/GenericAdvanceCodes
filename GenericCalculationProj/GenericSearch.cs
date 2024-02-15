using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCalculationProj
{
    public static class GenericSearch
    {
        public static int Search<T>(List<T> list, Predicate<T> match)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (match(list[i]))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
