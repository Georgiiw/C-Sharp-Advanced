using System;
using System.Linq;

namespace Sum_Matrix_Elements
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

            int sum = 0;

            for (int r = 0; r < rows; r++)
            {

                for (int c = 0; c < cols; c++)
                {
                    sum += matrix[r, c];
                }
            }
            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(sum);
        }
    }
}
