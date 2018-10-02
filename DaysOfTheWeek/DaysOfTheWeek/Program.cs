using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfTheWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the current day of the Week...");
            string day = Console.ReadLine();

            try
            {
                Enum.Parse(typeof(daysOfTheWeek), day);
            }
            catch
            {
                Console.WriteLine("Please Enter an actual Day of the Week.. First letter capital");
            }
            
            Console.Read();
            
        }

            public enum daysOfTheWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
      }
}
