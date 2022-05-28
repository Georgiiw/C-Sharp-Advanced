using System;
using System.Collections.Generic;

namespace _06._Record_Unique_Names
{
    internal class Program
    {
        static void Main()
        {
            HashSet<string> names = new HashSet<string>();
            int namesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < namesCount; i++)
            {
                string newName = Console.ReadLine();
                
                    names.Add(newName);

            }
            Console.WriteLine(string.Join("\r\n", names));
        }
    }
}
