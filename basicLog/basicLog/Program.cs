using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace basicLog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a Number");
            string num = Console.ReadLine();
            File.WriteAllText(@"..\log.txt", num);
            string readBack = File.ReadAllText(@"..\log.txt");
            Console.WriteLine(readBack);
            Console.Read();

        }
    }
}
