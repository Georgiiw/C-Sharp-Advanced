using System;
using System.Collections.Generic;
using System.Linq;

namespace Beaver_at_Work
{
    internal class Program
    {
        static void Main()
        {

            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];
            int bRow = 0;
            int bCol = 0;
            int totalBranches = 0;

            Stack<char> branches = new Stack<char>();
            for (int r = 0; r < size; r++)
            {
                char[] chars = Console.ReadLine().Replace(" ", "").ToCharArray();
                for (int c = 0; c < size; c++)
                {
                    matrix[r, c] = chars[c];
                    if (matrix[r, c] == 'B')
                    {
                        bRow = r;
                        bCol = c;
                    }
                    else if (char.IsLower(matrix[r, c]))
                    {
                        totalBranches++;
                    }
                }
            }

            while (true)
            {
                string cmd = Console.ReadLine();
                if (cmd == "end" || totalBranches == 0)
                {
                    break;
                }


                if (cmd == "up")
                {
                    if (bRow == 0)
                    {
                        if (branches.Any())
                        {
                            branches.Pop();
                        }
                        continue;
                    }
                    if (char.IsLower(matrix[bRow - 1, bCol]))
                    {
                        char currBranch = matrix[bRow - 1, bCol];
                        branches.Push(currBranch);
                        matrix[bRow, bCol] = '-';
                        matrix[bRow - 1, bCol] = 'B';
                        bRow -= 1;
                        totalBranches--;

                    }
                    else if (matrix[bRow - 1, bCol] == 'F')
                    {
                        if (bRow - 1 == 0)
                        {
                            matrix[bRow - 1, bCol] = '-';
                            if (char.IsLower(matrix[size - 1, bCol]))
                            {
                                branches.Push(matrix[size - 1, bCol]);
                                totalBranches--;
                            }
                            matrix[bRow, bCol] = '-';
                            matrix[size - 1, bCol] = 'B';
                            bRow = size - 1;
                        }
                        else if (bRow - 1 > 0)
                        {
                            if (char.IsLower(matrix[0, bCol])) ;
                            {
                                branches.Push(matrix[0, bCol]);
                                totalBranches--;
                            }
                            matrix[bRow, bCol] = '-';
                            matrix[0, bCol] = 'B';
                            bRow = 0;
                        }

                    }
                    else
                    {
                        matrix[bRow, bCol] = '-';
                        matrix[bRow - 1, bCol] = 'B';
                        bRow -= 1;
                    }

                }
                else if (cmd == "down")
                {
                    if (bRow == size - 1)
                    {
                        if (branches.Any())
                        {
                            branches.Pop();
                        }
                        continue;
                    }
                    if (char.IsLower(matrix[bRow + 1, bCol]))
                    {
                        char currBranch = matrix[bRow + 1, bCol];
                        branches.Push(currBranch);
                        matrix[bRow, bCol] = '-';
                        matrix[bRow + 1, bCol] = 'B';
                        bRow += 1;
                        totalBranches--;
                    }
                    else if (matrix[bRow + 1, bCol] == 'F')
                    {
                        if (bRow + 1 == size - 1)
                        {
                            matrix[bRow + 1, bCol] = '-';
                            if (char.IsLower(matrix[0, bCol]))
                            {
                                branches.Push(matrix[0, bCol]);
                                totalBranches--;
                            }
                            matrix[bRow, bCol] = '-';
                            matrix[0, bCol] = 'B';
                            bRow = 0;
                        }
                        else if (bRow + 1 < size - 1)
                        {
                            matrix[bRow, bCol] = '-';
                            if (char.IsLower(matrix[size - 1, bCol]))
                            {
                                branches.Push(matrix[size - 1, bCol]);
                                totalBranches--;
                            }
                            matrix[size - 1, bCol] = 'B';
                            bRow = size - 1;
                        }


                    }
                    else
                    {
                        matrix[bRow, bCol] = '-';
                        matrix[bRow + 1, bCol] = 'B';
                        bRow += 1;
                    }
                }
                else if (cmd == "right")
                {
                    if (bCol == size - 1)
                    {
                        if (branches.Any())
                        {
                            branches.Pop();
                        }
                        continue;
                    }

                    if (char.IsLower(matrix[bRow, bCol + 1]))
                    {
                        char currBranch = matrix[bRow, bCol + 1];
                        branches.Push(currBranch);
                        matrix[bRow, bCol] = '-';
                        matrix[bRow, bCol + 1] = 'B';
                        bCol += 1;
                        totalBranches--;
                    }
                    else if (matrix[bRow, bCol + 1] == 'F')
                    {

                        if (bCol + 1 == size - 1)
                        {
                            matrix[bRow, bCol + 1] = '-';
                            if (char.IsLower(matrix[bRow, 0]))
                            {
                                branches.Push(matrix[bRow, 0]);
                                totalBranches--;
                            }
                            matrix[bRow, bCol] = '-';
                            matrix[bRow, 0] = 'B';
                            bCol = 0;
                        }
                        else if (bCol + 1 < size - 1)
                        {
                            matrix[bRow, bCol] = '-';
                            if (char.IsLower(matrix[bRow, size - 1]))
                            {
                                branches.Push(matrix[bRow, size - 1]);
                                totalBranches--;
                            }
                            matrix[bRow, size - 1] = 'B';
                            bCol = size - 1;
                        }

                    }
                    else
                    {
                        matrix[bRow, bCol] = '-';
                        matrix[bRow, bCol + 1] = 'B';
                        bCol += 1;
                    }
                }
                else if (cmd == "left")
                {

                    if (bCol == 0)
                    {
                        if (branches.Any())
                        {
                            branches.Pop();
                        }
                        continue;
                    }

                    if (char.IsLower(matrix[bRow, bCol - 1]))
                    {
                        char currBranch = matrix[bRow, bCol - 1];
                        branches.Push(currBranch);
                        matrix[bRow, bCol] = '-';
                        matrix[bRow, bCol - 1] = 'B';
                        bCol -= 1;
                        totalBranches--;
                    }
                    else if (matrix[bRow, bCol - 1] == 'F')
                    {
                        if (bCol - 1 == 0)
                        {
                            matrix[bRow, bCol - 1] = '-';
                            if (char.IsLower(matrix[bRow, size - 1]))
                            {
                                branches.Push(matrix[bRow, size - 1]);
                                totalBranches--;
                            }
                            matrix[bRow, bCol] = '-';
                            matrix[bRow, size - 1] = 'B';
                            bCol = size - 1;
                        }
                        else if (bCol - 1 > 0)
                        {
                            matrix[bRow, bCol] = '-';
                            if (char.IsLower(matrix[bRow, 0]))
                            {
                                branches.Push(matrix[bRow, 0]);
                                totalBranches--;
                            }
                            matrix[bRow, 0] = 'B';
                            bCol = 0;
                        }

                    }
                    else
                    {
                        matrix[bRow, bCol] = '-';
                        matrix[bRow, bCol - 1] = 'B';
                        bCol -= 1;
                    }
                }

            }
            Stack<char> rev = new Stack<char>();
            while (branches.Count != 0)
            {
                rev.Push(branches.Pop());
            }
            if (totalBranches > 0)
            {
                Console.WriteLine($"The Beaver failed to collect every wood branch. There are {totalBranches} branches left.");
            }
            else
            {
                Console.WriteLine($"The Beaver successfully collect {rev.Count} wood branches: {string.Join(", ", rev)}.");
            }
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    Console.Write(matrix[r, c] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}