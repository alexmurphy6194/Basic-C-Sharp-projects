using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Anonymous Income Comparison Program");
        Console.WriteLine("Person 1");
        Console.WriteLine("Please enter your hourly rate");
        float rate1 = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Please enter hours worked per week");
        float hours1 = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Person 2");
        Console.WriteLine("Please enter your hourly rate");
        float rate2 = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Please enter hours worked per week");
        float hours2 = Convert.ToSingle(Console.ReadLine());
        float sal1 = rate1 * hours1 * 52;
        float sal2 = rate2 * hours2 * 52;
        Console.WriteLine("Annual salary of Person 1:");
        Console.WriteLine(sal1);
        Console.WriteLine("Annual salary of Person 2:");
        Console.WriteLine(sal2);
        Console.WriteLine("Does Person 1 make more money than Person 2?");
        bool salCompare = sal1 > sal2;
        Console.WriteLine(salCompare);
        Console.Read();
    }
    }

