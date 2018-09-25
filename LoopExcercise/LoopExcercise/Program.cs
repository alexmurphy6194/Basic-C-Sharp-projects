using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


    class Program
    {
        static void Main(string[] args)
        {
        //1.Create a one-dimensional Array of strings.Ask the user to input some text.
        //  Create a loop that goes through each string in the Array, adding the user’s text to the string.
        //  Then create a loop that prints off each string in the Array on a separate line.
        String[] basic = { "Very interesting", "click click tap", "!!!!", "ok", "Zuper" };
        Console.WriteLine("Please enter some text");
        string input = Console.ReadLine();
        for (int i=0; i<basic.Length; i++)
        {
            basic[i] = basic[i] +" " + input;
        }
        for (int i = 0; i < basic.Length; i++)
        {
            Console.WriteLine(basic[i]);
        }
        Thread.Sleep(1000);
        //2.Create an infinite loop.
        //for (int j = 1; j > 0; j++)
        //{
        //    Console.WriteLine(j);
        //}
        //3.Fix the infinite loop so it will execute.
        for (int j = 1; j < 3; j++)
        {
            Console.WriteLine(j);
        }
        Thread.Sleep(1000);
        //4.Create a loop where the comparison used to determine whether to continue iterating the loop is a “<” operator.
        for (int j = 1; j < 10; j++)
        {
            Console.WriteLine(j);
        }
        Thread.Sleep(1000);
        //5.Create a loop where the comparison used to determine whether to continue iterating the loop is a “<=” operator.
        for (int j = 1; j <= 13; j++)
        {
            Console.WriteLine(j);
        }
        Thread.Sleep(1000);
        //6.Create a List of strings where each item in the list is unique.
        //Ask the user to select text to search for in the List.
        //Create a loop that iterates through the loop and then 
        //displays the index of the array that contains matching text on the screen.

        List<string> unique = new List<string>() { "The", "dog", "ran", "very", "fast" };
        Console.WriteLine("Please enter a word to search for");
        string guess = Console.ReadLine();
        bool right = false;
        foreach (string word in unique)
        {
            if (guess == word)
            {
                Console.WriteLine(unique.IndexOf(word));
                right = true;
                break;
            }
        }
        if (right == false)
        {
            Console.WriteLine("The word you entered is not in the list");
        }
        Thread.Sleep(1000);
        //7.Add code to that above loop that tells a user if they put in text that isn’t in the List.

        //8.Add code to that above loop that stops it from executing once a match has been found.

        //9.Create a List of strings that has at least two identical strings in the List.
        //Ask the user to select text to search for in the List.
        //Create a loop that iterates through the loop and then 
        //displays the indices of the array that contain matching text on the screen.

        List<string> identical = new List<string>() { "The", "dog", "The", "fast", "ran", "very", "fast" };
        Console.WriteLine("Please enter a word to search for");
        string guess1 = Console.ReadLine();
        bool right1 = false;
        for (int i = 0; i < identical.Count;i++)
        {
            if (guess1 == identical[i])
            {
                Console.WriteLine(i);
                right1 = true;
            }
        }

        if (right1 == false)
        {
            Console.WriteLine("The word you entered is not in the list");
        }
        Thread.Sleep(1000);


        //10.Add code to that above loop that tells a user if they put in text that isn’t in the List.

        //11.Create a List of strings that has at least two identical strings in the List. 
        //Create a foreach loop that evaluates each item in the list, 
        //and displays a message showing the string and whether or not 
        //it has already appeared in the list.
        List<string> duplicates = new List<string>() { "The","The", "dog", "ran", "very", "fast","fast" };
        Console.WriteLine("Please enter a word to search for");
        string guess2 = Console.ReadLine();
        bool right3 = false;
        foreach (string word2 in duplicates)
        {
            if (guess2 == word2)
            {
                Console.WriteLine("The word " +guess2 +" you guessed appears in the List");
                right3 = true;
                break;
            }
        }
        if (right3 == false)
        {
            Console.WriteLine("The word " + guess2 + " you guessed did not appear in the List");
        }
        Console.Read();
    }
    }

