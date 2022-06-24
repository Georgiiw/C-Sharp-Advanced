using System;
using System.Collections.Generic;
using System.Text;

namespace Pawn_Wars
{
    internal class Program
    {
        static void Main(string[] args)
        {


            char[,] chessBoard = new char[8, 8];

            for (int r = 0; r < chessBoard.GetLength(0); r++)
            {
                char[] input = Console.ReadLine().ToCharArray();
                for (int c = 0; c < chessBoard.GetLength(1); c++)
                {
                    chessBoard[r, c] = input[c];
                }
            }            
            int whiteRow = 0;
            int whiteCol = 0;            
            int blackRow = 0;
            int blackCol = 0;

            for (int r = 0; r < chessBoard.GetLength(0); r++)
            {

                for (int c = 0; c < chessBoard.GetLength(1); c++)
                {
                    if (chessBoard[r, c] == 'w')
                    {
                        whiteRow = r;
                        whiteCol = c;
                    }
                    else if (chessBoard[r, c] == 'b')
                    {
                        blackRow = r;
                        blackCol = c;
                    }
                }
            }
            
            while (true)
            {
             
                if (IsValid(whiteRow - 1, whiteCol + 1) && chessBoard[whiteRow - 1, whiteCol + 1] == 'b')
                {
                    Console.WriteLine($"Game over! White capture on {Square(whiteRow - 1, whiteCol + 1)}.");
                    break;
                }
                else if (IsValid(whiteRow - 1, whiteCol - 1) && chessBoard[whiteRow - 1, whiteCol - 1] == 'b')
                {
                    Console.WriteLine($"Game over! White capture on {Square(whiteRow - 1, whiteCol - 1)}.");
                    break;
                }
                else
                {
                    chessBoard[whiteRow, whiteCol] = '-';
                    whiteRow--;
                    chessBoard[whiteRow, whiteCol] = 'w';
                    if (whiteRow == 0)
                    {
                        Console.WriteLine($"Game over! White pawn is promoted to a queen at {Square(whiteRow, whiteCol)}.");
                        break;
                    }
                }
               
                if (IsValid(blackRow + 1, blackCol + 1) && chessBoard[blackRow + 1, blackCol + 1] == 'w')
                {
                    Console.WriteLine($"Game over! Black capture on {Square(blackRow + 1, blackCol + 1)}.");
                    break;
                }
                else if (IsValid(blackRow + 1, blackCol - 1) && chessBoard[blackRow + 1, blackCol - 1] == 'w')
                {
                    Console.WriteLine($"Game over! Black capture on {Square(blackRow + 1, blackCol - 1)}.");
                    break;
                }
                else
                {
                    chessBoard[blackRow, blackCol] = '-';
                    blackRow++;
                    chessBoard[blackRow, blackCol] = 'b';
                    if (blackRow == 7)
                    {
                        Console.WriteLine($"Game over! Black pawn is promoted to a queen at {Square(blackRow, blackCol)}.");
                        break;
                    }
                }
               
            }


        }
        private static bool IsValid(int row, int col)
        {
            return row >= 0 && row <= 7 && col >= 0 && col <= 7;
        }
        private static string Square(int row, int col)
        {

            var sb = new StringBuilder();

            for (int i = 8; i >= 0; i--)
            {
                if (col == i)
                {
                    sb.Append((char)(i + 97));
                }
            }

            int counter = 8;
            for (int i = 0; i < 8; i++)
            {
                if (row == i)
                {
                    sb.Append(counter);
                }
                counter--;
            }
            return sb.ToString();
        }
    }
}
