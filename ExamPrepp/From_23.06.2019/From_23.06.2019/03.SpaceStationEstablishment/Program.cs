using System;
using System.Linq;

namespace _03.SpaceStationEstablishment
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = Int32.Parse(Console.ReadLine());

            int starPower = 0;

            char[,] spaceMatrix = new char[size, size];

            if (size > 0)
            {
                for (int row = 0; row < spaceMatrix.GetLength(0); row++)
                {
                    char[] elements = Console.ReadLine()
                        .ToCharArray();

                    for (int col = 0; col < spaceMatrix.GetLength(1); col++)
                    {
                        spaceMatrix[row, col] = elements[col];
                    }
                }
            }

            while (starPower < 50)
            {
                string command = Console.ReadLine();

                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        if (spaceMatrix[i, j] == 'S')
                        {
                            switch (command)
                            {
                                case "up":
                                    {
                                        if (IsInside(spaceMatrix, i - 1, j))
                                        {
                                            if (char.IsNumber(spaceMatrix[i - 1, j]))
                                            {
                                                starPower += int.Parse(spaceMatrix[i - 1, j].ToString());
                                                spaceMatrix[i - 1, j] = 'S';
                                                spaceMatrix[i, j] = '-';
                                                continue;

                                            }
                                            else if (spaceMatrix[i - 1, j] == 'O')
                                            {
                                                spaceMatrix[i, j] = '-';
                                                spaceMatrix[i - 1, j] = '-';
                                                BlackHole(spaceMatrix, i - 1, j);
                                                continue;

                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Bad news, the spaceship went to the void.");
                                            PrintOutput(starPower, spaceMatrix);
                                            Environment.Exit(0);
                                        }

                                    }
                                    break;
                                case "down":
                                    {
                                        if (IsInside(spaceMatrix, i + 1, j))
                                        {
                                            if (char.IsNumber(spaceMatrix[i + 1, j]))
                                            {
                                                starPower += int.Parse(spaceMatrix[i + 1, j].ToString());
                                                spaceMatrix[i + 1, j] = 'S';
                                                spaceMatrix[i, j] = '-';
                                                continue;
                                            }
                                            else if (spaceMatrix[i + 1, j] == 'O')
                                            {
                                                spaceMatrix[i, j] = '-';
                                                spaceMatrix[i + 1, j] = '-';
                                                BlackHole(spaceMatrix, i + 1, j);
                                                continue;

                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Bad news, the spaceship went to the void.");
                                            PrintOutput(starPower, spaceMatrix);
                                            Environment.Exit(0);
                                        }
                                    }
                                    break;
                                case "left":
                                    {
                                        if (IsInside(spaceMatrix, i, j - 1))
                                        {
                                            if (char.IsNumber(spaceMatrix[i, j - 1]))
                                            {
                                                starPower += int.Parse(spaceMatrix[i, j - 1].ToString());
                                                spaceMatrix[i, j - 1] = 'S';
                                                spaceMatrix[i, j] = '-';
                                                continue;
                                            }
                                            else if (spaceMatrix[i, j - 1] == 'O')
                                            {
                                                spaceMatrix[i, j] = '-';
                                                spaceMatrix[i, j - 1] = '-';
                                                BlackHole(spaceMatrix, i, j - 1);
                                                continue;

                                            }

                                        }
                                        else
                                        {
                                            Console.WriteLine("Bad news, the spaceship went to the void.");
                                            PrintOutput(starPower, spaceMatrix);
                                            Environment.Exit(0);
                                        }

                                    }
                                    break;
                                case "right":
                                    {
                                        if (IsInside(spaceMatrix, i, j + 1))
                                        {
                                            if (char.IsNumber(spaceMatrix[i, j + 1]))
                                            {
                                                starPower += int.Parse(spaceMatrix[i, j + 1].ToString());
                                                spaceMatrix[i, j + 1] = 'S';
                                                spaceMatrix[i, j] = '-';
                                                continue;
                                            }
                                            else if (spaceMatrix[i, j + 1] == 'O')
                                            {
                                                spaceMatrix[i, j] = '-';
                                                spaceMatrix[i, j + 1] = '-';
                                                BlackHole(spaceMatrix, i, j + 1);
                                                continue;

                                            }

                                        }
                                        else
                                        {
                                            Console.WriteLine("Bad news, the spaceship went to the void.");
                                            PrintOutput(starPower, spaceMatrix);
                                            Environment.Exit(0);
                                        }

                                    }
                                    break;
                            }
                        }
                    }
                }
            }

            Console.WriteLine("Good news! Stephen succeeded in collecting enough star power!");
            PrintOutput(starPower, spaceMatrix);
        }

        private static void PrintOutput(int starPower, char[,] spaceMatrix)
        {
            Console.WriteLine($"Star power collected: {starPower}");
            for (int i = 0; i < spaceMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < spaceMatrix.GetLength(1); j++)
                {
                    Console.Write(spaceMatrix[i, j]);
                }

                Console.WriteLine();
            }
        }

        private static void BlackHole(char[,] spaceMatrix, int row, int col)
        {
            for (int i = row; i < spaceMatrix.GetLength(0); i++)
            {
                for (int j = col; j < spaceMatrix.GetLength(1); j++)
                {
                    if (spaceMatrix[i, j] == 'O')
                    {
                        spaceMatrix[i, j] = 'S';
                    }
                }
            }
        }

        private static bool IsInside(char[,] board, int desiredRow, int desiredCol)
        {
            return desiredRow < board.GetLength(0) && desiredRow >= 0
                                                   && desiredCol < board.GetLength(1) && desiredCol >= 0;
        }
    }

}
