using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Product_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> dic = new Dictionary<string, Dictionary<string, double>>();
            while (true)
            {
                string[] info = Console.ReadLine()
                    .Split(", ")
                    .ToArray();
                if (info[0] == "Revision")               
                    break;            
                
                string shop = info[0];
                string product = info[1];
                double price = double.Parse(info[2]);

                if (!dic.ContainsKey(shop))
                {
                    dic.Add(shop, new Dictionary<string, double>());
                }

                dic[shop].Add(product, price);


            }
                var orderd = dic.OrderBy(s => s.Key)
                    .ToDictionary(x => x.Key, x => x.Value);

            foreach (var shop in orderd)
            {
                Console.WriteLine($"{shop.Key}->");
                var products = shop.Value;
                foreach (var item in products)                
                    Console.WriteLine($"Product: {item.Key}, Price: {item.Value}");
                
            }
        }
    }
}
