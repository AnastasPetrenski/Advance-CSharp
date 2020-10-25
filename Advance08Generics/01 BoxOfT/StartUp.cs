using System;

namespace BoxOfT
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Box<string> box = new Box<string>();
            box.Add(input);
            box.Add(input);
            box.Remove();

            Console.WriteLine(box.Count);
        }
    }
}
