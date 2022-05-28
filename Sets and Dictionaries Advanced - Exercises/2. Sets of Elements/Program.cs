using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Sets_of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int lengthOne = size[0];
            int lengthTwo = size[1];
            HashSet<int> setOne = new HashSet<int>();
            HashSet<int> setTwo = new HashSet<int>();
            for (int i = 0; i < lengthOne; i++)
            {
                int num = int.Parse(Console.ReadLine());
                setOne.Add(num);
            }
            for (int i = 0; i < lengthTwo; i++)
            {
                int num = int.Parse(Console.ReadLine());
                setTwo.Add(num);
            }

            foreach (var num in setOne)           
                if (setTwo.Contains(num))              
                    Console.Write($"{num} ");                
          
        }
    }
}
