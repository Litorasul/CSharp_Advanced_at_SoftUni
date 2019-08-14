using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.SeashellTreasure
{
    class Program
    {
        static char[][] beach;
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            beach = new char[rows][];

            List<char> collected = new List<char>();
            List<char> stolen = new List<char>();

            for (int row = 0; row < beach.Length; row++)
            {
                char[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();
                beach[row] = new char[input.Length];
                for (int col = 0; col < beach[row].Length; col++)
                {
                    beach[row][col] = input[col];
                }
            }

            string received = string.Empty;

            while ((received = Console.ReadLine()) != "Sunset")
            {
                string[] commandInfo = received
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = commandInfo[0];

                if (command == "Collect")
                {
                    int desiredRow = int.Parse(commandInfo[1]);
                    int desiredCol = int.Parse(commandInfo[2]);

                    if (IsInside(desiredRow, desiredCol) && beach[desiredRow][desiredCol] != '-')
                    {
                        char toCollect = beach[desiredRow][desiredCol];
                        collected.Add(toCollect);
                        beach[desiredRow][desiredCol] = '-';
                    }
                }
                else
                {
                    int desiredRow = int.Parse(commandInfo[1]);
                    int desiredCol = int.Parse(commandInfo[2]);
                    string direction = commandInfo[3];

                    if (IsInside(desiredRow, desiredCol))
                    {
                        if (beach[desiredRow][desiredCol] != '-')
                        {
                            char toSteal = beach[desiredRow][desiredCol];
                            stolen.Add(toSteal);
                            beach[desiredRow][desiredCol] = '-';
                        }

                        switch (direction)
                        {
                            case "up":
                                {
                                    StepUp(desiredRow, desiredCol, stolen);
                                }
                                break;
                            case "down":
                                {
                                    StepDown(desiredRow, desiredCol, stolen);
                                }
                                break;
                            case "left":
                                {
                                    StepLeft(desiredRow, desiredCol, stolen);
                                }
                                break;
                            case "right":
                                {
                                    StepRight(desiredRow, desiredCol, stolen);
                                }
                                break;
                        }
                    }
                }
            }

            foreach (var row in beach)
            {
                Console.WriteLine(string.Join(" ", row));
            }
            StringBuilder sb = new StringBuilder();
            sb.Append($"Collected seashells: {collected.Count}");
            if (collected.Count > 0)
            {
                sb.Append($" -> {string.Join(", ", collected)}");
            }

            Console.WriteLine(sb.ToString());
            Console.WriteLine($"Stolen seashells: {stolen.Count}");
        }

        private static void StepRight(int desiredRow, int desiredCol, List<char> stolen)
        {
            if (IsInside(desiredRow, desiredCol + 1)
                && beach[desiredRow][desiredCol + 1] != '-')
            {
                char toSteal = beach[desiredRow][desiredCol + 1];
                stolen.Add(toSteal);
                beach[desiredRow][desiredCol + 1] = '-';
            }

            if (IsInside(desiredRow, desiredCol + 2)
                && beach[desiredRow][desiredCol + 2] != '-')
            {
                char toSteal = beach[desiredRow][desiredCol + 2];
                stolen.Add(toSteal);
                beach[desiredRow][desiredCol + 2] = '-';
            }

            if (IsInside(desiredRow, desiredCol + 3)
                && beach[desiredRow][desiredCol + 3] != '-')
            {
                char toSteal = beach[desiredRow][desiredCol + 3];
                stolen.Add(toSteal);
                beach[desiredRow][desiredCol + 3] = '-';
            }
        }

        private static void StepLeft(int desiredRow, int desiredCol, List<char> stolen)
        {
            if (IsInside(desiredRow, desiredCol - 1)
                && beach[desiredRow][desiredCol - 1] != '-')
            {
                char toSteal = beach[desiredRow][desiredCol - 1];
                stolen.Add(toSteal);
                beach[desiredRow][desiredCol - 1] = '-';
            }

            if (IsInside(desiredRow, desiredCol - 2)
                && beach[desiredRow][desiredCol - 2] != '-')
            {
                char toSteal = beach[desiredRow][desiredCol - 2];
                stolen.Add(toSteal);
                beach[desiredRow][desiredCol - 2] = '-';
            }

            if (IsInside(desiredRow, desiredCol - 3)
                && beach[desiredRow][desiredCol - 3] != '-')
            {
                char toSteal = beach[desiredRow][desiredCol - 3];
                stolen.Add(toSteal);
                beach[desiredRow][desiredCol - 3] = '-';
            }
        }

        private static void StepDown(int desiredRow, int desiredCol, List<char> stolen)
        {
            if (IsInside(desiredRow + 1, desiredCol)
                && beach[desiredRow + 1][desiredCol] != '-')
            {
                char toSteal = beach[desiredRow + 1][desiredCol];
                stolen.Add(toSteal);
                beach[desiredRow + 1][desiredCol] = '-';
            }

            if (IsInside(desiredRow + 2, desiredCol)
                && beach[desiredRow + 2][desiredCol] != '-')
            {
                char toSteal = beach[desiredRow + 2][desiredCol];
                stolen.Add(toSteal);
                beach[desiredRow + 2][desiredCol] = '-';
            }

            if (IsInside(desiredRow + 3, desiredCol)
                && beach[desiredRow + 3][desiredCol] != '-')
            {
                char toSteal = beach[desiredRow + 3][desiredCol];
                stolen.Add(toSteal);
                beach[desiredRow + 3][desiredCol] = '-';
            }
        }

        private static void StepUp(int desiredRow, int desiredCol, List<char> stolen)
        {
            if (IsInside(desiredRow - 1, desiredCol) 
                && beach[desiredRow -1][desiredCol] != '-')
            {
                char toSteal = beach[desiredRow - 1][desiredCol];
                stolen.Add(toSteal);
                beach[desiredRow - 1][desiredCol] = '-';
            }

            if (IsInside(desiredRow - 2, desiredCol)
                && beach[desiredRow - 2][desiredCol] != '-')
            {
                char toSteal = beach[desiredRow - 2][desiredCol];
                stolen.Add(toSteal);
                beach[desiredRow - 2][desiredCol] = '-';
            }

            if (IsInside(desiredRow - 3, desiredCol)
                && beach[desiredRow - 3][desiredCol] != '-')
            {
                char toSteal = beach[desiredRow - 3][desiredCol];
                stolen.Add(toSteal);
                beach[desiredRow - 3][desiredCol] = '-';
            }
        }

        private static bool IsInside(int desiredRow, int desiredCol)
        {
            return desiredRow < beach.Length
                   && desiredRow >= 0 && desiredCol < beach[desiredRow].Length
                   && desiredCol >= 0;
        }
    }
}
