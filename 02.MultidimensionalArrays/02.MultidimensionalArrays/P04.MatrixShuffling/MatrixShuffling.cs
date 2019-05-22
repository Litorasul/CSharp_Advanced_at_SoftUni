using System;
using System.Linq;

namespace P04.MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string[,] matrix = new string[dimensions[0], dimensions[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string[] elements = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = elements[j];
                }
            }

            string command = String.Empty;

            while ((command = Console.ReadLine()) != "END")
            {
                string[] commandArr = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (commandArr[0] == "swap" && commandArr.Length == 5)
                {
                    int rowOne = int.Parse(commandArr[1]);
                    int colOne = int.Parse(commandArr[2]);
                    int rowTwo = int.Parse(commandArr[3]);
                    int colTwo = int.Parse(commandArr[4]);
                    if (rowOne < matrix.GetLength(0)
                        && rowTwo < matrix.GetLength(0)
                        && colOne < matrix.GetLength(1)
                        && colTwo < matrix.GetLength(1))
                    {
                        string temp = matrix[rowOne, colOne];
                        matrix[rowOne, colOne] = matrix[rowTwo, colTwo];
                        matrix[rowTwo, colTwo] = temp;
                        for (int k = 0; k < matrix.GetLength(0); k++)
                        {
                            for (int l = 0; l < matrix.GetLength(1); l++)
                            {
                                Console.Write(matrix[k,l] + " ");
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }


                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
    }
}
