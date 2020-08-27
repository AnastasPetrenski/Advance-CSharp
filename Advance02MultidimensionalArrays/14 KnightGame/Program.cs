using System;
using System.Collections.Generic;
using System.Linq;

namespace _14_KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var matrix = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                char[] temp = Console.ReadLine().ToCharArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = temp[col];
                }
            }

            int counter = 0;
            Dictionary<string, int> knights = new Dictionary<string, int>();
            while (true)
            {
                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        if (matrix[row, col] == 'K')
                        {
                            if (row + 2 < n && col + 1 < n)
                            {
                                if (matrix[row + 2, col + 1] == 'K')
                                {
                                    string key = row.ToString() + "|" + col;
                                    AddKnight(knights, key);
                                }
                            }

                            if (row + 2 < n && col - 1 >= 0)
                            {
                                if (matrix[row + 2, col - 1] == 'K')
                                {
                                    string key = row.ToString() + "|" + col;
                                    AddKnight(knights, key);
                                }
                            }

                            if (row - 2 >= 0 && col + 1 < n)
                            {
                                if (matrix[row - 2, col + 1] == 'K')
                                {
                                    string key = row.ToString() + "|" + col;
                                    AddKnight(knights, key);
                                }
                            }

                            if (row - 2 >= 0 && col - 1 >= 0)
                            {
                                if (matrix[row - 2, col - 1] == 'K')
                                {
                                    string key = row.ToString() + "|" + col;
                                    AddKnight(knights, key);
                                }
                            }

                            if (col + 2 < n && row + 1 < n)
                            {
                                if (matrix[row + 1, col + 2] == 'K')
                                {
                                    string key = row.ToString() + "|" + col;
                                    AddKnight(knights, key);
                                }
                            }

                            if (col + 2 < n && row - 1 >= 0)
                            {
                                if (matrix[row - 1, col + 2] == 'K')
                                {
                                    string key = row.ToString() + "|" + col;
                                    AddKnight(knights, key);
                                }
                            }

                            if (col - 2 >= 0 && row + 1 < n)
                            {
                                if (matrix[row + 1, col - 2] == 'K')
                                {
                                    string key = row.ToString() + "|" + col;
                                    AddKnight(knights, key);
                                }
                            }

                            if (col - 2 >= 0 && row - 1 >= 0)
                            {
                                if (matrix[row - 1, col - 2] == 'K')
                                {
                                    string key = row.ToString() + "|" + col;
                                    AddKnight(knights, key);
                                }
                            }

                        }
                    }
                }

                
                knights = knights.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, y => y.Value);
                if (knights.Sum(x => x.Value) > 0)
                {
                    foreach (var item in knights)
                    {
                        var removed = item.Key;
                        var delimiter = removed.IndexOf('|');
                        int row = int.Parse(removed.Substring(0, delimiter));
                        int col = int.Parse(removed.Substring(delimiter + 1));

                        matrix[row, col] = '0';
                        counter++;
                        break;
                    }
                    knights.Clear();
                }
                else
                {
                    Console.WriteLine(counter);
                    break;
                }
            }
        }

        public static Dictionary<string, int> AddKnight(Dictionary<string, int> knights, string key)
        {
            if (!knights.ContainsKey(key))
            {
                knights.Add(key, 1);
            }
            else
            {
                knights[key]++;
            }

            return knights;
        }
    }
}
