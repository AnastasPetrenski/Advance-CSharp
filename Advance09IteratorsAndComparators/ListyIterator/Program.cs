using System;
using System.Linq;

namespace ListyIterator
{
    public class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            ListyIterator<string> list = null;
            while ((command = Console.ReadLine()) != "END")
            {   
                var commands = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (commands[0] == "Create")
                {
                    list = new ListyIterator<string>(commands.Skip(1).ToArray());
                }
                else if (commands[0] == "HasNext" || commands[0] == "Move")
                {
                    var result = commands[0] switch
                    {
                        "Move" => list.Move(),
                        "HasNext" => list.HasNext()
                    };
                    Console.WriteLine(result);
                }
                else if (commands[0] == "Print")
                {
                    try
                    {
                        list.Print();
                    }
                    catch (Exception e)
                    {

                        throw new InvalidOperationException(e.Message);
                    }
                }
                else
                {
                    try
                    {
                        list.PrintAll();
                    }
                    catch (Exception e)
                    {

                        throw new InvalidOperationException(e.Message);
                    }
                    
                }
            }
        }
    }
}
