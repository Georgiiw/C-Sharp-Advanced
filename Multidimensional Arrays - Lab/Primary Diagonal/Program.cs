using System;
using System.Linq;

namespace Primary_Diagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int[,] matrix = new int[num, num];

            for (int r = 0; r < num; r++)
            {
                int[] numbers = Console.ReadLine().Split(" ")
                .Select(int.Parse)
                .ToArray();

                for (int c = 0; c < num; c++)
                {
                    matrix[r, c] = numbers[c];
                }
            }
            int sum = 0;
            for (int r = 0; r < num; r++)
            {

                for (int c = r; c < r + 1; c++)
                {
                    sum += matrix[r, c];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
