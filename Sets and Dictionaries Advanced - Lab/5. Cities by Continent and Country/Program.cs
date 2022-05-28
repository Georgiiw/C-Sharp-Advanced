using System;
using System.Collections.Generic;

namespace _5._Cities_by_Continent_and_Country
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>>
                map = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < count; i++)
            {
                string[] locations = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);    
                string continent = locations[0];
                string country = locations[1];
                string city = locations[2];
                if (!map.ContainsKey(continent))
                {
                    map.Add(continent, new Dictionary<string, List<string>>());
                }
                if (!map[continent].ContainsKey(country))
                {
                    map[continent].Add(country, new List<string>());
                    map[continent][country].Add(city);

                }
                else
                {
                    map[continent][country].Add(city);

                }
            }

            foreach (var continent in map)
            {
                Console.WriteLine($"{continent.Key}:");
                var countrys = continent.Value;
                foreach (var country in countrys)
                {
                    string cities = (string.Join(", ", country.Value));
                    Console.WriteLine($"{country.Key} -> {cities}");
                }
            }
        }
    }
}
