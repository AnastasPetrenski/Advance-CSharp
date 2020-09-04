using System;
using System.Collections.Generic;
using System.Linq;

namespace _16_Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> commands = ConvertInputToArray();
            var startPosition = new KeyValuePair<int, int>();
            int coals = 0;

            var matrix = new string[n, n];
            for (int row = 0; row < n; row++)
            {
                var input = ConvertInputToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = input[col];
                    if (input[col] == "s")
                    {
                        startPosition = new KeyValuePair<int, int>(row, col);
                    }
                    else if (input[col] == "c")
                    {
                        coals++; 
                    }
                }
            }

            int totalCoals = 0;
            bool isEndOccurred = false;
            for (int i = 0; i < commands.Count; i++)
            {
                if (commands[i].Equals("up"))
                {
                    if (startPosition.Key - 1 >= 0)
                    {
                        string letter = matrix[startPosition.Key - 1, startPosition.Value];
                        if (letter.Equals("c"))
                        {
                            totalCoals++;
                            matrix[startPosition.Key - 1, startPosition.Value] = "*";
                        }
                        else if (letter == "e")
                        {
                            isEndOccurred = true;
                            startPosition = new KeyValuePair<int, int>(startPosition.Key - 1, startPosition.Value);
                            break;
                        }
                        startPosition = new KeyValuePair<int, int>(startPosition.Key - 1, startPosition.Value);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (commands[i] == "down")
                {
                    if (startPosition.Key + 1 < matrix.GetLength(0))
                    {
                        string letter = matrix[startPosition.Key + 1, startPosition.Value];
                        if (letter == "c")
                        {
                            totalCoals++;
                            matrix[startPosition.Key + 1, startPosition.Value] = "*";
                        }
                        else if (letter == "e")
                        {
                            startPosition = new KeyValuePair<int, int>(startPosition.Key + 1, startPosition.Value);
                            isEndOccurred = true;
                            break;
                        }
                        startPosition = new KeyValuePair<int, int>(startPosition.Key + 1, startPosition.Value);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (commands[i] == "right")
                {
                    if (startPosition.Value + 1 < matrix.GetLength(1))
                    {
                        string letter = matrix[startPosition.Key, startPosition.Value + 1];
                        if (letter == "c")
                        {
                            totalCoals++;
                            matrix[startPosition.Key, startPosition.Value + 1] = "*";
                        }
                        else if (letter == "e")
                        {
                            isEndOccurred = true;
                            startPosition = new KeyValuePair<int, int>(startPosition.Key, startPosition.Value + 1);
                            break;
                        }
                        startPosition = new KeyValuePair<int, int>(startPosition.Key, startPosition.Value + 1);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (commands[i] == "left")
                {
                    if (startPosition.Value - 1 >= 0)
                    {
                        string letter = matrix[startPosition.Key, startPosition.Value - 1];
                        if (letter == "c")
                        {
                            totalCoals++;
                            matrix[startPosition.Key, startPosition.Value - 1] = "*";
                        }
                        else if (letter == "e")
                        {
                            isEndOccurred = true;
                            startPosition = new KeyValuePair<int, int>(startPosition.Key, startPosition.Value - 1);
                            break;
                        }

                        startPosition = new KeyValuePair<int, int>(startPosition.Key, startPosition.Value - 1);
                    }
                    else
                    {
                        continue;
                    }
                }

                if (totalCoals == coals)
                {
                    Console.WriteLine($"You collected all coals! ({startPosition.Key}, {startPosition.Value})");
                    return;
                }
            }

            if (isEndOccurred)
            {
                Console.WriteLine($"Game over! ({startPosition.Key}, {startPosition.Value})");
            }
            else
            {
                Console.WriteLine($"{coals - totalCoals} coals left. ({startPosition.Key}, {startPosition.Value})");
            }
        }

        public static List<string> ConvertInputToArray()
            => Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
    }
}
