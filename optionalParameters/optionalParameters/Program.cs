using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace optionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            doMath num = new doMath();

            Console.WriteLine("Enter a number");
            int input1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another number... Or don't");
            string words = Console.ReadLine();

            int result;
            int input2;

            if (int.TryParse(words, out input2))
            {
                result = num.optionalNum(input1, input2);
                Console.WriteLine(result);
            }
            else
            {
                result = num.optionalNum(input1);
                Console.WriteLine(result);
            }
            Console.Read();
        }
    }
}
