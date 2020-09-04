using System;
using System.Collections.Generic;
using System.Linq;

namespace _13_Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int linesOfClothes = int.Parse(Console.ReadLine());
            var wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < linesOfClothes; i++)
            {
                //Blue->dress,jeans,hat
                List<string> input = Console.ReadLine()
                    .Split(new string[] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                for (int j = 0; j < input.Count; j++)
                {
                    string color = input[0];
                    if (!wardrobe.ContainsKey(color))
                    {
                        wardrobe.Add(color, new Dictionary<string, int>());
                    }

                    if (j != 0 && !wardrobe[color].ContainsKey(input[j]))
                    {
                        wardrobe[color].Add(input[j], 0);
                    }
                    if (j != 0)
                    {
                        wardrobe[color][input[j]]++;
                    }
                }
            }
            string[] lookupCloth = Console.ReadLine()
                    .Split();
            string lookupColor = lookupCloth[0];
            string lookupClothing = lookupCloth[1];
            foreach (var color in wardrobe)
            {
                bool isColorFound = false;
                if (color.Key == lookupColor)
                {
                    isColorFound = true;
                }
                Console.WriteLine($"{color.Key} clothes:");
                foreach (var (cloth, count) in color.Value)
                {
                    bool isClothFound = false;
                    if (cloth == lookupClothing)
                    {
                        isClothFound = true;
                    }

                    if (isColorFound && isClothFound)
                    {
                        Console.WriteLine($"* {cloth} - {count} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloth} - {count}");
                    }

                }
            }
        }
    }
}
