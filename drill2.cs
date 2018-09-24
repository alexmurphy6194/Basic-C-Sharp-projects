using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What course are you on?");
            String userCourse = Console.ReadLine();
            Console.WriteLine("What page number?");
            String userPageNum = Console.ReadLine();
            int pageNum = Convert.ToInt32(userPageNum);
            Console.WriteLine("Do you need help with anything? Please answer “true” or “false”.");
            bool Help = bool.Parse(Console.ReadLine());
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            String positive = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            String feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study this week?");
            int hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.Read();
        }
    }
}
