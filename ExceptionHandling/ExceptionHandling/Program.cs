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
        int user = Convert.ToInt32(Console.ReadLine());
        foreach (int num in ints)
        {
            Console.WriteLine(num / user);
        }
        try
        {
            Console.WriteLine("Enter a number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dividing the two....");
            int num3 = num1 / num2;
            Console.WriteLine("The first number " + num1 + " divided by the second number " + num2 + " equals " + num3);
            
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (DivideByZeroException dv)
        {
            Console.WriteLine("Please do not divide by zero");
        }
        catch (Exception general)
        {
            Console.WriteLine(general);

        }
        finally  {
            Console.Read();
        }
        
    }
    }

