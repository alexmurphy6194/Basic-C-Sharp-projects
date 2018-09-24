using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
        Console.WriteLine("What is the weight of the package?");
        float weight = Convert.ToSingle(Console.ReadLine());
        if (weight > 50){
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            Environment.Exit(0);
        }

        Console.WriteLine("What is the package width?");
        float width = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("What is the package height?");
        float height = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("What is the package length?");
        float length = Convert.ToSingle(Console.ReadLine());
        float dimensions = width + height + length;
        if (dimensions > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            Environment.Exit(0);
        }

        float quote = (dimensions * weight / 100);
        Console.WriteLine("Your insurance quote is $" + Math.Round(quote, 2));
        Console.Read();
    }
    }

