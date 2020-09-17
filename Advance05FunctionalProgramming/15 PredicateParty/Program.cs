using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;

namespace _15_PredicateParty
{
    class Program
    {
        static void Main(string[] args)
        {
            var guests = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Party!")
            {
                var commands = input.Split();
                var action = commands[0];
                var condition = commands[1];
                var value = commands[2];

                Predicate<string> checker = RemoveGuestsPredicate(condition, value);

                if (action == "Remove")
                {
                       guests.RemoveAll(checker);
                }
                else if (action == "Double")
                {
                    DoubleGuests(guests, checker);
                }
            }

            PrintGuests(guests);
        }

        private static void PrintGuests(List<string> guests)
        {
            if (guests.Count > 0)
            {
                Console.WriteLine($"{string.Join(", ", guests)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        private static void DoubleGuests(List<string> guests, Predicate<string> checker)
        {
            for (int i = 0; i < guests.Count; i++)
            {
                var guest = guests[i];
                if (checker(guest))
                {
                    guests.Insert(i + 1, guest);
                    i++;
                }
            }
        }   

        public static Predicate<string> RemoveGuestsPredicate(string condition, string value)
        {
            Predicate<string> predicate = name => false;

            if (condition == "StartsWith")
            {
                predicate = (name) =>
                {
                    return name.StartsWith(value);
                };
            }
            else if (condition == "EndsWith")
            {
                predicate = (name) =>
                {
                    return name.EndsWith(value);
                };
            }
            else if (condition == "Length")
            {
                predicate = (name) =>
                {
                    return name.Length == int.Parse(value);
                };
            }

            return predicate;
        }
    }
}
