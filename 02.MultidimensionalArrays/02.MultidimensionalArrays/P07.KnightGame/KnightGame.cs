using System;

namespace P07.KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] board = new char[size, size];

            for (int row = 0; row < size; row++)
            {
                char[] elements = Console.ReadLine()
                    .ToCharArray();
                for (int col = 0; col < size; col++)
                {
                    board[row, col] = elements[col];
                }
            }

            int counter = 0;

            while (true)
            {
                int maxCount = 0;
                int knightRaw = 0;
                int knightCol = 0;

                for (int row = 0; row < board.GetLength(0); row++)
                {
                    for (int col = 0; col < board.GetLength(1); col++)
                    {
                        int currentCount = 0;

                        if (board[row,col] == 'K')
                        {
                            if (IsInsidde(board, row - 2, col + 1) && board[row - 2, col + 1] == 'K')
                            {
                                currentCount++;
                            }
                            if (IsInsidde(board, row - 2, col - 1) && board[row - 2, col - 1] == 'K')
                            {
                                currentCount++;
                            }
                            if (IsInsidde(board, row + 2, col - 1) && board[row + 2, col - 1] == 'K')
                            {
                                currentCount++;
                            }
                            if (IsInsidde(board, row - 1, col - 2) && board[row - 1, col -2] == 'K')
                            {
                                currentCount++;
                            }
                            if (IsInsidde(board, row + 1, col - 2) && board[row + 1, col - 2] == 'K')
                            {
                                currentCount++;
                            }
                            if (IsInsidde(board, row + 1, col + 2) && board[row + 1, col + 2] == 'K')
                            {
                                currentCount++;
                            }
                            if (IsInsidde(board, row - 1, col + 2) && board[row - 1, col + 2] == 'K')
                            {
                                currentCount++;
                            }
                            if (IsInsidde(board, row + 2, col + 1) && board[row + 2, col + 1] == 'K')
                            {
                                currentCount++;
                            }

                        }

                        if (currentCount > maxCount)
                        {
                            maxCount = currentCount;
                            knightRaw = row;
                            knightCol = col;
                        }
                    }
                }
                if (maxCount == 0)
                {
                    break;
                }

                board[knightRaw, knightCol] = '0';
                counter++;
            }

            Console.WriteLine(counter);
        }

        private static bool IsInsidde(char[,] board, int desiredRow, int desiredCol)
        {
            return desiredRow < board.GetLength(0) && desiredRow >= 0
                && desiredCol < board.GetLength(1) && desiredCol >= 0;
        }
    }
}
