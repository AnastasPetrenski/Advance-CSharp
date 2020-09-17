using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _05_FilterByAge
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person()
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> persons = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                var inputData = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                Person person = new Person();
                person.Name = inputData[0];
                person.Age = int.Parse(inputData[1]);
                persons.Add(person);                
            }

            string condition = Console.ReadLine();
            int ageComparer = int.Parse(Console.ReadLine());
            string outputFormat = Console.ReadLine();

            Func<Person, bool> filter = condition switch
            {
                "older" => p => p.Age >= ageComparer,
                "younger" => p => p.Age < ageComparer,
                _=> p => true,
            };

            persons = persons.Where(filter).ToList();


            Action<string, List<Person>> tryPrint = PrintResult;
            tryPrint(outputFormat, persons);
            //PrintResult(outputFormat, persons);
        }

        public static void PrintResult(string outputFormat, List<Person> persons)
        {
            foreach (var person in persons)
            {
                var output = outputFormat
                    .Replace("age", person.Age.ToString())
                    .Replace("name", person.Name);
                if (outputFormat == "name age")
                {
                    output = output.Insert(person.Name.Length + 1, "- ");
                }
                
                Console.WriteLine(output);
            }
        }
    }
}
