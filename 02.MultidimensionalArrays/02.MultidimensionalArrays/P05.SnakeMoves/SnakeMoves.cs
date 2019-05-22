using System;
using System.Linq;

namespace P05.SnakeMoves
{
    class SnakeMoves
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            char[,] snakePath = new char[dimensions[0], dimensions[1]];

            char[] snake = Console.ReadLine().ToCharArray();
            int index = 0;
            for (int row = 0; row < snakePath.GetLength(0); row++)
            {
               
                for (int col = 0; col < snakePath.GetLength(1); col++)
                {
                    snakePath[row, col] = snake[index];
                    if (index == snake.Length - 1)
                    {
                        index = 0;
                    }
                    else
                    {
                        index++;
                    }
                }
            }

            for (int i = 0; i < snakePath.GetLength(0); i++)
            {
                for (int j = 0; j < snakePath.GetLength(1); j++)
                {
                    Console.Write(snakePath[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
