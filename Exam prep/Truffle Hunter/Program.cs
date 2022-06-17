using System;
using System.Collections.Generic;

namespace Truffle_Hunter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string[,] matrix = new string[size, size];

            Dictionary<string, int> truffles = new Dictionary<string, int>();
            truffles.Add("BT", 0);
            truffles.Add("ST", 0);
            truffles.Add("WT", 0);
            truffles.Add("BoarTruffles", 0);
            for (int r = 0; r < size; r++)
            {
                string[] input = Console.ReadLine().Split(" ");

                for (int c = 0; c < size; c++)
                {
                    matrix[r, c] = input[c];
                }
            }

            while (true)
            {
                string[] cmd = Console.ReadLine().Split(" ");
                if (cmd[0] == "Stop")
                    break;

                if (cmd[0] == "Collect")
                {
                    CollectTruffles(matrix, truffles, cmd);
                }
                else if (cmd[0] == "Wild_Boar")
                {
                    WildBoarAppears(size, matrix, truffles, cmd);   
                }
               
            }

            Console.WriteLine($"Peter manages to harvest {truffles["BT"]} black," +
                $" {truffles["ST"]} summer, and {truffles["WT"]} white truffles.");
            Console.WriteLine($"The wild boar has eaten {truffles["BoarTruffles"]} truffles.");

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    Console.Write(matrix[r, c] + " ", StringSplitOptions.RemoveEmptyEntries);
                }
                Console.WriteLine();
            }

        }

        private static void WildBoarAppears(int size, string[,] matrix, Dictionary<string, int> truffles, string[] cmd)
        {
            int row = int.Parse(cmd[1]);
            int col = int.Parse(cmd[2]);
            string direction = cmd[3];
            if (matrix[row, col] != "-")
            {
                matrix[row, col] = "-";
                truffles["BoarTruffles"]++;

            }
            if (direction == "up")
            {
                for (int i = row; i >= 0; i -= 2)
                {
                    if (matrix[i, col] == "S")
                    {
                        matrix[i, col] = "-";
                        truffles["BoarTruffles"]++;
                    }
                    else if (matrix[i, col] == "B")
                    {
                        matrix[i, col] = "-";
                        truffles["BoarTruffles"]++;
                    }
                    else if (matrix[i, col] == "W")
                    {
                        matrix[i, col] = "-";
                        truffles["BoarTruffles"]++;
                    }
                }
            }
            else if (direction == "down")
            {
                for (int i = row; i < matrix.GetLength(1); i += 2)
                {
                    if (matrix[i, col] == "S")
                    {
                        matrix[i, col] = "-";
                        truffles["BoarTruffles"]++;
                    }
                    else if (matrix[i, col] == "B")
                    {
                        matrix[i, col] = "-";
                        truffles["BoarTruffles"]++;
                    }
                    else if (matrix[i, col] == "W")
                    {
                        matrix[i, col] = "-";
                        truffles["BoarTruffles"]++;
                    }
                }
            }
            else if (direction == "right")
            {
                for (int i = col; i < matrix.GetLength(1); i += 2)
                {
                    if (matrix[row, i] == "S")
                    {
                        matrix[row, i] = "-";
                        truffles["BoarTruffles"]++;
                    }
                    else if (matrix[row, i] == "B")
                    {
                        matrix[row, i] = "-";
                        truffles["BoarTruffles"]++;
                    }
                    else if (matrix[row, i] == "W")
                    {
                        matrix[row, i] = "-";
                        truffles["BoarTruffles"]++;
                    }
                }
            }
            else if (direction == "left")
            {
                for (int i = col; i >= 0; i -= 2)
                {
                    if (matrix[row, i] == "S")
                    {
                        matrix[row, i] = "-";
                        truffles["BoarTruffles"]++;
                    }
                    else if (matrix[row, i] == "B")
                    {
                        matrix[row, i] = "-";
                        truffles["BoarTruffles"]++;
                    }
                    else if (matrix[row, i] == "W")
                    {
                        matrix[row, i] = "-";
                        truffles["BoarTruffles"]++;
                    }
                }
            }
        }

        private static void CollectTruffles(string[,] matrix, Dictionary<string, int> truffles, string[] cmd)
        {
            if (matrix[int.Parse(cmd[1]), int.Parse(cmd[2])] == "B")
            {
                truffles["BT"]++;
                matrix[int.Parse(cmd[1]), int.Parse(cmd[2])] = "-";
            }
            else if (matrix[int.Parse(cmd[1]), int.Parse(cmd[2])] == "S")
            {
                truffles["ST"]++;
                matrix[int.Parse(cmd[1]), int.Parse(cmd[2])] = "-";
            }
            else if (matrix[int.Parse(cmd[1]), int.Parse(cmd[2])] == "W")
            {
                truffles["WT"]++;
                matrix[int.Parse(cmd[1]), int.Parse(cmd[2])] = "-";
            }
        }
    }
}
