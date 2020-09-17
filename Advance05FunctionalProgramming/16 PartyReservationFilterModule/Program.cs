using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace _16_PartyReservationFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<Filter> filters = new List<Filter>();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Print")
            {
                var commands = input
                    .Split(";", StringSplitOptions.RemoveEmptyEntries);
                string filterType = commands[0];
                string predicateType = commands[1];
                string filterCriterion = commands[2];

                if (filterType == "Add filter")
                {
                    filters.Add(AddFilter(predicateType, filterCriterion));
                }
                else if (filterType == "Remove filter")
                {
                    filters = RemoveFilter(filters, predicateType, filterCriterion);
                }
            }
            
            foreach (var filter in filters)
            {
                names = FilterNames(names, filter.Type, filter.Criterion);
            }

            if (names.Any())
            {
                Console.WriteLine(string.Join(" ", names));
            }
            
        }
        
        static List<string> FilterNames(List<string> names, string predicateType, string filterCriterion)
        {
            List<string> current = new List<string>();
            if (predicateType == "Starts with")
            {
                current = names.Where(x => !x.StartsWith(filterCriterion)).ToList();
            }
            if (predicateType == "Ends with")
            {
                current = names.Where(x => !x.EndsWith(filterCriterion)).ToList();
            }
            if (predicateType == "Length")
            {
                current = names.Where(x => x.Length != int.Parse(filterCriterion)).ToList();
            }
            if (predicateType == "Contains")
            {
                current = names.Where(x => !x.Contains(filterCriterion)).ToList();
            }

            return current;
        }

        static List<Filter> RemoveFilter(List<Filter> filter, string predicateType, string filterCriterion)
        {
            filter.RemoveAll(x => x.Type == predicateType && x.Criterion == filterCriterion);
            return filter;
        }

        static Filter AddFilter(string type, string criterion)
        {
            Filter filter = new Filter();
            filter.Type = type;
            filter.Criterion = criterion;

            return filter;
        }
    }

    class Filter
    {
        public string Type { get; set; }
        public string Criterion { get; set; }
    }
}
