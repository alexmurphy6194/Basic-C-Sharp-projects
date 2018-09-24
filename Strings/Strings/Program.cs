using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Please enter a word");
        String word1 = Console.ReadLine();
        Console.WriteLine("Please enter a word");
        String word2 = Console.ReadLine();
        Console.WriteLine("Please enter a word");
        String word3 = Console.ReadLine();

        String link = word1 + " " + word2 + " " + word3;
        Console.WriteLine(link);

        Console.WriteLine("Please enter a word");
        String word4 = Console.ReadLine();
        Console.WriteLine(word4.ToUpper());

        StringBuilder sb = new StringBuilder("This is a paragraph about anything. ");
        Console.WriteLine("Write a sentence");
        sb.Append(Console.ReadLine() +". ");
        Console.WriteLine("Write a sentence");
        sb.Append(Console.ReadLine() + ".\n");
        Console.WriteLine("Write a sentence");
        sb.Append(Console.ReadLine() + ".");
        
        Console.WriteLine(sb);
        Console.Read();

    }
    }

