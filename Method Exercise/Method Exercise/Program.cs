using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Method_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Please enter a number you want the Operations performed on");
            int num = Convert.ToInt32(Console.ReadLine());
            Thread.Sleep(1000);

            Console.WriteLine("First we will determine if your number is Even or Odd....");
            Thread.Sleep(1000);
            string isEven = arithmetic.isEven(num);
            Console.WriteLine(isEven);

            Console.WriteLine("Next we will see what your number is squared...");
            Thread.Sleep(1000);
            int squared = arithmetic.squared(num);
            Console.WriteLine(squared);

            Console.WriteLine("Then we will see what your number is + 1.....");
            Thread.Sleep(1000);
            int plusOne = arithmetic.plusOne(num);
            Console.WriteLine(plusOne);

            Console.ReadLine();
        }
        
    }
}
