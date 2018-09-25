using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        List<int> ints = new List<int>() { 1, 2, 3, 4, 5, 6 };
        Console.WriteLine("Please enter a number to divide by");
        try
        {
            int user = Convert.ToInt32(Console.ReadLine());
            foreach (int num in ints)
            {
                Console.WriteLine(num / user);
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Please only type numbers");
        }
        catch (DivideByZeroException dv)
        {
            Console.WriteLine("Please do not divide by zero");
        }
        catch (Exception general)
        {
            Console.WriteLine(general);

        }
        Console.WriteLine("You are now outside of the Try/Catch block");
        Console.Read();
    }
}

