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
            employee employee1 = new employee() { FirstName = "Sample", LastName = "Student" };
            employee1.SayName();
            Console.Read();
        }
    }
}
