using System;
using System.Collections.Generic;

namespace _06._Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            var wardrobe = new Dictionary<string, Dictionary<string, int>>();
            
            for (int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ");              
                string color = input[0];             
                string[] clothes = input[1].Split(",");

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                for (int k = 0; k < clothes.Length; k++)
                {
                    if (!wardrobe[color].ContainsKey(clothes[k]))
                    {
                        wardrobe[color].Add(clothes[k], 1);

                    }
                    else
                    {
                        wardrobe[color][clothes[k]]++;
                    }
                }

            }
            string[] wantedCloth = Console.ReadLine().Split(" ");
            foreach (var item in wardrobe)
            {
                Console.WriteLine($"{item.Key} clothes:");
                var clothes = item.Value;
                foreach (var cloth in clothes)
                {
                    if (cloth.Key == wantedCloth[1] && item.Key == wantedCloth[0])
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value}");

                    }
                }
            }


        }
    }
}
