using System;
using System.Linq;

namespace P03.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[,] matrix = new int[input[0], input[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] elements = Console.ReadLine()
                    .Split(' ', StringSplitOptions
                    .RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = elements[col];
                }
            }
            long maxSum = 0;
            int rowStart = 0;
            int colStart = 0;
            for (int i = 0; i < matrix.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 2; j++)
                {
                    long currentSum = matrix[i, j] + matrix[i, j + 1]
                        + matrix[i, j + 2] + matrix[i + 1, j] + matrix[i + 1, j + 1]
                        + matrix[i + 1, j + 2] + matrix[i + 2, j]
                        + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        rowStart = i;
                        colStart = j;
                    }

                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            for (int k = rowStart; k < rowStart + 3; k++)
            {
                for (int l = colStart; l < colStart + 3; l++)
                {
                    Console.Write(matrix[k, l] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
