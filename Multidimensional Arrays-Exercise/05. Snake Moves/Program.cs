using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Snake_Moves
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

            string snake = Console.ReadLine();
            char[,] matrix = new char[rows, cols];
            var chars = new Queue<char>();
            int matrixSquares = rows * cols;
            int counter = 0;

            for (int i = 0; i < snake.Length; i++)
            {
                chars.Enqueue(snake[i]);
                counter++;
                if (counter == matrixSquares)               
                    break;
                
                if (i == snake.Length - 1)               
                    i = -1;
                
            }
            for (int r = 0; r < rows; r++)
            {
                if (r % 2 == 0)               
                    for (int c = 0; c < cols; c++)
                       matrix[r, c] = chars.Dequeue();
              

                else if (r % 2 != 0)               
                    for (int c = cols - 1; c > -1; c--)                   
                        matrix[r, c] = chars.Dequeue();
                    
                  
            }
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)               
                    Console.Write(matrix[r, c]);
                
                Console.WriteLine();
            }


        }
    }
}
