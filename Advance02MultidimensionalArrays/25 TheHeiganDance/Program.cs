using System;
using System.Security.Cryptography.X509Certificates;

namespace _26_TheHeiganDance
{
    class Program
    {
        static void Main(string[] args)
        {
            
            decimal exactCenterElement = Math.Ceiling(225m / 2); //113 or matrix[7, 7];  
            int rowPlayer = 7;
            int colPlayer = 7;
            double playerHealth = 18500;
            double playerDamage = double.Parse(Console.ReadLine());
            double cloudDamage = 3600;
            double eruptionDamage = 6000;
            double heiganHealth = 3000000;
            bool isCloudActive = false;
            bool isPlayerAlive = true;
            bool isHeiganAlive = true;
            bool isKilledByCloud = false;

            while (true)
            {
                bool[,] matrix = GenerateMatrix(15, 15);

                heiganHealth -= playerDamage;

                if (isCloudActive)
                {
                    playerHealth -= cloudDamage;
                    isCloudActive = false;
                }

                if (heiganHealth <= 0)
                {
                    isHeiganAlive = false;
                    break;
                }

                if (playerHealth <= 0)
                {
                    isPlayerAlive = false;
                    isKilledByCloud = true;
                    break;
                }

                var spellArg = Console
                    .ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string spellName = spellArg[0];
                int spellRow = int.Parse(spellArg[1]);
                int spellCol = int.Parse(spellArg[2]);

                GenerateSpellDamageArea(matrix, spellRow, spellCol);

                
                if (matrix[rowPlayer, colPlayer])
                {
                    if (rowPlayer - 1 < 0 || matrix[rowPlayer - 1, colPlayer] == true)
                    {
                        if (colPlayer + 1 > matrix.GetLength(1) - 1 || matrix[rowPlayer, colPlayer + 1] == true)
                        {
                            if (rowPlayer + 1 > matrix.GetLength(0) - 1 || matrix[rowPlayer + 1, colPlayer] == true)
                            {
                                if (colPlayer - 1 < 0 || matrix[rowPlayer, colPlayer - 1] == true)
                                {
                                    if (spellName == "Cloud")
                                    {
                                        playerHealth -= cloudDamage;
                                        isCloudActive = true;
                                        if (playerHealth <= 0)
                                        {
                                            isPlayerAlive = false;
                                            isKilledByCloud = true;
                                            break;
                                        }
                                    }
                                    else if (spellName == "Eruption")
                                    {
                                        playerHealth -= eruptionDamage;
                                        if (playerHealth <= 0)
                                        {
                                            isPlayerAlive = false;
                                            break;
                                        }
                                    }
                                }
                                else
                                {
                                    colPlayer--;
                                }
                            }
                            else
                            {
                                rowPlayer++;
                            }
                        }
                        else
                        {
                            colPlayer++;
                        }
                    }
                    else
                    {
                        rowPlayer--;
                    }
                }

            }

            if (!isHeiganAlive)
            {
                Console.WriteLine("Heigan: Defeated!");
                Console.WriteLine($"Player: {playerHealth}");
                Console.WriteLine($"Final position: {rowPlayer}, {colPlayer}");
            }

            if (!isPlayerAlive)
            {
                string killedBy = isKilledByCloud ? "Plague Cloud" : "Eruption";
                Console.WriteLine($"Heigan: {heiganHealth:f2}");
                Console.WriteLine($"Player: Killed by {killedBy}");
                Console.WriteLine($"Final position: {rowPlayer}, {colPlayer}");
            }
        }

        static void GenerateSpellDamageArea(bool[,] matrix, int row, int col)
        {
            if (row + 1 >= 0 && row + 1 < 15 && col + 1 >= 0 && col + 1 < 15)
            {
                matrix[row + 1, col + 1] = true;
            }

            if (row + 1 >= 0 && row + 1 < 15 && col >= 0 && col < 15)
            {
                matrix[row + 1, col] = true;
            }

            if (row + 1 >= 0 && row + 1 < 15 && col - 1 >= 0 && col - 1 < 15)
            {
                matrix[row + 1, col - 1] = true;
            }

            if (row >= 0 && row < 15 && col - 1 >= 0 && col - 1 < 15)
            {
                matrix[row, col - 1] = true;
            }

            if (row >= 0 && row < 15 && col  >= 0 && col < 15)
            {
                matrix[row, col] = true;
            }

            if (row >= 0 && row < 15 && col + 1 >= 0 && col + 1 < 15)
            {
                matrix[row, col + 1] = true;
            }

            if (row - 1 >= 0 && row - 1 < 15 && col - 1 >= 0 && col - 1 < 15)
            {
                matrix[row - 1, col - 1] = true;
            }

            if (row - 1 >= 0 && row - 1 < 15 && col >= 0 && col < 15)
            {
                matrix[row - 1, col] = true;
            }

            if (row - 1 >= 0 && row - 1 < 15 && col + 1 >= 0 && col + 1 < 15)
            {
                matrix[row - 1, col + 1] = true;
            }
        }

        static bool[,] GenerateMatrix(int x, int y)
        {
            int rows = x;
            int cols = y;
            bool[,] matrix = new bool[rows, cols];
            
            return matrix;
        }
    }
}
