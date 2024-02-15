using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCalculationProj
{
    public class GenericStack<T> : IEnumerable<T>
    {
        private List<T> items = new List<T>();

        public void Push(T item)
        {
            items.Add(item);
        }

        public T Pop()
        {
            if (items.Count == 0)
            {
                Console.WriteLine("Stack is Empty");
                throw new Exception("Stack is Empty");

            }
            else
            {
                T poppedItem = items[items.Count - 1];
                items.RemoveAt(items.Count - 1);
                return poppedItem;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
