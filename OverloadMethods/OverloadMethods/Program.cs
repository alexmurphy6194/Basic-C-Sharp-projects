using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Operations forInt = new Operations();
            Console.WriteLine(forInt.sameMethod(12));
            

            Operations forDec = new Operations();
            Console.WriteLine(forDec.sameMethod(1.50234934m));

            Operations forString = new Operations();
            Console.WriteLine(forString.sameMethod("50"));

            Console.Read();
        }
    }
}
