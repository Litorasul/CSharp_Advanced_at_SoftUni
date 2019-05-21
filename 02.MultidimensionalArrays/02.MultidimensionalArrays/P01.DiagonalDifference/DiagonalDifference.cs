using System;
using System.Linq;

namespace P01.DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            for (int row = 0; row < size; row++)
            {
                int[] elements = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = elements[col];
                }
            }
            int diagonalOne = 0;
            int diagonalTwo = 0;
            int cols = 0;
            int cols2 = size - 1;
            for (int rows = 0; rows < size; rows++)
            {
                diagonalOne += matrix[rows, cols];
                cols++;
                diagonalTwo += matrix[rows, cols2];
                cols2--;
            }
            int sum = 0;
            if (diagonalOne > diagonalTwo)
            {
                sum = diagonalOne - diagonalTwo;
            }
            else
            {
                sum = diagonalTwo - diagonalOne;
            }
            Console.WriteLine(sum);
        }
    }
}
