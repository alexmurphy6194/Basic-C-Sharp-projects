using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Please enter a number");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int ans1 = num1 * 50;
        Console.WriteLine(ans1);
        Console.WriteLine("Please enter a number");
        int num2 = Convert.ToInt32(Console.ReadLine());
        int ans2 = num2 + 25;
        Console.WriteLine(ans2);
        Console.WriteLine("Please enter a number");
        int num3 = Convert.ToInt32(Console.ReadLine());
        float ans3 = num3 / 12.5f;
        Console.WriteLine(ans3);
        Console.WriteLine("Please enter a number");
        int num4 = Convert.ToInt32(Console.ReadLine());
        bool ans4 = num4 > 50;
        Console.WriteLine(ans4);
        Console.WriteLine("Please enter a number");
        int num5 = Convert.ToInt32(Console.ReadLine());
        int ans5 = num5 % 7;
        Console.WriteLine(ans5);
        Console.Read();

    }
    }

