using System;

namespace Lab102DifferenceBetweenDate
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define variables 
            DateTime FirstDate;
            DateTime LastDate;
            TimeSpan DateDifference;

            // inputs 
            Console.WriteLine("Please enter first date in dd/mm/yyyy format");
            FirstDate = Convert.ToDateTime(Console.ReadLine()).Date;

            Console.WriteLine("Please enter last date in dd/mm/yyyy format");
            LastDate = Convert.ToDateTime(Console.ReadLine()).Date;

             LastDate.Subtract(FirstDate);
            
            // Print the result
            Console.WriteLine(String.Format("{0} days, {1} hours, {2} minutes, {3} seconds", DateDifference.Days, DateDifference.Hours, DateDifference.Minutes, DateDifference.Seconds));
            Console.ReadLine();

        }
    }
}
