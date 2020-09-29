using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family members = new Family();
           
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];
                int age = int.Parse(input[1]);
                Person person = new Person(name, age);
                members.AddMember(person);
            }

            //Console.WriteLine(members.GetOldestMember().ToString());

            Console.WriteLine(members.PrintMembersMoreThan30years());
        }
    }
}
