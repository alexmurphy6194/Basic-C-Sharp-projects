using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age");
            int age=0;
            try
            {
                age = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Please only enter a number");
                Console.Read();
            }
            try {
                if (age < 0) { throw new negativeInput(); }
            }
            catch (negativeInput)
            {
                Console.WriteLine("You entered a negative number, please enter your correct age");
                Console.Read();
            }
            try
            {
                if (age==0) { throw new zeroException(); }
            }
            catch (zeroException)
            {
                Console.WriteLine("You entered zero, please enter your correct age");
                Console.Read();
            }
           

            var dateNow = new DateTime();
            var yearBorn = new DateTime();
            dateNow = DateTime.Now;
            yearBorn = dateNow.AddYears(-age);
            Console.WriteLine("You were born in " + yearBorn);
            Console.Read();

        }
    }
}
