using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _15_Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> credentials = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> contestResults = new Dictionary<string, Dictionary<string, int>>();
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end of contests")
            {
                string[] contestInfo = command
                    .Split(":", StringSplitOptions.RemoveEmptyEntries);
                string contestName = contestInfo[0];
                string contestPassword = contestInfo[1];
                credentials.Add(contestName, contestPassword);
            }

            //Js Fundamentals=>Pesho=>Tanya=>400
            while ((command = Console.ReadLine()) != "end of submissions")
            {
                string[] contestData = command
                    .Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string contestName = contestData[0];
                string contestPassword = contestData[1];
                string userName = contestData[2];
                int userPoints = int.Parse(contestData[3]);

                if (credentials.ContainsKey(contestName) && credentials[contestName] == contestPassword)
                {
                    if (!contestResults.ContainsKey(userName))
                    {
                        contestResults.Add(userName, new Dictionary<string, int>());
                    }

                    if (!contestResults[userName].ContainsKey(contestName))
                    {
                        contestResults[userName].Add(contestName, userPoints);
                    }

                    if (contestResults[userName][contestName] < userPoints)
                    {
                        contestResults[userName][contestName] = userPoints;
                    }
                }
            }
            
            string bestCandidateName = string.Empty;
            int bestCandidatePoints = 0;
            foreach (var user in contestResults)
            {
                int sum = user.Value.Values.Sum();
                if (sum > bestCandidatePoints)
                {
                    bestCandidatePoints = sum;
                    bestCandidateName = user.Key;
                }
            }
            var x = contestResults.Max(x => x.Value.Values.Sum());

            Console.WriteLine($"Best candidate is {bestCandidateName} with total {bestCandidatePoints} points.");
            Console.WriteLine("Ranking:");
            foreach (var (userName, userGrades)  in contestResults.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{userName}");
                foreach (var grade in userGrades.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {grade.Key} -> {grade.Value}");
                }
            }
        }
    }
}
