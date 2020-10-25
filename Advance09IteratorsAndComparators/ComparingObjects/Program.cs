using System;
using System.Collections.Generic;
using System.Linq;

namespace ComparingObjects
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "END")
            {
                var personArg = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Person person = new Person();
                person.Name = personArg[0];
                person.Age = int.Parse(personArg[1]);
                person.Town = personArg[2];
                people.Add(person);
            }

            int index = int.Parse(Console.ReadLine());
            var chosen = people[index - 1];

            int equals = 0;
            foreach (var item in people)
            {
                if (item.CompareTo(chosen) == 0)
                {
                    equals++;
                }
            }

            if (equals > 1)
            {
                Console.WriteLine($"{equals} {people.Count - equals} {people.Count}");
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
    }
}
