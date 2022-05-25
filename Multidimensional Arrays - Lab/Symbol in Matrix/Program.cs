using System;
using System.Linq;

namespace Symbol_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            char[,] matrix = new char[num, num];
            for (int r = 0; r < num; r++)
            {
                char[] array = Console.ReadLine()
                    .ToCharArray();
                for (int c = 0; c < num; c++)
                {
                    matrix[r, c] = array[c];
                }
            }

            string symbol = Console.ReadLine();
            bool isSymbol = false;


            for (int r = 0; r < num; r++)
            {
                for (int c = 0; c < num; c++)
                {
                    if (matrix[r, c].ToString() == symbol)
                    {
                        Console.WriteLine($"({r}, {c})");
                        isSymbol = true;
                        return;
                    }
                }

            }

            if (isSymbol == false)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }

        }
    }
}
