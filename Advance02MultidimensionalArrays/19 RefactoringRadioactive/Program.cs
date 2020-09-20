using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _19_RefactoringRadioactive
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int rows = int.Parse(dimensions[0]);
            int cols = int.Parse(dimensions[1]);
            Position playerPosition = new Position(0, 0);

            char[,] gameField = new char[rows, cols];
            //GenerateGameField(gameField, rows, cols);
            //playerPosition = PlayerNewPosition(playerPosition.Row, playerPosition.Col);


            for (int row = 0; row < rows; row++)
            {
                char[] input = Console.ReadLine().ToArray();
                for (int col = 0; col < cols; col++)
                {
                    gameField[row, col] = input[col];
                    if (input[col] == 'p')
                    {
                        playerPosition.Row = row;
                        playerPosition.Col = col;
                    }
                }
            }

            //input commands: "ULLL" 
            bool isDead = false;
            bool escapedSuccessfully = false;
            char[] commands = Console.ReadLine().ToUpper().ToArray();
            for (int i = 0; i < commands.Length; i++)
            {
                if (commands[i] == 'L')
                {
                    if (playerPosition.Col - 1 < 0)
                    {
                        gameField[playerPosition.Row, playerPosition.Col] = '.';
                        escapedSuccessfully = true;
                    }
                    else if (gameField[playerPosition.Row, playerPosition.Col - 1] == 'B')
                    {
                        gameField[playerPosition.Row, playerPosition.Col] = '.';
                        playerPosition.Col -= 1;
                        isDead = true;
                    }
                    else if (gameField[playerPosition.Row, playerPosition.Col - 1] != 'B' && playerPosition.Col - 1 >= 0)
                    {
                        gameField[playerPosition.Row, playerPosition.Col - 1] = 'P';
                        gameField[playerPosition.Row, playerPosition.Col] = '.';
                        playerPosition.Col -= 1;
                    }
                }
                else if (commands[i] == 'R')
                {
                    if (playerPosition.Col + 1 > gameField.GetLength(1) - 1)
                    {
                        gameField[playerPosition.Row, playerPosition.Col] = '.';
                        escapedSuccessfully = true;
                    }
                    else if (gameField[playerPosition.Row, playerPosition.Col + 1] == 'B')
                    {
                        gameField[playerPosition.Row, playerPosition.Col] = '.';
                        playerPosition.Col += 1;
                        isDead = true;
                    }
                    else if (gameField[playerPosition.Row, playerPosition.Col + 1] != 'B' && playerPosition.Col + 1 < gameField.GetLength(1))
                    {
                        gameField[playerPosition.Row, playerPosition.Col + 1] = 'P';
                        gameField[playerPosition.Row, playerPosition.Col] = '.';
                        playerPosition.Col += 1;
                    }
                }
                else if (commands[i] == 'U')
                {
                    if (playerPosition.Row - 1 < 0)
                    {
                        gameField[playerPosition.Row, playerPosition.Col] = '.';
                        escapedSuccessfully = true;
                    }
                    else if (gameField[playerPosition.Row - 1, playerPosition.Col] == 'B')
                    {
                        gameField[playerPosition.Row, playerPosition.Col] = '.';
                        playerPosition.Row -=  1;
                        isDead = true;
                    }
                    else if (gameField[playerPosition.Row - 1, playerPosition.Col] != 'B' && playerPosition.Row - 1 >= 0)
                    {
                        gameField[playerPosition.Row - 1, playerPosition.Col] = 'P';
                        gameField[playerPosition.Row, playerPosition.Col] = '.';
                        playerPosition.Row -= 1;
                    }
                }
                else if (commands[i] == 'D')
                {
                    if (playerPosition.Row + 1 > gameField.GetLength(0) - 1)
                    {
                        gameField[playerPosition.Row, playerPosition.Col] = '.';
                        escapedSuccessfully = true;
                    }
                    else if (gameField[playerPosition.Row + 1, playerPosition.Col] == 'B')
                    {
                        gameField[playerPosition.Row, playerPosition.Col] = '.';
                        playerPosition.Row += 1;
                        isDead = true;
                    }
                    else if (gameField[playerPosition.Row + 1, playerPosition.Col] != 'B' && playerPosition.Row + 1 >= 0)
                    {
                        gameField[playerPosition.Row + 1, playerPosition.Col] = 'P';
                        gameField[playerPosition.Row, playerPosition.Col] = '.';
                        playerPosition.Row += 1;
                    }
                }

                List<Position> rabbitsNewPositions = new List<Position>();
                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        if (gameField[row, col] == 'B')
                        {
                            Position rabbit = new Position(row, col);
                            rabbitsNewPositions.Add(rabbit);
                        }
                    }
                }


                for (int j = 0; j < rabbitsNewPositions.Count; j++)
                {
                    var row = rabbitsNewPositions[j].Row;
                    var col = rabbitsNewPositions[j].Col;
                    if (gameField[row, col] == 'B')
                    {
                        //up propagation
                        if (row - 1 >= 0 && gameField[row - 1, col] == '.')
                        {
                            gameField[row - 1, col] = 'B';
                        }
                        else if (row - 1 >= 0 && gameField[row - 1, col] == 'P')
                        {
                            gameField[row - 1, col] = 'B';
                            isDead = true;
                        }
                        //down propagation
                        if (row + 1 <= gameField.GetLength(0) - 1 && gameField[row + 1, col] == '.')
                        {
                            gameField[row + 1, col] = 'B';
                        }
                        else if (row + 1 <= gameField.GetLength(0) - 1 && gameField[row + 1, col] == 'P')
                        {
                            gameField[row + 1, col] = 'B';
                            isDead = true;
                        }
                        //right propagation
                        if (col + 1 <= gameField.GetLength(1) - 1 && gameField[row, col + 1] == '.')
                        {
                            gameField[row, col + 1] = 'B';
                        }
                        else if (col + 1 <= gameField.GetLength(1) - 1 && gameField[row, col + 1] == 'P')
                        {
                            gameField[row, col + 1] = 'B';
                            isDead = true;
                        }
                        //left propagation
                        if (col - 1 >= 0 && gameField[row, col - 1] == '.')
                        {
                            gameField[row, col - 1] = 'B';
                        }
                        else if (col - 1 >= 0 && gameField[row, col - 1] == 'P')
                        {
                            gameField[row, col - 1] = 'B';
                            isDead = true;
                        }
                    }
                }


                if (escapedSuccessfully)
                {
                    PrintGameField(gameField);
                    Console.WriteLine($"won: {playerPosition.Row} {playerPosition.Col}");
                    return;
                }
                if (isDead)
                {
                    PrintGameField(gameField);
                    Console.WriteLine($"dead: {playerPosition.Row} {playerPosition.Col}");
                    return;
                }
            }
        }

        public static Position PlayerNewPosition(int row, int col)
        {
            Position playerPosition = new Position(row, col);
            playerPosition.Row = row;
            playerPosition.Col = col;
            return playerPosition;
        }

        public static char[,] GenerateGameField(char[,] gameField, int rows, int cols)
        {
            for (int row = 0; row < rows; row++)
            {
                char[] input = Console.ReadLine().ToArray();
                for (int col = 0; col < cols; col++)
                {
                    gameField[row, col] = input[col];
                    if (input[col] == 'P')
                    {
                        //TODO playerPosition
                        PlayerNewPosition(row, col);
                    }
                }
            }

            return gameField;
        }

        public static void PrintGameField(char[,] gameField)
        {
            for (int row = 0; row < gameField.GetLength(0); row++)
            {
                for (int col = 0; col < gameField.GetLength(1); col++)
                {
                    Console.Write(gameField[row, col]);
                }
                Console.WriteLine();
            }
        }
    }

    public class Position
    {
        public int Row;
        public int Col;

        public Position(int row, int col)
        {
            this.Row = row;
            this.Col = col;
        }
    }
}

