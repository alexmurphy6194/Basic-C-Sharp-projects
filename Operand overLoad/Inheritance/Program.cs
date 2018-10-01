using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Employee1 = new Employee() { FirstName = "Sample", LastName = "Student" , Id = 1};
            Employee Employee2 = new Employee() { FirstName = "Alex", LastName="Murphy",Id = 2 };
            bool same = Employee1 == Employee2;
            Employee1.SayName();
            Console.WriteLine("And");
            Employee2.SayName();
            Console.WriteLine("Are the same employee?.....Looking at their ID's, this is " + same);

            Console.Read();
        }
    }
}
