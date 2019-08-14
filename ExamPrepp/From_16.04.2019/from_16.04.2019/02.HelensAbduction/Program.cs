using System;

namespace _02.HelensAbduction
{
    class Program
    {
         static char[,] spartaMatrix;

         static int parisPositionRow;
         static int parisPositionCol;
         static int parisEnergy;

         static int helenPositionRow;
         static int helenPositionCol;
        static void Main(string[] args)
        {
            parisEnergy = int.Parse(Console.ReadLine());
            CheckParisEnergy();
            int spartaSize = int.Parse(Console.ReadLine());
           
            FillInSparta(spartaSize);

            while (true)
            {
                string[] input = Console.ReadLine()
                    .Split();

                string command = input[0];
                int spartanPositionRow = int.Parse(input[1]);
                int spartanPositionCol = int.Parse(input[2]);

                spartaMatrix[spartanPositionRow, spartanPositionCol] = 'S';
                int desiredRow = 0;
                int desiredCol = 0;

                switch (command)
                {

                    case "up":
                        {
                            desiredRow = parisPositionRow - 1;
                            desiredCol = parisPositionCol;
                            MoveParis(desiredRow, desiredCol);
                        }
                        break;
                    case "down":
                        {
                            desiredRow = parisPositionRow + 1;
                            desiredCol = parisPositionCol;
                            MoveParis(desiredRow, desiredCol);
                        }
                        break;
                    case "left":
                        {
                            desiredRow = parisPositionRow;
                            desiredCol = parisPositionCol - 1;
                            MoveParis(desiredRow, desiredCol);
                        }
                        break;
                    case "right":
                        {
                            desiredRow = parisPositionRow;
                            desiredCol = parisPositionCol + 1;
                            MoveParis(desiredRow, desiredCol);
                        }
                        break;
                }
            }
        }

        private static void MoveParis( int desiredRow, int desiredCol)
        {
            parisEnergy -= 1;
            
            if (IsInside(desiredRow, desiredCol))
            {
                if (spartaMatrix[desiredRow, desiredCol] == 'S')
                {
                    spartaMatrix[parisPositionRow, parisPositionCol] = '-';
                    parisPositionRow = desiredRow;
                    parisPositionCol = desiredCol;
                    CheckParisEnergy();
                    parisEnergy -= 2;
                    CheckParisEnergy();
                    spartaMatrix[desiredRow, desiredCol] = 'P';
                }
                else if(spartaMatrix[desiredRow, desiredCol] == 'H')
                {
                    spartaMatrix[parisPositionRow, parisPositionCol] = '-';
                    spartaMatrix[desiredRow, desiredCol] = '-';
                    ParisWins();
                }
                else
                {
                    spartaMatrix[parisPositionRow, parisPositionCol] = '-';
                    parisPositionRow = desiredRow;
                    parisPositionCol = desiredCol;
                    spartaMatrix[desiredRow, desiredCol] = 'P';
                    CheckParisEnergy();
                }
            }
            else
            {
                CheckParisEnergy();
            }
        }

        private static void ParisWins()
        {
            Console.WriteLine($"Paris has successfully abducted Helen! Energy left: {parisEnergy}");
            PrintTheMatrix();
            Environment.Exit(0);
        }

        private static void PrintTheMatrix()
        {
            for (int row = 0; row < spartaMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < spartaMatrix.GetLength(1); col++)
                {
                    Console.Write(spartaMatrix[row, col]);
                }

                Console.WriteLine();
            }
        }

        private static void CheckParisEnergy()
        {
            if (parisEnergy <= 0)
            {
                spartaMatrix[parisPositionRow, parisPositionCol] = 'X';
                ParisIsDead();
                Environment.Exit(0);
            }
        }

        private static void ParisIsDead()
        {
            Console.WriteLine($"Paris died at {parisPositionRow};{parisPositionCol}.");
            PrintTheMatrix();
        }

        private static bool IsInside(int desiredRow, int desiredCol)
        {
            return desiredRow < spartaMatrix.GetLength(0)
                   && desiredRow >= 0 && desiredCol < spartaMatrix.GetLength(1)
                   && desiredCol >= 0;
        }

        private static void FillInSparta(int spartaSize)
        {
            spartaMatrix = new char[spartaSize, spartaSize];
            for (int row = 0; row < spartaMatrix.GetLength(0); row++)
            {
                char[] colInfo = Console.ReadLine().ToCharArray();
                for (int col = 0; col < spartaMatrix.GetLength(1); col++)
                {
                    spartaMatrix[row, col] = colInfo[col];
                    if (colInfo[col] == 'P')
                    {
                        parisPositionRow = row;
                        parisPositionCol = col;
                    }
                    else if (colInfo[col] == 'H')
                    {
                        helenPositionRow = row;
                        helenPositionCol = col;
                    }
                }
            }
        }
    }
}
