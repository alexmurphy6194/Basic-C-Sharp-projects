using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 myClass = new Class1();
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());

            int y;
            myClass.outputInt(num, out y);
            Console.WriteLine(y);

            Console.WriteLine("Enter a decimal");
            decimal num2 = Convert.ToDecimal(Console.ReadLine());

            decimal z;
            staticclass.outputInt(num2, out z);
            Console.WriteLine(z);

            Console.Read();
        }
    }
}
