using System;
using System.Linq;

namespace DateModifier
{
    public class DateModifier
    {
    //    private string startDate;
    //    private string endDate;

    //    public DateModifier()
    //    {
    //        this.StartDate = startDate;
    //        this.EndDate = endDate;
    //    }

    //    public string StartDate { get; set; }
    //    public string EndDate { get; set; }

        public void CalculateDifference(string start, string end)
        {

            int[] firstDate = start.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            DateTime dateStart = new DateTime(firstDate[0], firstDate[1], firstDate[2]);

            int[] secondDate = end.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            DateTime dateEnd = new DateTime(secondDate[0], secondDate[1], secondDate[2]);

            var x = Math.Abs((dateEnd - dateStart).TotalDays);

            Console.WriteLine((int)x); 
        }
    }
}
