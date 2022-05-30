using System;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            (int rows, int cols) = (size[0], size[1]);

            string[,] matrix = new string[rows, cols];

            for (int r = 0; r < rows; r++)
            {
                string[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int c = 0; c < cols; c++)
                {
                    matrix[r, c] = input[c];
                }
            }

            while (true)
            {
                string[] cmd = Console.ReadLine()
                    .Split(" ");
                string command = cmd[0];
                if (command == "END")
                    break;

                if (command == "swap" && cmd.Length == 5)
                {
                    int row1 = int.Parse(cmd[1]);
                    int col1 = int.Parse(cmd[2]);
                    int row2 = int.Parse(cmd[3]);
                    int col2 = int.Parse(cmd[4]);
                    if (row1 >= 0 && row1 <= rows - 1 && col1 >= 0 && col1 <= cols - 1
                        && row2 >= 0 && row2 <= rows - 1 && col2 >= 0 && col2 <= cols - 1)
                    {
                        string itemToSwap = matrix[row1, col1];

                        matrix[row1, col1] = matrix[row2, col2];
                        matrix[row2, col2] = itemToSwap;

                        for (int r = 0; r < matrix.GetLength(0); r++)
                        {
                            for (int c = 0; c < matrix.GetLength(1); c++)
                            {
                                Console.Write($"{matrix[r, c]} ");
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }

                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }

        }
    }
}
