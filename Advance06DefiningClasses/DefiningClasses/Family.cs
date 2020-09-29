﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        private HashSet<Person> members;

        public Family()
        {
            this.members = new HashSet<Person>();
        }

        public void AddMember(Person member)
        {
            this.members.Add(member);
        }

        public Person GetOldestMember()
        {
            Person oldestPerson = this.members
                .OrderByDescending(p => p.Age)
                .FirstOrDefault();

            return oldestPerson;
        }

        public string PrintMembersMoreThan30years()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var person in members.OrderBy(p => p.Name))
            {
                if (person.Age > 30)
                {
                    sb.Append(person.ToString());
                    sb.AppendLine();
                }
            }

            return sb.ToString().Trim();
        }
    }
}
