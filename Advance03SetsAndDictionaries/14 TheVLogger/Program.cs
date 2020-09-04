using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _14_TheVLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vlogger> users = new List<Vlogger>();
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Statistics")
            {
                List<string> input = command
                    .Split()
                    .ToList();
                string firstUser = input[0];
                string action = input[1];
                string secondUser = input[2];

                if (action == "joined")
                {
                    if (!users.Any(x => x.Name.Contains(firstUser)))
                    {
                        Vlogger vlloger = new Vlogger(firstUser);
                        users.Add(vlloger);
                    }
                }
                else if (action == "followed" && users.Any(x => x.Name.Contains(firstUser)) && users.Any(x => x.Name.Contains(secondUser)) && firstUser != secondUser)
                {
                    //Saffrona followed EmilConrad - Saffora following EmilConrad // == // EmilConrad have a follower Saffora
                    foreach (var item in users.Where(x => x.Name == firstUser))
                    {
                        item.Followings.Add(secondUser);
                        break;
                    }

                    foreach (var item in users.Where(x => x.Name == secondUser))
                    {
                        item.Followers.Add(firstUser);
                        break;
                    }

                }
            }

            int counter = 1;
            Console.WriteLine($"The V-Logger has a total of {users.Count} vloggers in its logs.");
            if (users.Any(x => x.Followers.Count > 0))
            {
                foreach (var item in users.OrderByDescending(x => x.Followers.Count).ThenBy(x => x.Followings.Count))
                {
                    if (counter == 1)
                    {
                        Console.WriteLine($"{counter}. {item.Name} : {item.Followers.Count} followers, {item.Followings.Count} following");
                        foreach (var follower in item.Followers.OrderBy(x => x))
                        {
                            Console.WriteLine($"*  {follower}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{counter}. {item.Name} : {item.Followers.Count} followers, {item.Followings.Count} following");
                    }
                    
                    counter++;
                }
            }
        }
    }

    public class Vlogger
    {
        public string Name { get; set; }
        public HashSet<string> Followers { get; set; }
        public HashSet<string> Followings { get; set; }

        public Vlogger(string name)
        {
            this.Name = name;
            this.Followers = new HashSet<string>();
            this.Followings = new HashSet<string>();
        }
    }

}
