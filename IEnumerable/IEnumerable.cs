/* WHAT: IEnumerable allows sequential iteration over a collection
WHY: It enables lazy execution, flexibility, and LINQ support */

using System;
using System.Collections.Generic;

namespace IEnumerableDemo
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            IEnumerable<int> evenNumbers = GetEvenNumbers(numbers);

            Console.WriteLine("Even numbers:");

            foreach (int num in evenNumbers)
            {
                Console.WriteLine(num);
            }
        }

        static IEnumerable<int> GetEvenNumbers(IEnumerable<int> numbers)
        {
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    yield return number;
                }
            }
        }
    }
}
