using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main(string[] args)
        {
        String ans = "";
        do
        {
            Console.WriteLine("If you want to leave you must guess Correctly!");
            Console.WriteLine("Guess a letter");
            ans = Console.ReadLine();
        } while (ans != "x");
        Console.WriteLine("Good.");
        Console.WriteLine("Guess a number between 1 and 20");
        int ex1 = Convert.ToInt32(Console.ReadLine());
        while (ex1 > 10)
        {
            Console.WriteLine("Guess again!");
            ex1 = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("You can exit");
        Console.Read();


        }
    }

