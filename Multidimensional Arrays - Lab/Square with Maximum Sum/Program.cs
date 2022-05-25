using System;
using System.Linq;

namespace Square_with_Maximum_Sum
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
                int[] numbers = Console.ReadLine().Split(", ")
                .Select(int.Parse)
                .ToArray();

                for (int c = 0; c < cols; c++)
                {
                    matrix[r, c] = numbers[c];
                }
            }
            int maxSum = int.MinValue;
            (int num1, int num2, int num3, int num4) = (0, 0, 0, 0);
          
            for (int r = 0; r < rows - 1; r++)
            {
                for (int c = 0; c < cols - 1; c++)
                {
                    int matrixMaxSum = matrix[r, c] + matrix[r, c + 1] + matrix[r + 1, c] + matrix[r + 1, c + 1];
                    if (matrixMaxSum > maxSum)
                    {
                        maxSum = matrixMaxSum;
                        num1 = matrix[r, c];
                        num2 = matrix[r, c + 1];
                        num3 = matrix[r + 1, c];
                        num4 = matrix[r + 1, c + 1];

                    }
                }
            }
            Console.WriteLine($"{num1} {num2}");
            Console.WriteLine($"{num3} {num4}");
            Console.WriteLine(maxSum);

        }
    }
}
