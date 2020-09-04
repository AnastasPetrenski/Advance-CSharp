using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vip = new HashSet<string>();
            HashSet<string> guests = new HashSet<string>();
            string command = string.Empty;
            bool partyTime = false;
            while ((command = Console.ReadLine()) != "END")
            {
                if (command == "PARTY")
                {
                    partyTime = true;
                    continue;
                }

                if (partyTime)
                {
                    if (guests.Contains(command))
                    {
                        guests.Remove(command);
                    }
                    else
                    {
                        vip.Remove(command);
                    }
                }
                else
                {
                    char firstElement = command[0];
                    if (char.IsDigit(firstElement))
                    {
                        vip.Add(command);
                    }
                    else
                    {
                        guests.Add(command);
                    }
                }
            }

            Console.WriteLine(guests.Count + vip.Count);
            if (vip.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, vip));
            }
            if (guests.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, guests));
            }
        }
    }
}
