using System;
using System.Linq;

namespace P02._2x2Squares
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int rows = input[0];
            int cols = input[1];
            if (rows > 0 && cols > 0)
            {
                char[,] matrix = new char[rows, cols];

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    char[] elements = Console.ReadLine()
                        .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                        .Select(char.Parse)
                        .ToArray();

                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] = elements[col];
                    }
                }
                int squaresFound = 0;
                for (int i = 0; i < matrix.GetLength(0) - 1; i++)
                {
                    for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                    {
                        if (matrix[i, j] == matrix[i, j + 1]
                            && matrix[i + 1, j] == matrix[i, j]
                            && matrix[i, j] == matrix[i + 1, j + 1])
                        {
                            squaresFound++;
                        }
                    }
                }
                Console.WriteLine(squaresFound);
            }
            else
            {
                Console.WriteLine("0");
            }

            
        }
    }
}
