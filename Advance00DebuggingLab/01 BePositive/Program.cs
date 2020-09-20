namespace BePositive
{
    using System;
    using System.Collections.Generic;

    public class BePositiveMain
    {
        public static void Main()
        {
            int countSequences = int.Parse(Console.ReadLine());
            

            for (int i = 0; i < countSequences; i++)
            {
                bool found = false;
                string[] input = Console.ReadLine().Trim().Split(' ');
                var numbers = new List<int>();

                for (int j = 0; j < input.Length; j++)
                {
                    if (!input[j].Equals(string.Empty))
                    {
                        int num = int.Parse(input[j]);
                        numbers.Add(num);
                    }
                }

                List<int> result = new List<int>();

                for (int j = 0; j < numbers.Count; j++)
                {
                    int currentNum = numbers[j];

                    if (currentNum >= 0)
                    {
                        result.Add(currentNum);
                    }
                    else
                    {
                        if (j+1 < numbers.Count)
                        {
                            currentNum += numbers[j + 1];
                            j++;
                        }

                        if (currentNum >= 0)
                        {
                            result.Add(currentNum);
                        }
                    }
                    
                }

                if (result.Count <= 0)
                {
                    Console.WriteLine("(empty)");
                }
                else
                {
                    Console.WriteLine(string.Join(" ", result));
                }
            }

            
        }
    }
}