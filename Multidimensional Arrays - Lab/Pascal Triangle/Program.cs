using System;
using System.Numerics;

namespace Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rowsCount = int.Parse(Console.ReadLine());
            BigInteger[][] triangle = new BigInteger[rowsCount][];
            for (int r = 0; r < rowsCount; r++)
            {
                triangle[r] = new BigInteger[r + 1];
                triangle[r][0] = 1;
                for (int c = 1; c < r; c++)
                {
                    triangle[r][c] = triangle[r - 1][c - 1] + triangle[r - 1][c];
                }
                triangle[r][r] = 1;
            }
            for (int r = 0; r < triangle.Length; r++)           
                Console.WriteLine(String.Join(" ", triangle[r]));
            
        }
    }
}
