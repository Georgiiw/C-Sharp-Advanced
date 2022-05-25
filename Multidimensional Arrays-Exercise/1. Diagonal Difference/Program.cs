using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            for (int r = 0; r < size; r++)
            {
                int[] numbers = Console.ReadLine().Split(' ')
                    .Select(int.Parse)
                    .ToArray();

                for (int c = 0; c < size; c++)
                {
                    matrix[r, c] = numbers[c];
                }
            }
            int diagonalOne = 0;
            int diagonalTwo = 0;
            for (int i = 0; i < size; i++)
            {
                diagonalOne += matrix[i, i];
            }
            for (int i = 1; i <= size; i++)
            {
                diagonalTwo += matrix[i - 1, size - i];
            }
            Console.WriteLine(Math.Abs(diagonalOne - diagonalTwo));
        }
    }
}
