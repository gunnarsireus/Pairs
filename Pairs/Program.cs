using System;
using System.Linq;

namespace Pairs
{
    public class Program
    {
        static void Main(string[] args)
        {
            CountNumberOfPairsWithDiff(5, 2, new[] { 1, 5, 3, 4, 2 });
            Console.ReadKey();
        }

        public static int CountNumberOfPairsWithDiff(int n, int k, int[] arr)
        {
            var numbers = arr.OrderBy(o => o).Select((value) => new { value });

            var pairs = from num1 in numbers
                        from num2 in numbers
                        where num1.value - num2.value == k
                        select new[]
                    {
            num1.value, // first number in the pair
            num2.value, // second number in the pair
        };

            foreach (var pair in pairs)
            {
                Console.WriteLine("Pair found: " + pair[0] + ", " + pair[1]);
            }

            return pairs.Count();
        }
    }
}

