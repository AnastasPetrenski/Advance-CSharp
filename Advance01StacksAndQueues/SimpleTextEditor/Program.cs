namespace SimpleTextEditor
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Program
    {
        public static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder();
            Stack<string> orderOfCommands = new Stack<string>();
            int numberOfCommandsInput = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommandsInput; i++)
            {
                string[] commands = Console
                    .ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();


                if (commands[0] == "1")
                {
                    orderOfCommands.Push(text.ToString());
                    text.Append(commands[1]);
                }
                else if (commands[0] == "2")
                {
                    orderOfCommands.Push(text.ToString());
                    text.Remove(text.Length - int.Parse(commands[1]), int.Parse(commands[1]));
                }
                else if (commands[0] == "3")
                {
                    string element = text.ToString();
                    Console.WriteLine(element[int.Parse(commands[1]) - 1]);
                }
                else if (commands[0] == "4")
                {
                    text.Clear();
                    text.Append(orderOfCommands.Pop());
                    orderOfCommands.TrimExcess();
                }
            }
        }
    }
}