using System;
using System.Linq;

namespace _3._Maximal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(" ")
                .Select(int.Parse)
                .ToArray();
            (int rows, int cols) = (size[0], size[1]);

            int[,] matrix = new int[rows, cols];

            for (int r = 0; r < rows; r++)
            {
                int[] numbers = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int c = 0; c < cols; c++)
                {
                    matrix[r, c] = numbers[c];
                }
            }
            int maxSum = int.MinValue;
            int[,] maxSumMatrix = new int[3, 3];
            
            for (int r = 0; r < rows - 2; r++)
            {

                for (int c = 0; c < cols - 2; c++)
                {
                    int matrixSum = matrix[r, c] + matrix[r, c + 1] + matrix[r, c + 2] + matrix[r + 1, c] + matrix[r + 1, c + 1]
                        + matrix[r + 1, c + 2] + matrix[r + 2, c] + matrix[r + 2, c + 1] + matrix[r + 2, c + 2];
                    if (matrixSum > maxSum)
                    {
                        maxSum = matrixSum;

                        maxSumMatrix[0, 0] = matrix[r, c];
                        maxSumMatrix[0, 1] = matrix[r, c + 1];
                        maxSumMatrix[0, 2] = matrix[r, c + 2];
                        maxSumMatrix[1, 0] = matrix[r + 1, c];
                        maxSumMatrix[1, 1] = matrix[r + 1, c + 1];
                        maxSumMatrix[1, 2] = matrix[r + 1, c + 2];
                        maxSumMatrix[2, 0] = matrix[r + 2, c];
                        maxSumMatrix[2, 1] = matrix[r + 2, c + 1];
                        maxSumMatrix[2, 2] = matrix[r + 2, c + 2];
                    }
                }
            }
            if (rows >= 3 && cols >= 3)
            {
                Console.WriteLine($"Sum = {maxSum}");
                for (int r = 0; r < maxSumMatrix.GetLength(0); r++)
                {
                    for (int c = 0; c < maxSumMatrix.GetLength(1); c++)
                    {
                        Console.Write($"{maxSumMatrix[r, c]} ");
                    }
                    Console.WriteLine();
                }

            }
        }
    }
}
