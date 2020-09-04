using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _02_AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberInput = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < numberInput; i++)
            {
                string[] studentInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string studentName = studentInfo[0];
                decimal studentGrade = decimal.Parse(studentInfo[1]);
                if (!students.ContainsKey(studentName))
                {
                    students.Add(studentName, new List<decimal>());
                }

                students[studentName].Add(studentGrade);
            }

            foreach (var (key, value) in students)
            {
                var allGrades = string.Join(" ", value.Select(x => x.ToString("F2")));
                decimal averageGrades = 0;
                if (value.Count > 0)
                {
                    averageGrades = value.Average();
                }
                Console.WriteLine($"{key} -> {allGrades} (avg: {averageGrades:F2})");
            }
        }
    }
}
