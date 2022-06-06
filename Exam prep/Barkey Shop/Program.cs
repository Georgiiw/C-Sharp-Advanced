using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Bakery_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] water = Console.ReadLine()
                .Split(" ")
                .Select(double.Parse)
                .ToArray();

            double[] flour = Console.ReadLine()
            .Split(" ")
            .Select(double.Parse)
            .ToArray();
            Queue<double> waterCount = new Queue<double>(water);
            Stack<double> flourCount = new Stack<double>(flour);

            Dictionary<string, int> bakeryResult = new Dictionary<string, int>
            {
                {"Croissant", 0 },
                {"Muffin", 0 },
                {"Baguette", 0 },
                {"Bagel", 0 }
            };

            while (waterCount.Any() && flourCount.Any())
            {
                double currWater = waterCount.Peek();
                double currFlour = flourCount.Peek();
                if (Croissant(currFlour, currWater))
                {
                    bakeryResult["Croissant"]++;
                    flourCount.Pop();
                    waterCount.Dequeue();
                }
                else if (Muffin(currFlour, currWater))
                {
                    bakeryResult["Muffin"]++;
                    flourCount.Pop();
                    waterCount.Dequeue();
                }
                else if (Baguette(currFlour, currWater))
                {
                    bakeryResult["Baguette"]++;
                    flourCount.Pop();
                    waterCount.Dequeue();
                }
                else if (Bagel(currFlour, currWater))
                {
                    bakeryResult["Bagel"]++;
                    flourCount.Pop();
                    waterCount.Dequeue();
                }
                else
                {
                    double currentFlour = flourCount.Pop();
                    double currentWater = waterCount.Dequeue();
                    double flourReduced = currFlour - currWater;
                    bakeryResult["Croissant"]++;
                    flourCount.Push(flourReduced);
                }

            }
            foreach (var item in bakeryResult.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                if (item.Value > 0)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }
            if (waterCount.Count > 0)
            {
                Console.WriteLine($"Water left: {string.Join(", ", waterCount)}");
            }
            else
            {
                Console.WriteLine($"Water left: None");
            }

            if (flourCount.Count > 0)
            {
                Console.WriteLine($"Flour left: {string.Join(", ", flourCount)}");
            }
            else
            {
                Console.WriteLine($"Flour left: None");
            }


        }
        public static double[] Percentage(double flour, double water)
        {
            double[] percentage = new double[2];
            double result = flour + water;
            percentage[0] = (flour / result) * 100;
            percentage[1] = (water / result) * 100;

            return percentage;
        }

        public static bool Croissant(double flour, double water)
        {
            double[] arr = Percentage(flour, water);
            if (arr[0] == 50 && arr[1] == 50)
            {
                return true;
            }
            return false;
        }
        public static bool Muffin(double flour, double water)
        {
            double[] arr = Percentage(flour, water);
            if (arr[0] == 60 && arr[1] == 40)
            {
                return true;
            }
            return false;
        }
        public static bool Baguette(double flour, double water)
        {
            double[] arr = Percentage(flour, water);
            if (arr[0] == 70 && arr[1] == 30)
            {
                return true;
            }
            return false;
        }
        public static bool Bagel(double flour, double water)
        {
            double[] arr = Percentage(flour, water);
            if (arr[0] == 80 && arr[1] == 20)
            {
                return true;
            }
            return false;
        }

    }
}
