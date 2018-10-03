using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int hours = Convert.ToInt32(Console.ReadLine());
            DateTime itIs = new DateTime();
            DateTime itWillbe = new DateTime();
            itIs = DateTime.Now;
            itWillbe = itIs.AddHours(hours);
            Console.WriteLine(itIs);
            Console.WriteLine("It will be {0} in {1} hours", itWillbe, hours);
            Console.Read();
        }
    }
}
