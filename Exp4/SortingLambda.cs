using System;
using System.Collections.Generic;
using System.Text;

namespace Exp4
{
    public class SortingLambda
    {
        public static void sortList()
        {
            List<int> numbers = new List<int> {20,40,10,5,7,59,57,90,39};

            numbers.Sort((prev, next) => prev.CompareTo(next));
            Console.WriteLine("Aescending Order : ");
            Console.WriteLine(string.Join(",", numbers));

            numbers.Sort((prev, next) => next.CompareTo(prev));
            Console.WriteLine("Descending Order : ");
            Console.WriteLine(string.Join(",", numbers));

        }
    }
}
