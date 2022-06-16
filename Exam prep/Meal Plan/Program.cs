using System;
using System.Collections.Generic;
using System.Linq;

namespace Meal_Plan
{
    internal class Program
    {
        static void Main()
        {
            const int salad = 350;
            const int soup = 490;
            const int pasta = 680;
            const int steak = 790;

            string[] meals = Console.ReadLine().Split(" ");
            int[] calories = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            Queue<string> mealsQue = new Queue<string>();
            Stack<int> calsStack = new Stack<int>();
            foreach (var meal in meals)
                mealsQue.Enqueue(meal);

            foreach (var cals in calories)
                calsStack.Push(cals);
            int currCals = 0;
            int leftCals = 0;
            int eatenMeals = 0;
            while (mealsQue.Any())
            {
                if (calsStack.Count == 0)
                {
                    break;
                }
                if (mealsQue.Peek() == "salad")
                {
                    eatenMeals++;
                    currCals = calsStack.Pop();
                    currCals -= salad;
                    mealsQue.Dequeue();
                    if (currCals < 0 && calsStack.Any())
                    {
                        leftCals = Math.Abs(currCals);
                        currCals = calsStack.Pop();
                        currCals -= leftCals;
                        calsStack.Push(currCals);
                        continue;
                    }
                    else if (currCals > 0)
                    {
                        calsStack.Push(currCals);

                    }
                }
                else if (mealsQue.Peek() == "soup")
                {
                    eatenMeals++;
                    currCals = calsStack.Pop();
                    currCals -= soup;
                    mealsQue.Dequeue();
                    if (currCals < 0 && calsStack.Any())
                    {
                        leftCals = Math.Abs(currCals);
                        currCals = calsStack.Pop();
                        currCals -= leftCals;
                        calsStack.Push(currCals);
                        continue;
                    }
                    else if (currCals > 0)
                    {
                        calsStack.Push(currCals);

                    }
                }
                else if (mealsQue.Peek() == "pasta")
                {
                    eatenMeals++;
                    currCals = calsStack.Pop();
                    currCals -= pasta;
                    mealsQue.Dequeue();
                    if (currCals < 0 && calsStack.Any())
                    {
                        leftCals = Math.Abs(currCals);
                        currCals = calsStack.Pop();
                        currCals -= leftCals;
                        calsStack.Push(currCals);
                        continue;
                    }
                    else if (currCals > 0)
                    {
                        calsStack.Push(currCals);

                    }
                }
                else if (mealsQue.Peek() == "steak")
                {
                    eatenMeals++;
                    currCals = calsStack.Pop();
                    currCals -= steak;
                    mealsQue.Dequeue();
                    if (currCals < 0 && calsStack.Any())
                    {
                        leftCals = Math.Abs(currCals);
                        currCals = calsStack.Pop();
                        currCals -= leftCals;
                        calsStack.Push(currCals);
                        continue;
                    }
                    else if (currCals > 0)
                    {
                        calsStack.Push(currCals);

                    }
                }
                

            }
            if (mealsQue.Count == 0)
            {
                Console.WriteLine($"John had {eatenMeals} meals.");
                Console.WriteLine($"For the next few days, he can eat {string.Join(", ", calsStack)} calories.");
            }
            else
            {
                Console.WriteLine($"John ate enough, he had {eatenMeals} meals.");
                Console.WriteLine($"Meals left: {string.Join(", ", mealsQue)}.");
            }   
        }

       
    }
}
