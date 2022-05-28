using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            HashSet<string> set = new HashSet<string>();
            for (int i = 0; i < count; i++)
            {
                string[] elements = Console.ReadLine().Split(" ");
                for (int k = 0; k < elements.Length; k++)
                {
                    set.Add(elements[k]);
                }
            }
            var sorted = set.OrderBy(x => x).ToList();
            Console.WriteLine(string.Join(" ", sorted));
        }
    }
}
