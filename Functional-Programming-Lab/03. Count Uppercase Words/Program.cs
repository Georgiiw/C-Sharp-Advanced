using System;
using System.Linq;

namespace _03._Count_Uppercase_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> func = n => n[0] == n.ToUpper()[0];
            string[] text = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(n => func(n))
                .ToArray();

            foreach (var word in text)           
                Console.WriteLine(word);
            
        }
    }
}
