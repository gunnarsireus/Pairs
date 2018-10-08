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
            int n = int.Parse(inputArr[0]);
            int k = int.Parse(inputArr[1]);
            Console.Write("Input array: ");
            input = Console.ReadLine();
            var arr = input.Split(" ");
            int[] intArr= new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                intArr[i] = int.Parse(arr[i]);
            }

            Console.WriteLine("Number of Pairs: " + CountNumberOfPairsWithDiff(n, k, intArr));
            Console.ReadKey();
        }

        public static int CountNumberOfPairsWithDiff(int n, int k, int[] arr)
        {
            if (n != arr.Length)
            {
                Console.WriteLine("Array size error");
            }

            if (n < 2)
            {
                Console.WriteLine("Array too small, must be of size 2 or bigger!");
            }
            if (n > 100000)
            {
                Console.WriteLine("Array too big, must not be bigger than 100000!");
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

