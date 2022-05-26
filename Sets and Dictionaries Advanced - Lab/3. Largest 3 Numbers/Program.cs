using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Largest_3_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();
                      
            int[] sorted = numbers.OrderByDescending(n => n).ToArray();
            
            if (sorted.Length >= 3)
            {
                for (int i = 0; i < 3; i++)               
                    Console.Write($"{sorted[i]} ");    
                
            }
            else
            {
                for (int i = 0; i < sorted.Length; i++)               
                    Console.Write($"{sorted[i]} ");
                
            }
        }
    }
}
