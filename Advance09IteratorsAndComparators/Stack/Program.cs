using System;
using System.Linq;

namespace Stack
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stack<string> myStack = new Stack<string>();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "END")
            {
                var commands = command.Split(new char[] { ' ', ','} , StringSplitOptions.RemoveEmptyEntries);
                if (commands[0] == "Push")
                {
                    var input = commands.Skip(1).ToArray();
                    for (int i = 0; i < input.Length; i++)
                    {
                        myStack.Push(input[i]);
                    }
                    
                }
                else if (commands[0] == "Pop")
                {
                    try
                    {
                        myStack.Pop();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    
                }
            }

            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }

            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
