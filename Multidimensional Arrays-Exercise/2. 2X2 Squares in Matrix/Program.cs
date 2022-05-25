using System;
using System.Linq;

namespace _2._2X2_Squares_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(" ")
                .Select(int.Parse)
                .ToArray();
            (int rows, int cols) = (size[0], size[1]);

            string[,] matrix = new string[rows, cols];

            for (int r = 0; r < rows; r++)
            {
                string[] letters = Console.ReadLine()
                    .Split(' ')
                    .ToArray();

                for (int c = 0; c < cols; c++)
                {
                    matrix[r, c] = letters[c];
                }
            }

            int squaresFound = 0;
            for (int r = 0; r < rows - 1; r++)
            {

                for (int c = 0; c < cols - 1; c++)
                {

                    if (matrix[r,c] == matrix[r, c + 1] && matrix[r, c] == matrix[r + 1, c]
                        && matrix[r, c] == matrix[r + 1, c + 1])
                    {
                        squaresFound++;
                    }
                }
            }
            Console.WriteLine(squaresFound);

        }
    }
}
