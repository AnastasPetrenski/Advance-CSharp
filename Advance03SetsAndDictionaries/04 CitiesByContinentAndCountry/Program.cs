using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace _04_CitiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var members = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split();
                string continent = input[0];
                string country = input[1];
                string town = input[2];

                if (!members.ContainsKey(continent))
                {
                    members.Add(continent, new Dictionary<string, List<string>>());
                }

                if (!members[continent].ContainsKey(country))
                {
                    members[continent].Add(country, new List<string>());
                }

                members[continent][country].Add(town);
                
            }

            foreach (var continent in members)
            {
                Console.WriteLine($"{continent.Key}:");
                foreach (var (country, town) in continent.Value)
                {
                    Console.WriteLine($" {country} -> {string.Join(", ", town)}");
                }
            }
        }
    }
}
