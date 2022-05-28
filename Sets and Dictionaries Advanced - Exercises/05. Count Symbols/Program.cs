using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Count_Symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine();
            SortedDictionary<char, int> symbols = new SortedDictionary<char, int>();

            for (int i = 0; i < sentence.Length; i++)
            {
                char ch = sentence[i];
                if (!symbols.ContainsKey(ch))                
                    symbols.Add(sentence[i], 1);        
            
                else               
                    symbols[ch]++;


            }
           
            foreach (var ch in symbols)
                Console.WriteLine($"{ch.Key}: {ch.Value} time/s");
         
        }
    }
}
