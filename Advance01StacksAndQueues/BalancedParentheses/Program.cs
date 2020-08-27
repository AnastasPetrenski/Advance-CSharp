using System;
using System.Collections.Generic;
using System.Linq;

namespace BalancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Queue<char> sequence = new Queue<char>(input);
            Stack<char> brackets = new Stack<char>();
            while(sequence.Any())
            {
                char currentElement = sequence.Dequeue();
                if (currentElement == '(' || currentElement == '{' || currentElement == '[')
                {
                    brackets.Push(currentElement);
                    continue;
                }
                else
                {
                    if (currentElement == ')')
                    {
                        if (brackets.TryPop(out char lastElement))
                        {
                            if (lastElement == '(')
                            {
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                        }
                        else
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                    }
                    if (currentElement == '}')
                    {
                        if (brackets.TryPop(out char lastElement))
                        {
                            if (lastElement == '{')
                            {
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                        }
                        else
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                    }
                    if (currentElement == ']')
                    {
                        if (brackets.TryPop(out char lastElement))
                        {
                            if (lastElement == '[')
                            {
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                        }
                        else
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                    }
                }
            }

            if (brackets.Count > 0)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
        }
    }
}