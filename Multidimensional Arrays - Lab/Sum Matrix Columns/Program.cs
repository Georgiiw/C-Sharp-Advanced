using System;
using System.Linq;

namespace Sum_Matrix_Columns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(", ")
                .Select(int.Parse)
                .ToArray();

            (int rows, int cols) = (size[0], size[1]);


            int[,] matrix = new int[rows, cols];

            for (int r = 0; r < rows; r++)
            {
                int[] numbers = Console.ReadLine().Split(" ")
                .Select(int.Parse)
                .ToArray();

                for (int c = 0; c < cols; c++)
                {
                    matrix[r, c] = numbers[c];
                }
            }

            for (int r = 0; r < cols; r++)
            {
                int sum = 0;
                for (int c = 0; c < rows; c++)
                {                   
                    sum += matrix[c, r];
                }
                    Console.WriteLine(sum);
            }

        }
    }
}
