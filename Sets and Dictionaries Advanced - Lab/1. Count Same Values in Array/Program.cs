using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Count_Same_Values_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> nums = Console.ReadLine()
                .Split(" ")
                .Select(double.Parse)
                .ToList();

            Dictionary<double, int> counts = new Dictionary<double, int>();

            foreach (var num in nums)
            {
                if (counts.ContainsKey(num))
                {
                    counts[num]++;
                }
                else
                {
                    counts[num] = 1;
                }
            }
            foreach (var num in counts)
            {
                Console.WriteLine($"{num.Key} - {num.Value} times");
            }


        }
    }
}
