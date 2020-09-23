using System;

namespace _26_TheHeiganDanceSecond
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerRow = 7;
            int playerCol = 7;

            double playerHP = 18500;
            double heiganHP = 3000000;
            double playerDamage = double.Parse(Console.ReadLine());
            String lastSpell = "";
            while (true)
            {
                if (playerHP >= 0)
                {
                    heiganHP -= playerDamage;
                }
                if (lastSpell.Equals("Cloud"))
                {
                    playerHP -= 3500;
                }
                if (heiganHP <= 0 || playerHP <= 0)
                {
                    break;
                }
                String[] input = Console.ReadLine().Split(" ");
                String currentSpell = input[0];
                int targetRow = int.Parse(input[1]);
                int targetCol = int.Parse(input[2]);
                if (isInDamageArea(targetRow, targetCol, playerRow, playerCol))
                {
                    if (!isInDamageArea(targetRow, targetCol, playerRow - 1, playerCol) && !isWall(playerRow - 1))
                    {
                        playerRow--;
                        lastSpell = "";
                    }
                    else if (!isInDamageArea(targetRow, targetCol, playerRow, playerCol + 1) && !isWall(playerCol + 1))
                    {
                        playerCol++;
                        lastSpell = "";
                    }
                    else if (!isInDamageArea(targetRow, targetCol, playerRow + 1, playerCol) && !isWall(playerRow + 1))
                    {
                        playerRow++;
                        lastSpell = "";
                    }
                    else if (!isInDamageArea(targetRow, targetCol, playerRow, playerCol - 1) && !isWall(playerCol - 1))
                    {
                        playerCol--;
                        lastSpell = "";
                    }
                    else
                    {
                        if (currentSpell.Equals("Cloud"))
                        {
                            playerHP -= 3500;
                            lastSpell = "Cloud";
                        }
                        else if (currentSpell.Equals("Eruption"))
                        {
                            playerHP -= 6000;
                            lastSpell = "Eruption";
                        }
                    }
                }
            }
            lastSpell = lastSpell.Equals("Cloud") ? "Plague Cloud" : "Eruption";
            String heiganState = heiganHP <= 0 ? "Heigan: Defeated!" : $"Heigan: {heiganHP:f2}";
            String playerState = playerHP <= 0 ? $"Player: Killed by {lastSpell}" :
                    $"Player: {playerHP}";
            String playerEndCoordinates = $"Final position: {playerRow}, {playerCol}";

            Console.WriteLine(heiganState);
            Console.WriteLine(playerState);
            Console.WriteLine(playerEndCoordinates);
        }

        private static bool isWall(int moveCell)
        {
            return moveCell < 0 || moveCell >= 15;
        }

        private static bool isInDamageArea(int targetRow, int targetCol, int moveRow, int moveCol)
        {
            return ((targetRow - 1 <= moveRow && moveRow <= targetRow + 1)
                    && (targetCol - 1 <= moveCol && moveCol <= targetCol + 1));
        }
    }
}
