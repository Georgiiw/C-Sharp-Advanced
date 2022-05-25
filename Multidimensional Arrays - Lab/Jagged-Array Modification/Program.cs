using System;
using System.Linq;

namespace Jagged_Array_Modification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rowCount = int.Parse(Console.ReadLine());
            int[][] jaggedArr = new int[rowCount][];
            for (int i = 0; i < rowCount; i++)
            {
                jaggedArr[i] = Console.ReadLine().Split(" ")
                .Select(int.Parse)
                .ToArray();

                
            }
           
            while (true)
            {
                string[] cmd = Console.ReadLine().Split(" ");

                if (cmd[0] == "Add")
                {
                    int row = int.Parse(cmd[1]);
                    int col = int.Parse(cmd[2]);
                    int val = int.Parse(cmd[3]);
                    if (row >= 0 && row < jaggedArr.Length && col >= 0 && col < jaggedArr[row].Length)
                    {
                        jaggedArr[row][col] += val;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }
                else if (cmd[0] == "Subtract")
                {
                    int row = int.Parse(cmd[1]);
                    int col = int.Parse(cmd[2]);
                    int val = int.Parse(cmd[3]);
                    if (row >= 0 && row < jaggedArr.Length && col >= 0 && col < jaggedArr[row].Length)
                    {
                        jaggedArr[row][col] -= val;

                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }

                }
                else if (cmd[0] == "END")
                {
                    break;
                }
            }

            for (int r = 0; r < jaggedArr.Length; r++)
            {
                Console.WriteLine(string.Join(" ", jaggedArr[r]));
            }

        }
    }
}
