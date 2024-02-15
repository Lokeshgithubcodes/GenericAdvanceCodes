namespace GenericCalculationProj
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Generic Calculator
            Console.WriteLine("-------Int Generics");
            Console.WriteLine();
            GenericCalculator<int> intcalculator = new GenericCalculator<int>();
            Console.WriteLine("Addition: " + intcalculator.Add(7, 3));
            Console.WriteLine("Subtration: " + intcalculator.Sub(5, 3));
            Console.WriteLine("Multiplication: " + intcalculator.Mul(5, 5));
            Console.WriteLine("divison: " + intcalculator.Div(5, 25));
            Console.WriteLine();
            Console.WriteLine("------Double Generics");
            Console.WriteLine();
            GenericCalculator<double> d = new GenericCalculator<double>();
            Console.WriteLine("Addition: " + d.Add(7.3, 3.948));
            Console.WriteLine("Subtration: " + d.Sub(5.74, 3.74));
            Console.WriteLine("Multiplication: " + d.Mul(5.234, 5.637));
            Console.WriteLine("divison: " + d.Div(5.732, 25.74));

            // Generic Algorithm
           
            Console.WriteLine() ;

            //GenericSorting

            List<int> numbers = new List<int> { 3, 1, 4, 1, 5, 9, 2, 6 };
            GenericSort<int>.Sort(numbers, (a, b) => a.CompareTo(b));
            // after sorting numbers are
            Console.WriteLine("after sorting numbers are");
            foreach (int i in numbers)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();

            //searching an element in numbers
            Predicate<int> matchPredicate = x => x == 3;

            int index = GenericSearch.Search(numbers, matchPredicate);
            Console.WriteLine("The number 5 is found at index :" + index);

            //GenericFiltering
            List<int> evenNumbers = GenericFilter.Filter(numbers, x => x % 2 == 0);
            Console.WriteLine("Filtering even numbers");
            foreach (int i in evenNumbers)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();

           Console.WriteLine();

            //stack and dictionary

            Console.WriteLine("--------Generic Dictionary Implementation");
            GenericDictionary<string, int> dictionary = new GenericDictionary<string, int>();
            dictionary.Add("rock", 1);
            dictionary.Add("mike", 2);
            dictionary.Add("will", 3);
            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }


            // Stack LIFO
            Console.WriteLine("--------Generic Stack Implementation");
            GenericStack<int> stack = new GenericStack<int>();
            stack.Push(9);
            stack.Push(5);
            stack.Push(7);
            Console.WriteLine("Top Element in stack is " + stack.Pop());
            foreach (var item in stack)
            {
                Console.Write(item + " ");
            }

        }
    }
}
