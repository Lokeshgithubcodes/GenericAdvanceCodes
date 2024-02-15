using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCalculationProj
{
    public class GenericCalculator<T>
    {
        public T Add(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            return x + y;
        }

        public T Sub(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            return x - y;
        }
        public T Mul(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            return x * y;
        }
        public T Div(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            return x / y;
        }
    }
}
