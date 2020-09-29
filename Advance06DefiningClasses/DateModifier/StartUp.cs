namespace DateModifier
{
    using System;

    public class StartUp
    {
        static void Main(string[] args)
        {
            string start = Console.ReadLine();
            string end = Console.ReadLine();

            DateModifier date = new DateModifier();

            date.CalculateDifference(start, end);
            
        }
    }
}
