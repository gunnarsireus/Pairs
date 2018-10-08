using System;
using System.Collections.Generic;
using System.Linq;

namespace Pairs
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input;
            Console.Write("Input n and k: ");
            input =  Console.ReadLine();
            var inputArr = input.Split(" ");
            int n;
            if (!int.TryParse(inputArr[0], out n))
            {
                Console.WriteLine("Input Error!");
                Console.ReadKey();
                return;
            }
            int k;
            if (!int.TryParse(inputArr[1], out k))
            {
                Console.WriteLine("Input Error!");
                Console.ReadKey();
                return;
            }
            Console.Write("Input array: ");
            input = Console.ReadLine();
            var arr = input.Split(" ");
            int[] intArr= new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                if (!int.TryParse(arr[i], out intArr[i]))
                {
                    Console.WriteLine("Input Error!");
                    Console.ReadKey();
                    return;
                }
            }

            Console.WriteLine("Number of Pairs: " + CountNumberOfPairsWithDiff(n, k, intArr));
            Console.ReadKey();
        }

        public static int CountNumberOfPairsWithDiff(int n, int k, int[] arr)
        {
            if (n != arr.Length)
            {
                Console.WriteLine("Array size error");
                Console.ReadKey();
                return -1;
            }

            if (n < 2)
            {
                Console.WriteLine("Array too small, must be of size 2 or bigger!");
                Console.ReadKey();
                return -1;
            }
            if (n > 100000)
            {
                Console.WriteLine("Array too big, must not be bigger than 100000!");
                Console.ReadKey();
                return -1;
            }
            var diff = arr.Max() - arr.Min();
            if (arr.Max() - arr.Min() < k)
            {
                Console.WriteLine("No pair found! ");
            }
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

