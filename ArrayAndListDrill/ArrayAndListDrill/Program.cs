using System;
using System.Collections.Generic;



    class Program
    {
        static void Main()
        {
        string[] words = { "salt", "pepper", "pepperoni", "papas fritas", "pork belly tacos" };
        Console.WriteLine("Please enter a number between 0 and 4");
        int choice = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(words[choice]);

        int[] nums = { 234, 543, 123, 756, 978 };
        Console.WriteLine("Please enter a number between 0 and 4");
        choice = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(nums[choice]);

        List<string> strings = new List<string>();
        strings.Add("Hot Tamale");
        strings.Add("Pico de Gallo");
        strings.Add("Banana Peppers");
        strings.Add("Tripe");
        strings.Add("Pambiche");

        Console.WriteLine("Please select a number between 0 and 4");
        choice = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(strings[choice]);

        Console.Read();

    }
    }

