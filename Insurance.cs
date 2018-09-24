using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Car insurance Approval Program");
        Console.WriteLine("What is your age");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Have you ever had a DUI? only enter True or False");
        bool dui = bool.Parse(Console.ReadLine());
        Console.WriteLine("How many speeding tickets do you have?");
        int tickets = Convert.ToInt32(Console.ReadLine());

        bool oldEnough = age > 15;
        bool threeTickets = tickets <= 3;

        bool qualified = oldEnough && threeTickets && (dui != true);
        Console.WriteLine(qualified);
        Console.Read();
    }
    }

